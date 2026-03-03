using System;
using AppsFlyerSDK;
using UnityEngine;

public class AppsflyerConversationObject : MonoBehaviour, IAppsFlyerConversionData
{
	public Action<string, string> UserSegmentAction;

	public void onConversionDataSuccess(string conversionData)
	{
	}

	public void onConversionDataFail(string error)
	{
	}

	public void onAppOpenAttribution(string attributionData)
	{
	}

	public void onAppOpenAttributionFailure(string error)
	{
	}
}
