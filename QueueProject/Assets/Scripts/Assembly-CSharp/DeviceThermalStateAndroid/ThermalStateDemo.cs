using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DeviceThermalStateAndroid
{
	public class ThermalStateDemo : MonoBehaviour
	{
		public Text ThermalStateText;

		public Text PowerSaveModeText;

		public Text TotalSpheresText;

		public Button AddSpheresButton;

		public Button RemoveSpheresButton;

		public GameObject Model;

		public int InstantiateSpheres;

		private List<GameObject> list;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnStart()
		{
		}

		private void OnStop()
		{
		}

		private void UpdateSpheresCount()
		{
		}

		private void OnThermalStateChanged(ThermalState state)
		{
		}

		private void OnPowerSaveModeChanged(bool isEnabled)
		{
		}
	}
}
