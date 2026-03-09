using System;

namespace DeviceThermalStateIOS
{
	public static class ThermalStateListener
	{
		public static Action<ThermalState> OnThermalStateChanged;

		public static Action<bool> OnLowPowerModeChanged;

		public static void StartListen()
		{
		}

		public static void StopListen()
		{
		}
	}
}
