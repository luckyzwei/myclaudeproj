using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/LoadingBasic", false, false)]
public class LoadingBasic : Loading
{
	[Serializable]
	private class SpecialTheme
	{
		public int SpecialDayIdx;

		public List<GameObject> DecoObjs;
	}

	[CompilerGenerated]
	private sealed class _003CWaitStageLoad_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingBasic _003C_003E4__this;

		public Action action;

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
		public _003CWaitStageLoad_003Ed__31(int _003C_003E1__state)
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
	private List<GameObject> RandObj;

	[SerializeField]
	private GameObject immersiveADRect;

	[SerializeField]
	private Text loadingBarText;

	[SerializeField]
	private Slider loadingBar;

	[SerializeField]
	private GameObject loadingBarRoot;

	[SerializeField]
	private Button TapBtn;

	[SerializeField]
	private GameObject charRoot;

	[SerializeField]
	private GameObject ADRoot;

	[Header("[SpecialDay Theme]")]
	[SerializeField]
	protected Image TileImg;

	[SerializeField]
	protected Image TileBgImg;

	[SerializeField]
	private List<SpecialTheme> SpecialDayDecoList;

	private Sprite originTile;

	private Color originTileBgColor;

	private float loadingStartTime;

	private bool StageLoadComplete;

	private bool AdLoad;

	private int gamestart_loading_time;

	private static bool bWaitAd;

	public bool ADState { get; private set; }

	protected override void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected override void Awake()
	{
	}

	private void OnClickTap()
	{
	}

	protected override void Update()
	{
	}

	public override void Hide()
	{
	}

	public override void Hide(bool Immediately = true, Action action = null)
	{
	}

	public void WaitStageLoadHide()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitStageLoad_003Ed__31))]
	private IEnumerator WaitStageLoad(Action action)
	{
		return null;
	}

	private bool CheckShowLoadingAds()
	{
		return false;
	}

	private void InitTheme()
	{
	}

	public void UpdateSpecialTheme()
	{
	}

	private void SetDefaultTheme()
	{
	}
}
