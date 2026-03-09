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
	}
}
