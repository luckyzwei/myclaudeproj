using UnityEngine;
using UnityEngine.UI;

public class HudStarRewardComponent : MonoBehaviour
{
	public enum StarRewardState
	{
		None = -1,
		Disable = 0,
		Enable = 1,
		Receive = 2
	}

	[SerializeField]
	private Image rewardImg;

	[SerializeField]
	private GameObject checkObj;

	[SerializeField]
	private GameObject RedDot;

	private DoTweenScriptComponent[] tweenArr;

	private StarRewardState curState;

	private void Awake()
	{
	}

	public Image GetRewardImg()
	{
		return null;
	}

	public void SetState(StarRewardState state)
	{
	}
}
