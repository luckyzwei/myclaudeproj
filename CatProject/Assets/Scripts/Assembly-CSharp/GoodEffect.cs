using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GoodEffect : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitFrame_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoodEffect _003C_003E4__this;

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
		public _003CWaitFrame_003Ed__16(int _003C_003E1__state)
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
	private Image icon;

	[SerializeField]
	private Image Bg;

	[SerializeField]
	private Image Frame;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private float firstMoveTime;

	[SerializeField]
	private float secondMoveTime;

	[SerializeField]
	private float firstEffectTime;

	[SerializeField]
	private Vector3 iconIdleScale;

	[SerializeField]
	private Text itemCnt;

	[SerializeField]
	private GameObject hitEffect;

	[SerializeField]
	private Text titleText;

	[SerializeField]
	private GameObject ClothEffect;

	public void Set(Vector3 worldStartPos, Vector3 worldMiddlePos, Vector3 worldEndPos, int goodsType, int goodsIdx, int goodsRegion, BigInteger goodsCnt, Action OnEnd = null, float delay = 0f, string viewText = "", string aniName = "Show", Sprite iconSprite = null)
	{
	}

	public void SetPlayIcon(Vector3 worldStartPos, Vector3 worldMiddlePos, Vector3 worldEndPos, Config.AtlasType atlasType, string Icon, string CountText = "", Action OnEnd = null, float delay = 0f, string Ani = "Show", float firsttime = 0.95f, Vector2 iconSize = default(Vector2))
	{
	}

	public void SetPackage(Vector3 worldStartPos, Vector3 worldMiddlePos, Vector3 worldEndPos, int packageIdx, Action OnEnd = null, float delay = 0f)
	{
	}

	public void SetCurveMove(Vector3 worldStartPos, Vector3 worldEndPos, int goodsType, int goodsIdx, int goodsRegion, int goodsGrade, Action OnEnd = null, float delay = 0f)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitFrame_003Ed__16))]
	private IEnumerator WaitFrame()
	{
		return null;
	}
}
