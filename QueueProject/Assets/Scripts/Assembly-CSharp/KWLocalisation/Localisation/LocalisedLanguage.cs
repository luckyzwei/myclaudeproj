using System.Collections;
using System.Collections.Generic;

namespace KWLocalisation.Localisation
{
	public class LocalisedLanguage
	{
		private Dictionary<string, object> m_strings;

		private int m_version;

		private string m_id;

		private Dictionary<string, string[]> m_arrays;

		public int Version => m_version;

		public Dictionary<string, object> Strings => m_strings;

		public Dictionary<string, string[]> Arrays => m_arrays;

		public string ID => m_id;

		public string GetString(string key)
		{
			if (m_strings != null && m_strings.TryGetValue(key, out var val))
				return val as string;
			return null;
		}

		public void ParseJsonData(Hashtable expandData)
		{
			m_strings = new Dictionary<string, object>();
			m_arrays = new Dictionary<string, string[]>();

			if (expandData == null) return;

			// Parse meta
			if (expandData.ContainsKey("meta"))
			{
				var meta = expandData["meta"] as Hashtable;
				if (meta != null)
				{
					if (meta.ContainsKey("l"))
						m_id = meta["l"] as string;
					if (meta.ContainsKey("v"))
					{
						var vStr = meta["v"]?.ToString();
						if (vStr != null)
							int.TryParse(vStr, out m_version);
					}
				}
			}

			// Parse objects (flat key-value)
			if (expandData.ContainsKey("objects"))
			{
				var objects = expandData["objects"] as Hashtable;
				if (objects != null)
				{
					foreach (DictionaryEntry entry in objects)
					{
						string key = entry.Key as string;
						if (key == null) continue;
						m_strings[key] = entry.Value;
					}
				}
			}
		}

		private void ParseRecursive(Hashtable expandData, Dictionary<string, object> dict, string fullKey = "")
		{
			if (expandData == null) return;
			foreach (DictionaryEntry entry in expandData)
			{
				string key = entry.Key as string;
				if (key == null) continue;
				string newKey = string.IsNullOrEmpty(fullKey) ? key : fullKey + "/" + key;
				if (entry.Value is Hashtable subTable)
					ParseRecursive(subTable, dict, newKey);
				else
					dict[newKey] = entry.Value;
			}
		}

		/// <summary>
		/// Parse nested JSON from Localisation_xx.txt files.
		/// Flattens nested keys with "." separator: {"Booster":{"Clear":"清除"}} → "Booster.Clear" = "清除"
		/// Merges into existing strings without overwriting.
		/// </summary>
		public void ParseNestedTextData(Hashtable data)
		{
			if (data == null) return;
			if (m_strings == null)
				m_strings = new Dictionary<string, object>();

			// "text" contains the nested translations
			if (data.ContainsKey("text"))
			{
				var text = data["text"] as Hashtable;
				if (text != null)
					FlattenWithDot(text, m_strings, "");
			}

			// Also read locale as fallback ID
			if (m_id == null && data.ContainsKey("locale"))
				m_id = data["locale"] as string;
		}

		private void FlattenWithDot(Hashtable table, Dictionary<string, object> dict, string prefix)
		{
			foreach (DictionaryEntry entry in table)
			{
				string key = entry.Key as string;
				if (key == null) continue;
				string fullKey = string.IsNullOrEmpty(prefix) ? key : prefix + "." + key;
				if (entry.Value is Hashtable subTable)
					FlattenWithDot(subTable, dict, fullKey);
				else if (!dict.ContainsKey(fullKey))
					dict[fullKey] = entry.Value;
			}
		}
	}
}
