using System;
using UnityEngine;

namespace DeviceThermalStateAndroid
{
	public class ThermalStateProxy : AndroidJavaProxy
	{
		public Action<ThermalState> Callback;

		public ThermalStateProxy()
			: base((string)null)
		{
		}

		private void onThermalStatusChanged(int status)
		{
		}
	}
}
