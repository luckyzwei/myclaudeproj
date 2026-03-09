using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

namespace KWCore.Debugging
{
	public static class Debugger
	{
		private enum Severity
		{
			MESSAGE = 1,
			WARNING = 0x10,
			ERROR = 0x100
		}

		public enum Colour
		{
			WHITE = 0,
			RED = 1,
			BLUE = 2,
			GREEN = 3,
			YELLOW = 4,
			BLACK = 5
		}

		private class System
		{
			public string name;

			public bool enableLogging;
		}

		private const string SAVE_FILE = "waffle_log.txt";

		private const string PREVIOUS_SAVE_FILE = "previous_waffle_log.txt";

		private const string PREFS_IM_GUI_ON = "IM_GUI_ON";

		private static readonly object streamWriterLockToken;

		private const string WHITE = "fafafa";

		private const string GREEN = "00FF00FF";

		private const string BLUE = "00FFFFFF";

		private const string YELLOW = "FFFF00FF";

		private const string RED = "FF0000FF";

		private const string BLACK = "000000FF";

		private const string DEBUG_STRING_WITH_COLOUR = "<color=#{0}>{1}</color>";

		private static int s_loggingLevel;

		private static System s_defaultSystem;

		private static System[] s_systems;

		private static bool s_popupsEnabled;

		private static readonly HashSet<string> s_ignoreDebug;

		private static StreamWriter s_logStream;

		public static void Init(Type gameSystems)
		{
		}

		public static void EnableDebugPopups(bool enabled)
		{
		}

		public static void IgnoreStackTrace(string stackTrace)
		{
		}

		public static void CloseFileStream()
		{
		}

		public static void EnableAllSystems(bool enable = true)
		{
		}

		public static void SetLoggingLevel(int level)
		{
		}

		public static void SetLoggingEnabled(bool enabled, int system)
		{
		}

		private static void Log(string log, Severity severity, GameObject contextObj = null, int system = -1, Colour colour = Colour.WHITE)
		{
		}

		public static void Log(string log, int system, Colour colour = Colour.WHITE, GameObject contextObj = null)
		{
		}

		public static void Warning(string log, int system = -1, GameObject contextObj = null)
		{
		}

		public static void Error(string log, GameObject contextObj = null)
		{
		}

		[Conditional("CANDIDATE_DEBUG")]
		[Conditional("NOT_SERVER_ENVIROMENT_CANDIDATE")]
		public static void LogHashtableAsJson(string message, Hashtable hashtable, int system = -1)
		{
		}

		[Conditional("CANDIDATE_DEBUG")]
		[Conditional("NOT_SERVER_ENVIROMENT_CANDIDATE")]
		public static void PrintHashTableAsServerObject(Hashtable hashtable, string name = "object", int system = -1)
		{
		}

		[Conditional("CANDIDATE_DEBUG")]
		[Conditional("NOT_SERVER_ENVIROMENT_CANDIDATE")]
		public static void PrintDictionaryAsServerObject(IDictionary<string, object> dictionary, string name = "object", int system = -1)
		{
		}

		[Conditional("CANDIDATE_DEBUG")]
		[Conditional("NOT_SERVER_ENVIROMENT_CANDIDATE")]
		public static void PrintHashTableKeys(Hashtable hashtable, string name = "object", int system = -1)
		{
		}

		[Conditional("CANDIDATE_DEBUG")]
		[Conditional("NOT_SERVER_ENVIROMENT_CANDIDATE")]
		public static void Assert(bool condition, string message)
		{
		}

		private static string GetColour(Colour colour)
		{
			return null;
		}

		private static void LogInternal(ref System system, string log, GameObject contextObj, Severity severity, Colour colour = Colour.WHITE)
		{
		}

		[Conditional("CANDIDATE_DEBUG")]
		[Conditional("NOT_SERVER_ENVIROMENT_CANDIDATE")]
		private static void LogStream(ref System system, string log, Severity severity)
		{
		}

		[Conditional("CANDIDATE_DEBUG")]
		[Conditional("NOT_SERVER_ENVIROMENT_CANDIDATE")]
		private static void LogUnityDebugger(ref System system, string log, GameObject contextObj, Severity severity, Colour colour = Colour.WHITE)
		{
		}

		private static void LogFirebase(ref System system, string log, Severity severity)
		{
		}

		public static string ServerObjectAsString(Hashtable hashtable, int level = 0)
		{
			return null;
		}

		private static string GetTabs(int level)
		{
			return null;
		}
	}
}
