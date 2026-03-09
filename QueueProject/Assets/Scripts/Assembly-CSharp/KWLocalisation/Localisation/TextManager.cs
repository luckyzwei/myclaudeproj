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
		}

		private void InitializeInGame()
		{
		}

		public string Get(string key)
		{
			return null;
		}

		public bool Contains(string key)
		{
			return false;
		}

		public string Get(string key, int index)
		{
			return null;
		}

		public string GetRandom(string arrayKey)
		{
			return null;
		}

		public int Count(string key)
		{
			return 0;
		}

		public string[] GetAll(string key)
		{
			return null;
		}

		public void SetCurrentLanguage(string deviceLanguage)
		{
		}

		public string GetCurrentLanguage()
		{
			return null;
		}
	}
}
