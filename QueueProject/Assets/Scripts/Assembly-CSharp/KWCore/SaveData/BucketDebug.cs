using System.Collections.Generic;
using KWCore.Debugging;

namespace KWCore.SaveData
{
	public class BucketDebug : BucketBase
	{
		private const string DEBUGGER_SETTINGS = "debugger_settings";

		[KeyString]
		public const string LOCALIZED_CURRENCY = "LOCALIZED_CURRENCY";

		[KeyBool]
		public const string LOCALIZED_CURRENCY_ENABLED = "LOCALIZED_CURRENCY_ENABLED";

		private static BucketDebug s_bucketdebug;

		public List<DebuggerSetting> DebuggerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string LocalizedCurrency
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool LocalizedCurrencyEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string GetBucketKey()
		{
			return null;
		}

		public override bool IsStoredInCloud()
		{
			return false;
		}

		private static BucketDebug GetBucket()
		{
			return null;
		}

		public static string GetLocalizedCurrency(string defaultValue = null)
		{
			return null;
		}

		public static void SetLocalizedCurrency(string value)
		{
		}

		public static bool GetLocalizedCurrencyEnabled(bool defaultValue = false)
		{
			return false;
		}

		public static void SetLocalizedCurrencyEnabled(bool value)
		{
		}
	}
}
