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

		public int Version => 0;

		public Dictionary<string, object> Strings => null;

		public Dictionary<string, string[]> Arrays => null;

		public string ID => null;

		public string GetString(string key)
		{
			return null;
		}

		public void ParseJsonData(Hashtable expandData)
		{
		}

		private void ParseRecursive(Hashtable expandData, Dictionary<string, object> dict, string fullKey = "")
		{
		}
	}
}
