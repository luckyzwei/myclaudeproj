using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ItemBoosterGraph : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateGraph_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemBoosterGraph _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

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
		public _003CAnimateGraph_003Ed__16(int _003C_003E1__state)
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

	[SerializeField]
	private LineRenderer LineGraph;

	[SerializeField]
	private RectTransform DotObjectTr;

	[SerializeField]
	private RectTransform CurValueTextTr;

	[SerializeField]
	private RollingCountTextComponent CurValueText;

	[SerializeField]
	private float AnimDuration;

	[SerializeField]
	private Vector2 BoxSize;

	private int PointCount;

	private float XStep;

	private float YStep;

	private List<Vector2> OriginPoints;

	private List<Vector2> PrevPoints;

	private List<Vector2> CurrentPoints;

	private List<BigInteger> RevenueGraphValues;

	public void SetGraph(int pointCount, List<BigInteger> revenueGraphValues)
	{
	}

	public void UpdateGraph(List<BigInteger> revenueGraphValues, bool isShift)
	{
	}

	private void CalcOriginPoints()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateGraph_003Ed__16))]
	private IEnumerator AnimateGraph()
	{
		yield break;
	}

	private void UpdateLineGraph()
	{
	}

	private void UpdateDotPoint(Vector2 point)
	{
	}

	private double PreciseDivide(BigInteger numerator, BigInteger denominator)
	{
		return 0.0;
	}
}
