using System;
using UnityEngine;

public class HUDTweenManager
{
	public class TweenOptions
	{
		public bool CheckPosition { get; set; }

		public Action OnComplete { get; set; }
	}

	private const float SHOW_POSITION = 170f;

	private const float HIDE_POSITION = 340f;

	private const float MOVE_DISTANCE = 180f;

	private const float MOVE_DURATION = 0.3f;

	private const float BOUNCE_DURATION = 0.2f;

	public static void PlayHUDTween(GameObject rootObj, GameObject targetObj, bool show, bool direct = false, TweenOptions options = null)
	{
	}
}
