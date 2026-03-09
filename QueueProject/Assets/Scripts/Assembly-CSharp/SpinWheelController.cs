using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.KWSpinWheel;
using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SpinWheelController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public bool rewardFlowComplete;

		internal void _003CSpinComplete_003Eb__0()
		{
		}

		internal bool _003CSpinComplete_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public bool animating;

		internal void _003CSwapRewardsCoroutine_003Eb__0()
		{
		}

		internal bool _003CSwapRewardsCoroutine_003Eb__1()
		{
			return false;
		}

		internal void _003CSwapRewardsCoroutine_003Eb__2()
		{
		}

		internal bool _003CSwapRewardsCoroutine_003Eb__3()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CSpinComplete_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpinWheelController _003C_003E4__this;

		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		private SpinWheelSegment _003CactiveWheelSegment_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSpinComplete_003Ed__35(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSwapRewardsCoroutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpinWheelController _003C_003E4__this;

		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSwapRewardsCoroutine_003Ed__37(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[FormerlySerializedAs("spinWheelSegmentsController")]
	[FormerlySerializedAs("spinWheelSegmentCreator")]
	[SerializeField]
	private SpinWheelSegmentsController m_spinWheelSegmentsController;

	[FormerlySerializedAs("spinWheelSpinner")]
	[SerializeField]
	private SpinWheelSpinner m_spinWheelSpinner;

	[SerializeField]
	private SpinWheelSpinButton m_spinWheelSpinButton;

	[SerializeField]
	private PopUpBase m_shopPopup;

	[SerializeField]
	private NextSpinTimerWidget m_timerWidget;

	[Header("VFX")]
	[SerializeField]
	private ParticleSystem m_collectionVFX;

	[Header("Interactable Buttons")]
	[SerializeField]
	private Button[] m_progressInteractableButtons;

	[Space(10f)]
	[Header("Timings")]
	[SerializeField]
	private float m_pauseAfterSpin;

	[Header("Reward")]
	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	private PrefabReference m_rewardPopUp;

	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	private PrefabReference m_rewardBoxPopUp;

	private int m_targetSegment;

	private bool m_isSpinning;

	private float m_weight;

	private bool m_isRv;

	private Price m_price;

	private Coroutine m_configWidgetCoroutine;

	private SpinWheelRewards m_currentRewards;

	private ISpinWheelCustomizer m_spinWheelCustomizer;

	public static event GameplayEvents.BasicDelegate SpinStartedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event GameplayEvents.BasicDelegate SpinCompletedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event GameplayEvents.BasicDelegate SpinFlowCompletedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SetupSpinner()
	{
	}

	private void OnDisable()
	{
	}

	private void SetupSpinButton()
	{
	}

	public void TryActivateSpin()
	{
	}

	private void OnPricePaid(bool success)
	{
	}

	private void SpinDetermined()
	{
	}

	[IteratorStateMachine(typeof(_003CSpinComplete_003Ed__35))]
	private IEnumerator SpinComplete()
	{
		return null;
	}

	private void TrySwapRewards()
	{
	}

	[IteratorStateMachine(typeof(_003CSwapRewardsCoroutine_003Ed__37))]
	private IEnumerator SwapRewardsCoroutine()
	{
		return null;
	}

	private void GiveReward(Action rewardFlowComplete, Reward reward)
	{
	}

	private void RewardGiven()
	{
	}

	private void ToggleProgressButtonsInteractable(bool interactable)
	{
	}

	private int GetWeightedRandomIndex()
	{
		return 0;
	}
}
