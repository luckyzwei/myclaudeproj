using System;
using UnityEngine;

namespace DeviceThermalStateAndroid
{
	public static class PowerManager
	{
		public static Action<ThermalState> OnThermalStateChanged;

		public static Action<bool> OnPowerSaveModeChanged;

		private static AndroidJavaObject context;

		private static AndroidJavaObject powerUtils;

		private static ThermalStateProxy thermalStateProxy;

		private static PowerSaveModeProxy powerSaveModeProxy;

		private static bool initialized;

		private static void Init()
		{
		}

		public static void StartListen()
		{
		}

		public static void StopListen()
		{
		}

		public static ThermalState GetCurrentThermalState()
		{
			return default(ThermalState);
		}

		public static LocationMode GetLocationPowerSaveMode()
		{
			return default(LocationMode);
		}

		public static float GetThermalHeadroom(int forecastSeconds)
		{
			return 0f;
		}

		public static bool IsDeviceIdle()
		{
			return false;
		}

		public static bool IsIgnoringBatteryOptimizations(string packageName)
		{
			return false;
		}

		public static bool IsInteractive()
		{
			return false;
		}

		public static bool IsPowerSaveMode()
		{
			return false;
		}
	}
}
