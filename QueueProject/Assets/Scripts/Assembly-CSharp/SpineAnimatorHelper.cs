using System;
using System.Collections.Generic;
using Spine;
using Spine.Unity;
using UnityEngine;

public class SpineAnimatorHelper : MonoBehaviour
{
	private ISkeletonComponent m_skeletonComponent;

	private IAnimationStateComponent m_animationStateComponent;

	private Dictionary<string, Spine.Animation> m_animationCache;

	private void Awake()
	{
	}

	private void CacheAnimations()
	{
	}

	public void Play(string animationName, Action onFinished = null, bool loop = false, int trackIndex = 0, float mixDuration = 0.2f)
	{
	}

	public void Add(string animationName, Action onFinished = null, bool loop = false, int trackIndex = 0, float mixDuration = 0.2f, float delay = 0f)
	{
	}

	public bool IsPlaying(string animationName, int trackIndex = 0)
	{
		return false;
	}

	public void Stop(int trackIndex = 0)
	{
	}

	public void SetAnimationSpeed(float speed)
	{
	}

	public List<string> GetAnimationList()
	{
		return null;
	}
}
