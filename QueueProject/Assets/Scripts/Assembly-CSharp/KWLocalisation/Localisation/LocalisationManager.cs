using System.Collections;
using System.Collections.Generic;
using KWCore.Utils;
using UnityEngine;

namespace KWLocalisation.Localisation
{
	public class LocalisationManager
	{
		public const string FALLBACK_TEXT = "-KEY NOT FOUND-";

		public const string DEFAULT_LANGUAGE_ID = "en";

		private const string BASEFILENAME = "Localisation_";

		private const string FILEEXTENSION = ".txt";

		private const string FILEFOLDER = "Configs/Localisation";

		// Actual JSON file prefix in Resources
		private const string JSON_FILE_PREFIX = "1cb7879e-9aa2-11ef-90be-066676c39f77_Localization-";

		private string m_currentLanguageID;

		private Dictionary<string, LocalisedLanguage> m_languages;

		private LocalisedLanguage m_currentLanguage;

		public void Initialize()
		{
			m_languages = new Dictionary<string, LocalisedLanguage>();
			// Default to Chinese, then try system language
			string langCode = GetSystemLanguageCode();
			SetLanguage(langCode);
			if (m_currentLanguage == null)
				SetLanguage(DEFAULT_LANGUAGE_ID);
		}

		private string GetSystemLanguageCode()
		{
			switch (UnityEngine.Application.systemLanguage)
			{
				case SystemLanguage.Chinese:
				case SystemLanguage.ChineseSimplified:
					return "zh-CN";
				case SystemLanguage.ChineseTraditional:
					return "zh-TW";
				case SystemLanguage.Japanese:
					return "ja";
				case SystemLanguage.Korean:
					return "ko";
				case SystemLanguage.French:
					return "fr";
				case SystemLanguage.German:
					return "de";
				case SystemLanguage.Spanish:
					return "es";
				case SystemLanguage.Portuguese:
					return "pt";
				case SystemLanguage.Italian:
					return "it";
				case SystemLanguage.Russian:
					return "ru";
				case SystemLanguage.Polish:
					return "pl";
				case SystemLanguage.Dutch:
					return "nl";
				case SystemLanguage.Swedish:
					return "sv";
				case SystemLanguage.Danish:
					return "da";
				case SystemLanguage.Turkish:
					return "tr";
				default:
					return "zh-CN";
			}
		}

		public bool ContainsKey(string key)
		{
			if (m_currentLanguage == null || m_currentLanguage.Strings == null) return false;
			return m_currentLanguage.Strings.ContainsKey(key);
		}

		public string GetString(string key)
		{
			if (m_currentLanguage != null)
			{
				string result = m_currentLanguage.GetString(key);
				if (result != null) return result;
			}
			return null;
		}

		public int GetArrayCount(string key)
		{
			if (m_currentLanguage != null && m_currentLanguage.Arrays != null &&
				m_currentLanguage.Arrays.TryGetValue(key, out var arr))
				return arr.Length;
			return 0;
		}

		public string[] GetArray(string key)
		{
			if (m_currentLanguage != null && m_currentLanguage.Arrays != null &&
				m_currentLanguage.Arrays.TryGetValue(key, out var arr))
				return arr;
			return null;
		}

		public string GetArrayEntry(string key, int index)
		{
			var arr = GetArray(key);
			if (arr != null && index >= 0 && index < arr.Length)
				return arr[index];
			return null;
		}

		public string GetArrayRandomEntry(string key)
		{
			var arr = GetArray(key);
			if (arr != null && arr.Length > 0)
				return arr[Random.Range(0, arr.Length)];
			return null;
		}

		public void SaveLanguageStringToFile(string language, string languageID)
		{
		}

		private bool ReadLanguageFile(string languageId)
		{
			var lang = new LocalisedLanguage();
			bool loaded = false;

			// 1) Load flat JSON file (1cb7879e-..._Localization-xx.json)
			string resourcePath = JSON_FILE_PREFIX + languageId;
			var textAsset = Resources.Load<TextAsset>(resourcePath);
			if (textAsset != null)
			{
				var hashtable = JsonSerializer.JsonDecode(textAsset.text) as Hashtable;
				if (hashtable != null)
				{
					lang.ParseJsonData(hashtable);
					loaded = true;
				}
			}

			// 2) Load nested txt file (configs/localisation/Localisation_xx.txt)
			//    Language ID mapping: "zh-CN" → try "zh_CN", "zh_Hans"; "zh-TW" → try "zh_TW", "zh_Hant"; "pt" → try "pt", "pt_PT"
			var txtIds = GetTxtLanguageIds(languageId);
			foreach (var txtId in txtIds)
			{
				string txtPath = FILEFOLDER + "/" + BASEFILENAME + txtId;
				var txtAsset = Resources.Load<TextAsset>(txtPath);
				if (txtAsset != null)
				{
					var txtHash = JsonSerializer.JsonDecode(txtAsset.text) as Hashtable;
					if (txtHash != null)
					{
						lang.ParseNestedTextData(txtHash);
						loaded = true;
						Debug.Log($"[LocalisationManager] Loaded txt: {txtPath} for {languageId}");
						break;
					}
				}
			}

			if (!loaded)
			{
				Debug.LogWarning($"[LocalisationManager] No language files found for: {languageId}");
				return false;
			}

			m_languages[languageId] = lang;
			Debug.Log($"[LocalisationManager] Loaded language: {languageId} ({lang.Strings?.Count ?? 0} strings)");
			return true;
		}

		private static List<string> GetTxtLanguageIds(string languageId)
		{
			var ids = new List<string>();
			// Convert dash to underscore: "zh-CN" → "zh_CN"
			string underscored = languageId.Replace('-', '_');
			ids.Add(underscored);

			// Add Hans/Hant variants for Chinese
			if (languageId == "zh-CN" || languageId == "zh_CN")
				ids.Add("zh_Hans");
			else if (languageId == "zh-TW" || languageId == "zh_TW")
				ids.Add("zh_Hant");

			// Also try without region: "pt-BR" → "pt"
			int dashIdx = languageId.IndexOf('-');
			if (dashIdx > 0)
				ids.Add(languageId.Substring(0, dashIdx));

			return ids;
		}

		private bool DoLanguageExist(string languageID)
		{
			if (m_languages != null && m_languages.ContainsKey(languageID))
				return true;
			string resourcePath = JSON_FILE_PREFIX + languageID;
			return Resources.Load<TextAsset>(resourcePath) != null;
		}

		public void SetLanguage(string languageID)
		{
			if (string.IsNullOrEmpty(languageID))
				languageID = DEFAULT_LANGUAGE_ID;

			m_currentLanguageID = languageID;

			if (m_languages == null)
				m_languages = new Dictionary<string, LocalisedLanguage>();

			if (!m_languages.ContainsKey(languageID))
			{
				if (!ReadLanguageFile(languageID))
				{
					if (languageID != DEFAULT_LANGUAGE_ID)
					{
						Debug.Log($"[LocalisationManager] Falling back to {DEFAULT_LANGUAGE_ID}");
						if (!m_languages.ContainsKey(DEFAULT_LANGUAGE_ID))
							ReadLanguageFile(DEFAULT_LANGUAGE_ID);
						m_languages.TryGetValue(DEFAULT_LANGUAGE_ID, out m_currentLanguage);
					}
					return;
				}
			}

			m_languages.TryGetValue(languageID, out m_currentLanguage);
		}

		public string GetLanguage()
		{
			return m_currentLanguageID;
		}

		public void SetCurrentLanguage(string languageID)
		{
			SetLanguage(languageID);
		}

		public string GetCurrentLanguage()
		{
			return m_currentLanguageID;
		}

		public int GetCurrentVersion()
		{
			return m_currentLanguage != null ? m_currentLanguage.Version : 0;
		}

		public void SaveLanguageToFile(string language, string languageID)
		{
		}
	}
}
