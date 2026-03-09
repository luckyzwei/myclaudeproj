using UnityEngine;

public class HapticsAndroid : HapticsBase
{
	private AndroidJavaObject CurrentActivity;

	public override bool IsSupported()
	{
		return false;
	}

	public override void Trigger(int type)
	{
	}
}
