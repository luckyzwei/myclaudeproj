using Balancy.Models.SmartObjects;
using UnityEngine;

public class SpinWheelAnalytics : MonoBehaviour
{
	private const string SPIN_WHEEL_OPENED = "spin_wheel_opened";

	private const string SPIN_WHEEL_SPUN = "spin_wheel_spun";

	private static SpinWheelDataPacket s_spinWheelDataPacket;

	public static void PopulateDataPacket(bool isRv, Reward reward, float weight)
	{
	}

	public static void SendWheelOpenedEvent()
	{
	}

	public static void SendWheelSpunEvent()
	{
	}

	public static void SendSpinWheelEvent(string eventName)
	{
	}
}
