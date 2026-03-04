using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SquareRouletteComponent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpinRoulette_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SquareRouletteComponent _003C_003E4__this;

		private int _003CtotalSteps_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CSpinRoulette_003Ed__28(int _003C_003E1__state)
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

	[Header("Grid Settings")]
	[SerializeField]
	private int GridWidth;

	[SerializeField]
	private int GridHeight;

	[Header("Animation Settings - Random Spin")]
	[SerializeField]
	private float RandomSpinSpeed;

	[SerializeField]
	private int RandomRotations;

	[Header("Animation Settings - Normal Spin")]
	[SerializeField]
	private float FastestSpeed;

	[SerializeField]
	private float SlowestSpeed;

	[SerializeField]
	private int MinRotations;

	[SerializeField]
	private float SlowdownStartPercentage;

	[SerializeField]
	private EasingType EasingType;

	[Header("References")]
	[SerializeField]
	private Transform SlotsParent;

	[SerializeField]
	private Button SpinBtn;

	[Header("Sound")]
	[SerializeField]
	protected string SlotHighlightSoundName;

	[Header("Sound")]
	[SerializeField]
	protected string CompleteSoundName;

	private List<ItemSquareRoulette> Slots;

	private int CurrentIndex;

	private int WinningIndex;

	private bool IsRandomSpin;

	public Action OnRouletteStart;

	public Action<int> OnRouletteComplete;

	private int PreviousWinningIndex;

	public bool IsSpinning { get; private set; }

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void InitializeSlots()
	{
	}

	public bool StartSpin(int winningIndex)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CSpinRoulette_003Ed__28))]
	private IEnumerator SpinRoulette()
	{
		yield break;
	}

	private void OnSpinComplete()
	{
	}

	private float CalculateEasing(float t)
	{
		return 0f;
	}
}
