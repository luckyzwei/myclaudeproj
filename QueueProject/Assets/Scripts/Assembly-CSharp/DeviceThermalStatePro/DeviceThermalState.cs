using DeviceThermalStateAndroid;
using DeviceThermalStateIOS;
using UnityEngine;

namespace DeviceThermalStatePro
{
	public class DeviceThermalState : MonoBehaviour
	{
		private void Start()
		{
		}

		private void OnThermalStateAndroidChanged(DeviceThermalStateAndroid.ThermalState state)
		{
		}

		private void OnPowerSaveModeChanged(bool isPowerSaveModeEnabled)
		{
		}

		private void OnThermalStateIOSChanged(DeviceThermalStateIOS.ThermalState state)
		{
		}

		private void OnLowPowerModeChanged(bool isLowPowerModeEnabled)
		{
		}
	}
}
