using System;
using System.Collections.Generic;
using KWCore.Utils;
using UnityEngine;

namespace KWCore.UI
{
	public class UIAnimator : BaseBehaviour
	{
		[Serializable]
		public class UIAnimState
		{
			public string animationName;

			public bool isPositionRelative;

			public bool overrideFirstPosition;

			[NonSerialized]
			public int animationNameHash;

			public int GetAnimNameHash()
			{
				return 0;
			}
		}

		[SerializeField]
		private List<UIAnimState> m_animStates;

		[SerializeField]
		[Autohook]
		private Animator m_animator;

		[SerializeField]
		private bool m_useFirstFrameHack;

		[SerializeField]
		private bool m_continueAnimationOnEnable;

		[SerializeField]
		private bool m_turnOnAnimatorOnEnable;

		private Vector3 m_startPosition;

		private bool m_animStarted;

		private Action m_animFinishedCallback;

		private UIAnimState m_activeUIAnimState;

		private UIAnimState m_incomingUIAnimState;

		private bool m_activeAnimHasFinished;

		private float m_currentClipTime;

		private bool m_isOverrideFirstPosition;

		private bool m_isRelativePosition;

		private int m_layer;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public List<UIAnimState> GetAnimationList()
		{
			return null;
		}

		public string GetCurrentAnim()
		{
			return null;
		}

		public void AddState(string name)
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

		private void PlayAnimationInternal(UIAnimState state, Action onFinished = null, float startTime = 0f, float crossfade = 0f, int layer = 0)
		{
		}

		private void SetupNewActiveAnimState(UIAnimState state)
		{
		}

		private void Update()
		{
		}

		private bool ShouldUpdateAnimState()
		{
			return false;
		}

		public void PlayAnimation(string animationName, Action onFinished = null, float startTime = 0f, bool checkIsPlayingFirst = false, float crossFade = 0f, int layer = 0)
		{
		}

		private void AnimationFinished()
		{
		}

		public bool HasAnimationStateWithName(string stateName)
		{
			return false;
		}

		private UIAnimState GetAnimStateFromAnimationName(string animationName)
		{
			return null;
		}

		private UIAnimState GetAnimStateFromAnimationNameHash(int animationNameHash)
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		private void UpdateAnimState()
		{
		}

		private void UpdateAnimStarted(AnimatorStateInfo stateInfo)
		{
		}

		private void UpdateAnimFinished(AnimatorStateInfo stateInfo)
		{
		}

		public void SetAnimatorSpeed(float speed)
		{
		}

		public void StopAnimator()
		{
		}
	}
}
