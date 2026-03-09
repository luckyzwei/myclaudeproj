namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("device_info", "An event sent that captures device information")]
	public class DeviceInfo : AnalyticEvent
	{
		[AnalyticsEventParameter("device_model", "The model of the device")]
		public AnalyticsParameter<string> deviceModel;

		[AnalyticsEventParameter("device_os", "The operating system of the device")]
		public AnalyticsParameter<string> deviceOS;

		[AnalyticsEventParameter("device_os_version", "The version of the operating system of the device")]
		public AnalyticsParameter<string> deviceOSVersion;

		[AnalyticsEventParameter("device_screen_dpi", "The dpi of the screen of the device")]
		public AnalyticsParameter<float> deviceScreenDPI;

		[AnalyticsEventParameter("device_screen_width", "The width of the screen of the device in inches")]
		public AnalyticsParameter<float> deviceScreenWidth;

		[AnalyticsEventParameter("device_screen_height", "The height of the screen of the device in inches")]
		public AnalyticsParameter<float> deviceScreenHeight;

		[AnalyticsEventParameter("device_system_memory", "The amount of system memory of the device in MB")]
		public AnalyticsParameter<float> deviceSystemMemory;

		[AnalyticsEventParameter("device_processor_type", "The type of processor of the device")]
		public AnalyticsParameter<string> deviceProcessorType;

		[AnalyticsEventParameter("device_gpu_name", "The graphics name of the device")]
		public AnalyticsParameter<string> deviceGPUName;

		public DeviceInfo()
			: base(null)
		{
		}
	}
}
