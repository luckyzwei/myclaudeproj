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
		PointCount = pointCount;
		RevenueGraphValues = revenueGraphValues;
		XStep = BoxSize.x / Mathf.Max(1, pointCount - 1);
		OriginPoints = new List<Vector2>();
		PrevPoints = new List<Vector2>();
		CurrentPoints = new List<Vector2>();
		CalcOriginPoints();
		UpdateLineGraph();
		if (RevenueGraphValues != null && RevenueGraphValues.Count > 0)
			UpdateDotPoint(CurrentPoints[CurrentPoints.Count - 1]);
	}

	public void UpdateGraph(List<BigInteger> revenueGraphValues, bool isShift)
	{
		RevenueGraphValues = revenueGraphValues;
		if (PrevPoints != null)
		{
			PrevPoints.Clear();
			PrevPoints.AddRange(CurrentPoints);
		}
		CalcOriginPoints();
		StartCoroutine(AnimateGraph());
	}

	private void CalcOriginPoints()
	{
		if (RevenueGraphValues == null || RevenueGraphValues.Count == 0) return;
		BigInteger maxValue = BigInteger.Zero;
		for (int i = 0; i < RevenueGraphValues.Count; i++)
		{
			if (RevenueGraphValues[i] > maxValue)
				maxValue = RevenueGraphValues[i];
		}
		CurrentPoints.Clear();
		for (int i = 0; i < RevenueGraphValues.Count && i < PointCount; i++)
		{
			float x = i * XStep;
			float y = maxValue > BigInteger.Zero ? (float)PreciseDivide(RevenueGraphValues[i], maxValue) * BoxSize.y : 0f;
			CurrentPoints.Add(new Vector2(x, y));
		}
	}

	[IteratorStateMachine(typeof(_003CAnimateGraph_003Ed__16))]
	private IEnumerator AnimateGraph()
	{
		if (PrevPoints == null || PrevPoints.Count == 0 || AnimDuration <= 0f)
		{
			UpdateLineGraph();
			yield break;
		}
		float elapsedTime = 0f;
		var interpPoints = new List<Vector2>();
		while (elapsedTime < AnimDuration)
		{
			elapsedTime += Time.deltaTime;
			float t = Mathf.Clamp01(elapsedTime / AnimDuration);
			interpPoints.Clear();
			int count = Mathf.Min(PrevPoints.Count, CurrentPoints.Count);
			for (int i = 0; i < count; i++)
				interpPoints.Add(Vector2.Lerp(PrevPoints[i], CurrentPoints[i], t));
			if (LineGraph != null)
				LineGraph.SetPoints(interpPoints);
			if (interpPoints.Count > 0)
				UpdateDotPoint(interpPoints[interpPoints.Count - 1]);
			yield return null;
		}
		UpdateLineGraph();
	}

	private void UpdateLineGraph()
	{
		if (LineGraph != null && CurrentPoints != null)
			LineGraph.SetPoints(CurrentPoints);
		if (CurrentPoints != null && CurrentPoints.Count > 0)
			UpdateDotPoint(CurrentPoints[CurrentPoints.Count - 1]);
	}

	private void UpdateDotPoint(Vector2 point)
	{
		if (DotObjectTr != null)
			DotObjectTr.anchoredPosition = point;
		if (CurValueTextTr != null)
			CurValueTextTr.anchoredPosition = point + Vector2.up * 30f;
	}

	private double PreciseDivide(BigInteger numerator, BigInteger denominator)
	{
		if (denominator == BigInteger.Zero) return 0.0;
		BigInteger scaled = numerator * 1000000 / denominator;
		return (double)scaled / 1000000.0;
	}
}
