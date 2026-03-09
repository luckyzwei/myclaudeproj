using System.Collections.Generic;
using UnityEngine.Events;

public static class AddressableLoadingManager
{
	public static List<ILoadingInterface> m_loadingInterfaces;

	private static PopUpLoading m_activePopUp;

	public static void RegisterLoadingInterface(ILoadingInterface loadingInterface)
	{
	}

	public static void RemoveLoadingInterface(ILoadingInterface loadingInterface)
	{
	}

	public static void LogRemainingInterfaces()
	{
	}

	public static float GetCombinedProgress()
	{
		return 0f;
	}

	public static bool IsLoading()
	{
		return false;
	}

	public static bool TryShowLoadingPopup(UnityAction popupClosed)
	{
		return false;
	}

	public static string GetCurrentLoadingDescription()
	{
		return null;
	}
}
