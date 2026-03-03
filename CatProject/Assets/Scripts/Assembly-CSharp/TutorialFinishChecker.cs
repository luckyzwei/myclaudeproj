using System;
using UnityEngine;

public class TutorialFinishChecker : MonoBehaviour
{
	[Serializable]
	public enum CheckerType
	{
		Slider = 0
	}

	public CheckerType type;

	public GameObject targetUI;

	public float targetValue;

	public bool IsFinish()
	{
		return false;
	}
}
