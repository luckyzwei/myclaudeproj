using System;
using UnityEngine;

namespace DeviceThermalStateAndroid
{
	public class PowerSaveModeProxy : AndroidJavaProxy
	{
		public Action<bool> Callback;

		public PowerSaveModeProxy()
			: base((string)null)
		{
		}

		private void onPowerSaveModeChanged(bool isEnabled)
		{
		}
	}
}
