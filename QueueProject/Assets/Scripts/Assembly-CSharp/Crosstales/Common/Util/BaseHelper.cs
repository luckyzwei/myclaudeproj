using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Crosstales.Common.Model.Enum;
using UnityEngine;

namespace Crosstales.Common.Util
{
	public abstract class BaseHelper
	{
		public static bool ApplicationIsPlaying;

		protected static readonly System.Random _rnd;

		private static string[] _args;

		private static int _androidAPILevel;

		public static CultureInfo BaseCulture => null;

		public static bool isEditorMode => false;

		public static bool isIL2CPP => false;

		public static Platform CurrentPlatform => default(Platform);

		public static int AndroidAPILevel => 0;

		public static bool isWindowsPlatform => false;

		public static bool isMacOSPlatform => false;

		public static bool isLinuxPlatform => false;

		public static bool isStandalonePlatform => false;

		public static bool isAndroidPlatform => false;

		public static bool isIOSPlatform => false;

		public static bool isTvOSPlatform => false;

		public static bool isWSAPlatform => false;

		public static bool isXboxOnePlatform => false;

		public static bool isPS4Platform => false;

		public static bool isWebGLPlatform => false;

		public static bool isWebPlatform => false;

		public static bool isWindowsBasedPlatform => false;

		public static bool isWSABasedPlatform => false;

		public static bool isAppleBasedPlatform => false;

		public static bool isIOSBasedPlatform => false;

		public static bool isMobilePlatform => false;

		public static bool isEditor => false;

		public static bool isWindowsEditor => false;

		public static bool isMacOSEditor => false;

		public static bool isLinuxEditor => false;

		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		public static string CreateString(string generateChars, int stringLength)
		{
			return null;
		}

		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		public static string FormatBytesToHRF(long bytes, bool useSI = false)
		{
			return null;
		}

		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		public static string GenerateLoremIpsum(int length, int minSentences = 1, int maxSentences = 2147483647, int minWords = 1, int maxWords = 15)
		{
			return null;
		}

		public static string LanguageToISO639(SystemLanguage language)
		{
			return null;
		}

		public static SystemLanguage ISO639ToLanguage(string isoCode)
		{
			return default(SystemLanguage);
		}

		public static object InvokeMethod(string className, string methodName, BindingFlags flags = BindingFlags.Static | BindingFlags.Public, params object[] parameters)
		{
			return null;
		}

		public static string GetArgument(string name)
		{
			return null;
		}

		public static string[] GetArguments()
		{
			return null;
		}

		public static Dictionary<string, List<string>> ParseJSON(string json)
		{
			return null;
		}

		private static string addLeadingZero(int value)
		{
			return null;
		}
	}
}
