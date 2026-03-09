using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorHelper : MonoBehaviour
{
	[Serializable]
	public class AnimationHelperState
	{
		public string animationName;

		[NonSerialized]
		public int animationNameHash;

		public int GetAnimNameHash()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	private class LayerData
	{
		public AnimationHelperState activeAnimationState;

		public Action animationCompleteCallback;

		public float currentlClipTime;

		public float startTime;

		public AnimationHelperState nextAnimationState;

		public bool animationFinished;

		public bool animationStarted;

		public LayerData(AnimationHelperState state, Action callback, float startTime)
		{
		}

		public void SetupNewActiveState(AnimationHelperState newActive)
		{
		}
	}

	[SerializeField]
	private bool m_continueAnimationOnEnable;

	[SerializeField]
	private bool m_turnOnAnimatorOnEnable;

	[Autohook]
	[SerializeField]
	private Animator m_animator;

	[SerializeField]
	[ReadOnly]
	private List<AnimationHelperState> m_animStates;

	private Dictionary<int, LayerData> m_animatorLayerDatas;

	private List<int> m_activeKeys;

	public IList<AnimationHelperState> AnimStates => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public List<AnimationHelperState> GetAnimationList()
	{
		return null;
	}

	public void SetStates(List<string> allStates)
	{
	}

	public void SetAnimator(Animator animator)
	{
	}

	public Animator GetAnimator()
	{
		return null;
	}

	public void ChangeAnimaState(int index, string animationName)
	{
	}

	private void PlayAnimationInternal(AnimationHelperState state, Action onFinished = null, float startTime = 0f, float crossfade = 0f, int layer = 0)
	{
	}

	private void Update()
	{
	}

	private bool ShouldUpdateAnimState()
	{
		return false;
	}

	public void Play(string animationName, Action onFinished = null, float startTime = 0f, bool checkIsPlayingFirst = false, float crossFade = 0f, int layer = 0)
	{
	}

	private void AnimationFinished(int layer)
	{
	}

	public bool HasAnimationStateWithName(string stateName)
	{
		return false;
	}

	private AnimationHelperState GetAnimStateFromAnimationName(string animationName)
	{
		return null;
	}

	private AnimationHelperState GetAnimStateFromAnimationNameHash(int animationNameHash)
	{
		return null;
	}

	private void UpdateAnimState()
	{
	}

	private void UpdateAnimStarted(AnimatorStateInfo stateInfo, int layer)
	{
	}

	private bool UpdateAnimFinished(AnimatorStateInfo stateInfo, int layer)
	{
		return false;
	}

	public AnimatorControllerParameter[] GetAnimatorParameters()
	{
		return null;
	}

	public string GetCurrentStateName(int layer = 0)
	{
		return null;
	}

	public float GetCurrentStateNormalisedTime(int layer = 0)
	{
		return 0f;
	}

	public void SetAnimatorSpeed(float speed)
	{
	}

	public void StopAnimator()
	{
	}

	public void SetBool(string key, bool value)
	{
	}

	public void SetInt(string key, int value)
	{
	}

	public void SetFloat(string key, float value)
	{
	}

	public void SetTrigger(string key)
	{
	}
}
