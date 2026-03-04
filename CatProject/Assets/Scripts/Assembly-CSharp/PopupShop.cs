using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/Shop", false, false)]
public class PopupShop : HUDAniBase
{
	[CompilerGenerated]
	private sealed class _003CWaitOneFrame_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupShop _003C_003E4__this;

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
		public _003CWaitOneFrame_003Ed__21(int _003C_003E1__state)
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
	private List<Toggle> shopToggles;

	[SerializeField]
	private List<IShopContents> shopContents;

	[SerializeField]
	private List<IShopContents> eventShopContents;

	[SerializeField]
	private Image BottomImage;

	private ShopTab defualtOption;

	private bool init;

	private bool IsSelctTab;

	private int Sufficient;

	public ShopTab CurrentTab { get; private set; }

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void SetDefaultOpenTab(ShopTab defaultTab, int _Sufficent = -1)
	{
	}

	public void ForceTab(ShopTab tab)
	{
	}

	public void ChangeTab(ShopTab tab, bool on, bool selecttab = false)
	{
	}

	public void RefreshCurrentTab()
	{
	}

	public void ReOpenCloseBtn()
	{
	}

	public override void OnShowBefore()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitOneFrame_003Ed__21))]
	private IEnumerator WaitOneFrame()
	{
		yield break;
	}

	public IShopContents GetContents(ShopTab shopidx)
	{
		return null;
	}

	public Vector3 GetUICardPos()
	{
		return default(Vector3);
	}
}
