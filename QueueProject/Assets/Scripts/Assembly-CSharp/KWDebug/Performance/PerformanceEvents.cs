using System;

namespace KWDebug.Performance
{
	public class PerformanceEvents
	{
		public static Action<string> StartPerformanceDataCollectionEvent;

		public static Action StopPerformanceDataCollectionEvent;

		public static Action<bool> ActivateFPSEvent;

		public static Action<float> FPSValuesEvent;

		public static void SendStartPerformanceDataCollectionEvent(string fileName)
		{
		}

		public static void SendStopPerformanceDataCollectionEvent()
		{
		}

		public static void SendActivateFPSEvent(bool isFPSActivated)
		{
		}

		public static void SendFPSValuesEvent(float fpsValue)
		{
		}
	}
}
