namespace KWLocalisation.Localisation
{
	public class TextManager
	{
		public const string ELLIPSIS = "...";

		public const string EDITOR_LANG_ID = "EDITOR_LANG_ID";

		private static readonly bool DEBUG_TEST_MISSING_STRINGS;

		private const string DEBUG_MISSING_STRING_TEXT = "_0_";

		private LocalisationManager m_localisationManager;

		public void Initialise()
		{
			m_localisationManager = new LocalisationManager();
			m_localisationManager.Initialize();
		}

		private void InitializeInGame()
		{
		}

		public string Get(string key)
		{
			if (m_localisationManager == null) return key;
			string result = m_localisationManager.GetString(key);
			if (result != null) return result;
			// Try without prefix (e.g., "DEFAULT/key" -> search just "key")
			if (key != null && !key.Contains("/"))
			{
				string withPrefix = "DEFAULT/" + key;
				result = m_localisationManager.GetString(withPrefix);
				if (result != null) return result;
			}
			return key; // Return key itself as fallback
		}

		public bool Contains(string key)
		{
			if (m_localisationManager == null) return false;
			return m_localisationManager.ContainsKey(key);
		}

		public string Get(string key, int index)
		{
			if (m_localisationManager == null) return key;
			return m_localisationManager.GetArrayEntry(key, index) ?? key;
		}

		public string GetRandom(string arrayKey)
		{
			if (m_localisationManager == null) return arrayKey;
			return m_localisationManager.GetArrayRandomEntry(arrayKey) ?? arrayKey;
		}

		public int Count(string key)
		{
			if (m_localisationManager == null) return 0;
			return m_localisationManager.GetArrayCount(key);
		}

		public string[] GetAll(string key)
		{
			if (m_localisationManager == null) return null;
			return m_localisationManager.GetArray(key);
		}

		public void SetCurrentLanguage(string deviceLanguage)
		{
			if (m_localisationManager != null)
				m_localisationManager.SetLanguage(deviceLanguage);
		}

		public string GetCurrentLanguage()
		{
			if (m_localisationManager != null)
				return m_localisationManager.GetCurrentLanguage();
			return null;
		}
	}
}
