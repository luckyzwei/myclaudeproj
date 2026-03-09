using DG.Tweening;
using KWGameCore;
using UnityEngine;

public class TabToolbarConfig : GenericConfig<TabToolbarConfig>
{
	[Header("Highlight Params")]
	public float highlightAnimDuration;

	public float highlightIconYOffset;

	public Vector2 highlightGrowAmount;

	public Ease highlightEase;

	[Header("Back To Normal Params")]
	public float backToNormalAnimDuration;

	public Ease backtoNormalEase;

	public float lockYOffset;

	public float lockDuration;

	[Header("Swipe")]
	public float swipeIgnoreThreshold;

	public float fastSwipeTime;
}
