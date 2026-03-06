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
		InitializeSlots();
		if (SpinBtn != null)
			SpinBtn.onClick.AddListener(() => StartSpin(-1));
	}

	private void OnDisable()
	{
		StopAllCoroutines();
		IsSpinning = false;
	}

	private void InitializeSlots()
	{
		Slots = new List<ItemSquareRoulette>();
		if (SlotsParent == null) return;
		for (int i = 0; i < SlotsParent.childCount; i++)
		{
			var slot = SlotsParent.GetChild(i).GetComponent<ItemSquareRoulette>();
			if (slot != null)
				Slots.Add(slot);
		}
	}

	public bool StartSpin(int winningIndex)
	{
		if (IsSpinning || Slots == null || Slots.Count == 0)
			return false;

		WinningIndex = winningIndex;
		IsRandomSpin = (winningIndex < 0);
		IsSpinning = true;
		CurrentIndex = 0;
		PreviousWinningIndex = -1;

		for (int i = 0; i < Slots.Count; i++)
		{
			Slots[i].SetHighlight(false);
			Slots[i].SetRewardedFx(false);
		}

		OnRouletteStart?.Invoke();
		StartCoroutine(SpinRoulette());
		return true;
	}

	[IteratorStateMachine(typeof(_003CSpinRoulette_003Ed__28))]
	private IEnumerator SpinRoulette()
	{
		int slotCount = Slots.Count;
		int totalSteps;
		if (IsRandomSpin)
		{
			totalSteps = RandomRotations * slotCount;
			WinningIndex = UnityEngine.Random.Range(0, slotCount);
		}
		else
		{
			totalSteps = MinRotations * slotCount;
		}
		int stepsToWin = ((WinningIndex - CurrentIndex) % slotCount + slotCount) % slotCount;
		totalSteps += stepsToWin;

		float slowdownStart = totalSteps * SlowdownStartPercentage;

		for (int i = 0; i < totalSteps; i++)
		{
			// Unhighlight previous
			if (PreviousWinningIndex >= 0 && PreviousWinningIndex < slotCount)
				Slots[PreviousWinningIndex].SetHighlight(false);

			// Highlight current
			CurrentIndex = i % slotCount;
			Slots[CurrentIndex].SetHighlight(true);
			PreviousWinningIndex = CurrentIndex;

			// Calculate speed
			float speed;
			if (IsRandomSpin)
			{
				speed = RandomSpinSpeed;
			}
			else if (i >= slowdownStart)
			{
				float t = (i - slowdownStart) / (totalSteps - slowdownStart);
				float eased = CalculateEasing(t);
				speed = Mathf.Lerp(FastestSpeed, SlowestSpeed, eased);
			}
			else
			{
				speed = FastestSpeed;
			}

			// Slot highlight sound played by animation/event

			yield return new WaitForSeconds(speed);
		}

		OnSpinComplete();
	}

	private void OnSpinComplete()
	{
		IsSpinning = false;
		if (Slots != null && WinningIndex >= 0 && WinningIndex < Slots.Count)
			Slots[WinningIndex].SetRewardedFx(true);


		OnRouletteComplete?.Invoke(WinningIndex);
	}

	private float CalculateEasing(float t)
	{
		switch (EasingType)
		{
			case EasingType.Linear:
				return t;
			case EasingType.Exponential:
				return t * t * t;
			case EasingType.Quadratic:
				return t * t;
			case EasingType.Cubic:
				return t * t * t;
			case EasingType.SmoothStep:
				return t * t * (3f - 2f * t);
			default:
				return t;
		}
	}
}
