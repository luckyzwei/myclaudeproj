using DeviceThermalStateAndroid;
using UnityEngine;

public class PhoneRatingAnalytics : MonoBehaviour
{
	public class DeviceData
	{
		public string device_name;

		public string device_model;

		public string processor_type;

		public int processor_frequency;

		public int processor_count;

		public int graphics_memory_size;

		public int graphics_shader_level;

		public int graphics_device_id;

		public string graphics_device_name;

		public int max_graphics_buffer_size;

		public int system_memory_size;

		public int screen_dpi;

		public int screen_height;

		public int screen_width;
	}

	private static string EVENT_NAME;

	private ThermalState m_thermalState;

	private bool m_powerSave;

	private void OnDestroy()
	{
	}

	private void OnThermalStateChanged(ThermalState thermalState)
	{
	}

	private void OnPowerSaveModeChanged(bool powerSaveMode)
	{
	}

	private void Start()
	{
	}

	private string GetDeviceData()
	{
		return null;
	}

	public void SendPhoneRating()
	{
	}
}
