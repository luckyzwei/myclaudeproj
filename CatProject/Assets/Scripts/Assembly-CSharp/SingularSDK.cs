using System.Collections.Generic;
using UnityEngine;

public class SingularSDK : MonoBehaviour
{
	private enum NSType
	{
		STRING = 0,
		INT = 1,
		LONG = 2,
		FLOAT = 3,
		DOUBLE = 4,
		NULL = 5,
		ARRAY = 6,
		DICTIONARY = 7
	}

	private class SingularConfig
	{
		private Dictionary<string, object> _configValues;

		public void SetValue(string key, object value)
		{
		}

		public string ToJsonString()
		{
			return null;
		}
	}

	private class SingularGlobalProperty
	{
		public string Key { get; set; }

		public string Value { get; set; }

		public bool OverrideExisting { get; set; }

		public SingularGlobalProperty(string key, string value, bool overrideExisting)
		{
		}
	}

	public string SingularAPIKey;

	public string SingularAPISecret;

	public bool InitializeOnAwake;

	public bool autoIAPComplete;

	private Dictionary<string, SingularGlobalProperty> globalProperties;

	private static ShortLinkCallback shortLinkCallback;

	public static bool batchEvents;

	public static bool endSessionOnGoingToBackground;

	public static bool restartSessionOnReturningToForeground;

	public static bool enableDeferredDeepLinks;

	public bool enableLogging;

	public int logLevel;

	public static string fcmDeviceToken;

	public static string facebookAppId;

	public bool clipboardAttribution;

	public static string openUri;

	public bool collectOAID;

	public bool limitedIdentifiersEnabled;

	private static string imei;

	private static string customUserId;

	public long ddlTimeoutSec;

	public long sessionTimeoutSec;

	public long shortlinkResolveTimeout;

	public bool SKANEnabled;

	public bool manualSKANConversionManagement;

	public int waitForTrackingAuthorizationWithTimeoutInterval;

	private const long DEFAULT_SHORT_LINKS_TIMEOUT = 10L;

	private const long DEFAULT_DDL_TIMEOUT = 60L;

	private SingularLinkParams resolvedSingularLinkParams;

	private int resolvedSingularLinkTime;

	private static bool Initialized;

	private const string UNITY_WRAPPER_NAME = "Unity";

	private const string UNITY_VERSION = "4.0.19";

	private static AndroidJavaClass singular;

	private static AndroidJavaClass jclass;

	private static AndroidJavaObject activity;

	private static AndroidJavaClass jniSingularUnityBridge;

	private static bool status;

	private const string ADMON_REVENUE_EVENT_NAME = "__ADMON_USER_LEVEL_REVENUE__";

	private static SingularSDK instance;

	public static SingularLinkHandler registeredSingularLinkHandler;

	public static SingularDeferredDeepLinkHandler registeredDDLHandler;

	public static SingularConversionValueUpdatedHandler registeredConversionValueUpdatedHandler;

	public static SingularConversionValuesUpdatedHandler registeredConversionValuesUpdatedHandler;

	private static int cachedDDLMessageTime;

	private static string cachedDDLMessage;

	private void Awake()
	{
	}

	public static void InitializeSingularSDK()
	{
	}

	public static void createReferrerShortLink(string baseLink, string referrerName, string referrerId, Dictionary<string, string> passthroughParams, ShortLinkCallback completionHandler)
	{
	}

	private static SingularConfig BuildSingularConfig()
	{
		return null;
	}

	public void Update()
	{
	}

	private static void initSDK(SingularConfig config)
	{
	}

	private static void InitAndroidJavaClasses()
	{
	}

	private static AndroidJavaObject JavaArrayFromCS(string[] values)
	{
		return null;
	}

	private static bool StartSingularSession(SingularConfig config)
	{
		return false;
	}

	public static bool StartSingularSessionWithLaunchOptions(string key, string secret, Dictionary<string, object> options)
	{
		return false;
	}

	public static bool StartSingularSessionWithLaunchURL(string key, string secret, string url)
	{
		return false;
	}

	public static void RestartSingularSession(string key, string secret)
	{
	}

	public static void EndSingularSession()
	{
	}

	public static void Event(string name)
	{
	}

	public static void Event(Dictionary<string, object> args, string name)
	{
	}

	public static void Event(string name, params object[] args)
	{
	}

	public static void SetDeviceCustomUserId(string customUserId)
	{
	}

	public static void SetAge(int age)
	{
	}

	public static void SetGender(string gender)
	{
	}

	public static void SetAllowAutoIAPComplete(bool allowed)
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public static void SetDeferredDeepLinkHandler(SingularDeferredDeepLinkHandler ddlHandler)
	{
	}

	public void DeepLinkHandler(string message)
	{
	}

	private static int CurrentTimeSec()
	{
		return 0;
	}

	public static void SetSingularLinkHandler(SingularLinkHandler handler)
	{
	}

	private void SingularLinkHandlerResolved(string handlerParamsJson)
	{
	}

	private void ShortLinkResolved(string json)
	{
	}

	public static void SetConversionValueUpdatedHandler(SingularConversionValueUpdatedHandler handler)
	{
	}

	public static void SetConversionValuesUpdatedHandler(SingularConversionValuesUpdatedHandler handler)
	{
	}

	private void ConversionValueUpdated(string value)
	{
	}

	private void ConversionValuesUpdated(string json)
	{
	}

	private void ResolveSingularLink()
	{
	}

	public static void RegisterDeviceTokenForUninstall(string APNSToken)
	{
	}

	public static string GetAPID()
	{
		return null;
	}

	public static string GetIDFA()
	{
		return null;
	}

	public static void Revenue(string currency, double amount)
	{
	}

	public static void CustomRevenue(string eventName, string currency, double amount)
	{
	}

	public static void Revenue(string currency, double amount, string receipt, string signature)
	{
	}

	public static void CustomRevenue(string eventName, string currency, double amount, string receipt, string signature)
	{
	}

	public static void Revenue(string currency, double amount, string productSKU, string productName, string productCategory, int productQuantity, double productPrice)
	{
	}

	public static void CustomRevenue(string eventName, string currency, double amount, string productSKU, string productName, string productCategory, int productQuantity, double productPrice)
	{
	}

	public static void RegisterTokenForUninstall(string token)
	{
	}

	public static void SetFCMDeviceToken(string fcmDeviceToken)
	{
	}

	public static void SetGCMDeviceToken(string gcmDeviceToken)
	{
	}

	public static void SetCustomUserId(string userId)
	{
	}

	public static void UnsetCustomUserId()
	{
	}

	public static void TrackingOptIn()
	{
	}

	public static void TrackingUnder13()
	{
	}

	public static void StopAllTracking()
	{
	}

	public static void ResumeAllTracking()
	{
	}

	public static bool IsAllTrackingStopped()
	{
		return false;
	}

	public static void LimitDataSharing(bool limitDataSharingValue)
	{
	}

	public static bool GetLimitDataSharing()
	{
		return false;
	}

	public static void AdRevenue(SingularAdData adData)
	{
	}

	public static void SetIMEI(string imeiData)
	{
	}

	public static Dictionary<string, string> GetGlobalProperties()
	{
		return null;
	}

	public static bool SetGlobalProperty(string key, string value, bool overrideExisting)
	{
		return false;
	}

	public static void UnsetGlobalProperty(string key)
	{
	}

	public static void ClearGlobalProperties()
	{
	}

	public static void SkanRegisterAppForAdNetworkAttribution()
	{
	}

	public static bool SkanUpdateConversionValue(int conversionValue)
	{
		return false;
	}

	public static void SkanUpdateConversionValue(int conversionValue, int coarse, bool _lock)
	{
	}

	public static int? SkanGetConversionValue()
	{
		return null;
	}
}
