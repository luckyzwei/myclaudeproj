using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "JigsawPieceTweenData", menuName = "Kwalee/KWRewards/JigsawPieceTweenData", order = 1)]
public class JigsawPieceTweenData : CurrencyExplosionTweenData
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public JigsawPieceTweenData _003C_003E4__this;

		public Transform target;

		public int i;

		public float pitch;

		public Action firstElementReached;

		public List<CurrencyExplosionCell> currencyExplosionCells;

		public Action onComplete;
	}

	[CompilerGenerated]
	private sealed class _003CMoveFragments_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JigsawPieceTweenData _003C_003E4__this;

		public Transform target;

		public Action firstElementReached;

		public List<CurrencyExplosionCell> currencyExplosionCells;

		public Action onComplete;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		private List<CurrencyExplosionCell>.Enumerator _003C_003E7__wrap1;

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
		public _003CMoveFragments_003Ed__14(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static float s_lastSfxTime;

	[Header("Movement")]
	[SerializeField]
	private float m_timeToReach;

	[SerializeField]
	private float m_timeBetween;

	[SerializeField]
	private Vector3 m_midPositionOffset;

	[SerializeField]
	private Vector3 m_finalScale;

	[SerializeField]
	private float m_initialScaleUpTime;

	[SerializeField]
	private AnimationCurve m_xPositionCurve;

	[SerializeField]
	private AnimationCurve m_yPositionCurve;

	[SerializeField]
	private AnimationCurve m_scaleCurve;

	[SerializeField]
	private float m_moveDelay;

	[SerializeField]
	private float m_rotation;

	public float TimeToReach => 0f;

	public override void PlayExplosionTween(Transform parent, Sprite sprite, int numToSpawn, Vector3 start, Transform target, Action firstElementReached, Action finished, string clientID = "default")
	{
	}

	[IteratorStateMachine(typeof(_003CMoveFragments_003Ed__14))]
	protected IEnumerator MoveFragments(List<CurrencyExplosionCell> currencyExplosionCells, Transform target, Action firstElementReached, Action onComplete)
	{
		return null;
	}
}
