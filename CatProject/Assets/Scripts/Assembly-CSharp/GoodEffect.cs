using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
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
		transform.position = worldStartPos;
		if (iconSprite != null && icon != null)
			icon.sprite = iconSprite;
		if (itemCnt != null)
		{
			string cntText = string.IsNullOrEmpty(viewText) ? goodsCnt.ToString() : viewText;
			itemCnt.text = cntText;
		}
		if (animator != null && !string.IsNullOrEmpty(aniName))
			animator.Play(aniName);
		// Move effect: start -> middle -> end
	}

	public void SetPlayIcon(Vector3 worldStartPos, Vector3 worldMiddlePos, Vector3 worldEndPos, Config.AtlasType atlasType, string Icon, string CountText = "", Action OnEnd = null, float delay = 0f, string Ani = "Show", float firsttime = 0.95f, Vector2 iconSize = default(Vector2))
	{
		transform.position = worldStartPos;
		if (itemCnt != null)
			itemCnt.text = CountText;
		if (animator != null && !string.IsNullOrEmpty(Ani))
			animator.Play(Ani);
	}

	public void SetPackage(Vector3 worldStartPos, Vector3 worldMiddlePos, Vector3 worldEndPos, int packageIdx, Action OnEnd = null, float delay = 0f)
	{
		transform.position = worldStartPos;
		// Set package icon/info from packageIdx
	}

	public void SetCurveMove(Vector3 worldStartPos, Vector3 worldEndPos, int goodsType, int goodsIdx, int goodsRegion, int goodsGrade, Action OnEnd = null, float delay = 0f)
	{
		transform.position = worldStartPos;
		// Curve movement from start to end position
	}

	[IteratorStateMachine(typeof(_003CWaitFrame_003Ed__16))]
	private IEnumerator WaitFrame()
	{
		yield return null;
	}
}
