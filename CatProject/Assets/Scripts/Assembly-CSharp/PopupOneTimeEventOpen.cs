using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupOneTimeEventOpen", false, false)]
public class PopupOneTimeEventOpen : UIBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public HUDTotal hud;

		internal void _003CShowOneTimeHUDEffect_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CShowOneTimeHUDEffect_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		public PopupOneTimeEventOpen _003C_003E4__this;

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
		public _003CShowOneTimeHUDEffect_003Ed__20(int _003C_003E1__state)
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

	[Header("[PopupOneTimeEventOpen]")]
	[SerializeField]
	private Image titleImage;

	[SerializeField]
	private Image specialRewardImage;

	[Space(5f)]
	[SerializeField]
	private Text titleText;

	[SerializeField]
	private Text subTitleText;

	[SerializeField]
	private Text descText;

	[SerializeField]
	private Text remainTimeText;

	[Space(5f)]
	[SerializeField]
	private Button moveBtn;

	[Header("SpecialDay Theme")]
	[SerializeField]
	private Image TileImg;

	[SerializeField]
	private Image TileBgImg;

	private Sprite originTile;

	private Color originTileBgColor;

	private CompositeDisposable disposables;

	public Coroutine CurProcess { get; private set; }

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void SetOneTimeEvent()
	{
	}

	private void RunHUDEffect()
	{
	}

	[IteratorStateMachine(typeof(_003CShowOneTimeHUDEffect_003Ed__20))]
	private IEnumerator ShowOneTimeHUDEffect()
	{
		yield break;
	}

	public void KillProcess()
	{
	}

	private void UpdateSpecialTheme()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
