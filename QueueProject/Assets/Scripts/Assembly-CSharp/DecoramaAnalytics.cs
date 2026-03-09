using KWAnalytics.Analytics;
using UnityEngine;

public class DecoramaAnalytics : MonoBehaviour
{
	private const string DECORAMA_START = "decorama_paint_start";

	private const string DECORAMA_END = "decorama_paint_end";

	private const string DECORAMA_COMPLETED = "decorama_completed";

	private const string DECORAMA_PAINT_BUTTON = "decorama_paint_button";

	private static DecoramaDataPacket _sDecoramaDataPacket;

	public static void PopulateDataPacket()
	{
	}

	public static void SendDecoramaStartAnalytic()
	{
	}

	public static void SendDecoramaEndAnalytic()
	{
	}

	public static void SendDecoramaPaintButtonAnalytics()
	{
	}

	private static void SendBasicDecoramaEvent(string eventName)
	{
	}

	public static void SendDecoramaCompletedEvent(string decoramaId, int decoramaIndex)
	{
	}

	public static void IncrementTap()
	{
	}
}
