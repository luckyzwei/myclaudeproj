using System.Collections.Generic;

namespace KWLocalisation.Localisation
{
	public class LocalisationManager
	{
		public const string FALLBACK_TEXT = "-KEY NOT FOUND-";

		public const string DEFAULT_LANGUAGE_ID = "en";

		private const string BASEFILENAME = "Localisation_";

		private const string FILEEXTENSION = ".txt";

		private const string FILEFOLDER = "Configs/Localisation";

		private string m_currentLanguageID;

		private Dictionary<string, LocalisedLanguage> m_languages;

		private LocalisedLanguage m_currentLanguage;

		public void Initialize()
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public string GetString(string key)
		{
			return null;
		}

		public int GetArrayCount(string key)
		{
			return 0;
		}

		public string[] GetArray(string key)
		{
			return null;
		}

		public string GetArrayEntry(string key, int index)
		{
			return null;
		}

		public string GetArrayRandomEntry(string key)
		{
			return null;
		}

		public void SaveLanguageStringToFile(string language, string languageID)
		{
		}

		private bool ReadLanguageFile(string languageId)
		{
			return false;
		}

		private bool DoLanguageExist(string languageID)
		{
			return false;
		}

		public void SetLanguage(string languageID)
		{
		}

		public string GetLanguage()
		{
			return null;
		}

		public void SetCurrentLanguage(string languageID)
		{
		}

		public string GetCurrentLanguage()
		{
			return null;
		}

		public int GetCurrentVersion()
		{
			return 0;
		}

		public void SaveLanguageToFile(string language, string languageID)
		{
		}
	}
}
