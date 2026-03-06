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
		base.Awake();
		init = false;
		IsSelctTab = false;
		defualtOption = ShopTab.package;

		if (shopToggles != null)
		{
			for (int i = 0; i < shopToggles.Count; i++)
			{
				int idx = i;
				if (shopToggles[i] != null)
					shopToggles[i].onValueChanged.AddListener((on) => ChangeTab((ShopTab)idx, on, true));
			}
		}
	}

	public override void Show()
	{
		base.Show();
	}

	public override void Hide()
	{
		base.Hide();
	}

	public void SetDefaultOpenTab(ShopTab defaultTab, int _Sufficent = -1)
	{
		defualtOption = defaultTab;
		Sufficient = _Sufficent;
	}

	public void ForceTab(ShopTab tab)
	{
		ChangeTab(tab, true, false);
	}

	public void ChangeTab(ShopTab tab, bool on, bool selecttab = false)
	{
		if (!on) return;
		IsSelctTab = selecttab;
		CurrentTab = tab;

		// Deactivate all contents
		if (shopContents != null)
		{
			for (int i = 0; i < shopContents.Count; i++)
				if (shopContents[i] != null) shopContents[i].gameObject.SetActive(false);
		}

		// Activate selected tab content
		var contents = GetContents(tab);
		if (contents != null)
		{
			contents.gameObject.SetActive(true);
			contents.Init();
		}
	}

	public void RefreshCurrentTab()
	{
		var contents = GetContents(CurrentTab);
		if (contents != null)
			contents.Init();
	}

	public void ReOpenCloseBtn()
	{
		// Re-enable close button after purchase flow
	}

	public override void OnShowBefore()
	{
		if (!init)
		{
			init = true;
		}
		StartCoroutine(WaitOneFrame());
	}

	[IteratorStateMachine(typeof(_003CWaitOneFrame_003Ed__21))]
	private IEnumerator WaitOneFrame()
	{
		yield return null;
		ForceTab(defualtOption);
	}

	public IShopContents GetContents(ShopTab shopidx)
	{
		int idx = (int)shopidx;
		if (shopContents != null && idx >= 0 && idx < shopContents.Count)
			return shopContents[idx];
		return null;
	}

	public Vector3 GetUICardPos()
	{
		return default(Vector3);
	}
}
