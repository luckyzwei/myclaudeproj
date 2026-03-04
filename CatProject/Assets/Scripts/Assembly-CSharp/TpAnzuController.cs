using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using anzu;

public class TpAnzuController : MonoBehaviour
{
	public enum AnzuRatioTag
	{
		Ratio_0_65 = 0,
		Ratio_1_33 = 1,
		Ratio_1_55 = 2,
		Ratio_1_78 = 3,
		S2F = 4
	}

	public enum AuzuUITag
	{
		Loading = 0,
		MiniGame = 1
	}

	[CompilerGenerated]
	private sealed class _003CRestoreColorAfterDelay_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TpAnzuController _003C_003E4__this;

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
		public _003CRestoreColorAfterDelay_003Ed__24(int _003C_003E1__state)
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
	private int adIdx;

	[SerializeField]
	private AnzuRatioTag ratioTag;

	[SerializeField]
	private bool isAllowsImages;

	[SerializeField]
	private bool isAllowsVideos;

	[SerializeField]
	private bool isWorldMap;

	[SerializeField]
	private bool isUI;

	[SerializeField]
	private AuzuUITag uiTag;

	[Header("노애즈로 지워질때 대안으로 켜줄 오브젝트")]
	[SerializeField]
	private List<GameObject> alternativeObj;

	[Header("노애즈로 지워질때 같이 지워질 오브젝트")]
	[SerializeField]
	private List<GameObject> alternativeDesroyObj;

	[SerializeField]
	private AnzuStats anzuStats;

	[SerializeField]
	private AnzuAd anzuAd;

	[Header("s2f 대응")]
	[SerializeField]
	private Transform screenObject;

	[Header("시각적 피드백")]
	[SerializeField]
	private SpriteRenderer _SpriteRenderer;

	[SerializeField]
	private Color _clickableColor;

	[SerializeField]
	private Color _nonClickableColor;

	[SerializeField]
	private Color _clickFeedbackColor;

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void ToggleActive()
	{
	}

	private void OnPlaybackstarted()
	{
	}

	private void UpdateClickabilityVisual()
	{
	}

	public void OnClick()
	{
	}

	[IteratorStateMachine(typeof(_003CRestoreColorAfterDelay_003Ed__24))]
	private IEnumerator RestoreColorAfterDelay()
	{
		yield break;
	}
}
