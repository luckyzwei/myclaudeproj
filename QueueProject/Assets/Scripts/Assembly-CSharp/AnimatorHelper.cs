using System;
using System.Collections.Generic;
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
			if (animationNameHash == 0 && !string.IsNullOrEmpty(animationName))
				animationNameHash = Animator.StringToHash(animationName);
			return animationNameHash;
		}

		public override string ToString()
		{
			return animationName ?? string.Empty;
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
			activeAnimationState = state;
			animationCompleteCallback = callback;
			this.startTime = startTime;
			animationFinished = false;
			animationStarted = false;
			currentlClipTime = 0f;
		}

		public void SetupNewActiveState(AnimationHelperState newActive)
		{
			activeAnimationState = newActive;
			animationFinished = false;
			animationStarted = false;
			currentlClipTime = 0f;
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
	private List<AnimationHelperState> m_animStates;

	private Dictionary<int, LayerData> m_animatorLayerDatas;

	private List<int> m_activeKeys;

	public IList<AnimationHelperState> AnimStates => m_animStates;

	private void Awake()
	{
		if (m_animator == null)
			m_animator = GetComponent<Animator>();
		m_animatorLayerDatas = new Dictionary<int, LayerData>();
		m_activeKeys = new List<int>();
		if (m_animStates != null)
		{
			for (int i = 0; i < m_animStates.Count; i++)
				m_animStates[i].GetAnimNameHash();
		}
	}

	private void OnEnable()
	{
		if (m_turnOnAnimatorOnEnable && m_animator != null)
			m_animator.enabled = true;
	}

	private void OnDisable()
	{
		if (m_animator != null && !m_continueAnimationOnEnable)
			m_animator.enabled = false;
	}

	public List<AnimationHelperState> GetAnimationList()
	{
		return m_animStates;
	}

	public void SetStates(List<string> allStates)
	{
		m_animStates = new List<AnimationHelperState>();
		for (int i = 0; i < allStates.Count; i++)
		{
			var state = new AnimationHelperState();
			state.animationName = allStates[i];
			state.GetAnimNameHash();
			m_animStates.Add(state);
		}
	}

	public void SetAnimator(Animator animator)
	{
		m_animator = animator;
	}

	public Animator GetAnimator()
	{
		return m_animator;
	}

	public void ChangeAnimaState(int index, string animationName)
	{
		if (m_animStates != null && index >= 0 && index < m_animStates.Count)
		{
			m_animStates[index].animationName = animationName;
			m_animStates[index].GetAnimNameHash();
		}
	}

	private void PlayAnimationInternal(AnimationHelperState state, Action onFinished = null, float startTime = 0f, float crossfade = 0f, int layer = 0)
	{
		if (m_animator == null || state == null) return;
		m_animator.enabled = true;
		var layerData = new LayerData(state, onFinished, startTime);
		m_animatorLayerDatas[layer] = layerData;
		if (!m_activeKeys.Contains(layer))
			m_activeKeys.Add(layer);
		if (crossfade > 0f)
			m_animator.CrossFade(state.GetAnimNameHash(), crossfade, layer, startTime);
		else
			m_animator.Play(state.GetAnimNameHash(), layer, startTime);
	}

	private void Update()
	{
		if (ShouldUpdateAnimState())
			UpdateAnimState();
	}

	private bool ShouldUpdateAnimState()
	{
		return m_animator != null && m_animator.enabled && m_activeKeys != null && m_activeKeys.Count > 0;
	}

	public void Play(string animationName, Action onFinished = null, float startTime = 0f, bool checkIsPlayingFirst = false, float crossFade = 0f, int layer = 0)
	{
		var state = GetAnimStateFromAnimationName(animationName);
		if (state == null)
		{
			state = new AnimationHelperState();
			state.animationName = animationName;
			state.GetAnimNameHash();
		}
		if (checkIsPlayingFirst && m_animatorLayerDatas != null && m_animatorLayerDatas.ContainsKey(layer))
		{
			var existing = m_animatorLayerDatas[layer];
			if (existing != null && existing.activeAnimationState == state && !existing.animationFinished)
				return;
		}
		PlayAnimationInternal(state, onFinished, startTime, crossFade, layer);
	}

	private void AnimationFinished(int layer)
	{
		if (m_animatorLayerDatas == null || !m_animatorLayerDatas.ContainsKey(layer)) return;
		var data = m_animatorLayerDatas[layer];
		if (data == null) return;
		data.animationFinished = true;
		m_activeKeys.Remove(layer);
		var cb = data.animationCompleteCallback;
		data.animationCompleteCallback = null;
		cb?.Invoke();
	}

	public bool HasAnimationStateWithName(string stateName)
	{
		return GetAnimStateFromAnimationName(stateName) != null;
	}

	private AnimationHelperState GetAnimStateFromAnimationName(string animationName)
	{
		if (m_animStates == null) return null;
		for (int i = 0; i < m_animStates.Count; i++)
		{
			if (m_animStates[i].animationName == animationName)
				return m_animStates[i];
		}
		return null;
	}

	private AnimationHelperState GetAnimStateFromAnimationNameHash(int animationNameHash)
	{
		if (m_animStates == null) return null;
		for (int i = 0; i < m_animStates.Count; i++)
		{
			if (m_animStates[i].GetAnimNameHash() == animationNameHash)
				return m_animStates[i];
		}
		return null;
	}

	private void UpdateAnimState()
	{
		for (int i = m_activeKeys.Count - 1; i >= 0; i--)
		{
			int layer = m_activeKeys[i];
			if (!m_animatorLayerDatas.ContainsKey(layer)) continue;
			var stateInfo = m_animator.GetCurrentAnimatorStateInfo(layer);
			UpdateAnimStarted(stateInfo, layer);
			if (UpdateAnimFinished(stateInfo, layer))
				AnimationFinished(layer);
		}
	}

	private void UpdateAnimStarted(AnimatorStateInfo stateInfo, int layer)
	{
		if (!m_animatorLayerDatas.ContainsKey(layer)) return;
		var data = m_animatorLayerDatas[layer];
		if (data == null || data.animationStarted) return;
		if (data.activeAnimationState != null && stateInfo.shortNameHash == data.activeAnimationState.GetAnimNameHash())
			data.animationStarted = true;
	}

	private bool UpdateAnimFinished(AnimatorStateInfo stateInfo, int layer)
	{
		if (!m_animatorLayerDatas.ContainsKey(layer)) return false;
		var data = m_animatorLayerDatas[layer];
		if (data == null || !data.animationStarted || data.animationFinished) return false;
		if (stateInfo.normalizedTime >= 1f && !m_animator.IsInTransition(layer))
			return true;
		return false;
	}

	public AnimatorControllerParameter[] GetAnimatorParameters()
	{
		if (m_animator == null) return null;
		return m_animator.parameters;
	}

	public string GetCurrentStateName(int layer = 0)
	{
		if (m_animatorLayerDatas != null && m_animatorLayerDatas.ContainsKey(layer))
		{
			var data = m_animatorLayerDatas[layer];
			if (data != null && data.activeAnimationState != null)
				return data.activeAnimationState.animationName;
		}
		return null;
	}

	public float GetCurrentStateNormalisedTime(int layer = 0)
	{
		if (m_animator == null) return 0f;
		return m_animator.GetCurrentAnimatorStateInfo(layer).normalizedTime;
	}

	public void SetAnimatorSpeed(float speed)
	{
		if (m_animator != null)
			m_animator.speed = speed;
	}

	public void StopAnimator()
	{
		if (m_animator != null)
			m_animator.enabled = false;
	}

	public void SetBool(string key, bool value)
	{
		if (m_animator != null)
			m_animator.SetBool(key, value);
	}

	public void SetInt(string key, int value)
	{
		if (m_animator != null)
			m_animator.SetInteger(key, value);
	}

	public void SetFloat(string key, float value)
	{
		if (m_animator != null)
			m_animator.SetFloat(key, value);
	}

	public void SetTrigger(string key)
	{
		if (m_animator != null)
			m_animator.SetTrigger(key);
	}
}
