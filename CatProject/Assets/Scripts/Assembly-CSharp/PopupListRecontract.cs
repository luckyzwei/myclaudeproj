using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupListRecontract", false, false)]
public class PopupListRecontract : UIBase
{
	[CompilerGenerated]
	private sealed class _003CCheckInput_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupListRecontract _003C_003E4__this;

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
		public _003CCheckInput_003Ed__11(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CFocusOffsetSlot_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupListRecontract _003C_003E4__this;

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
		public _003CFocusOffsetSlot_003Ed__9(int _003C_003E1__state)
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
	private ScrollRect ListScrollRect;

	[SerializeField]
	private GameObject ListSlotPrefab;

	private List<ItemOfficeCompanyInfo> ItemOfficeCompanyInfoList;

	private ItemOfficeCompanyInfo FocusOfficeSlot;

	private Coroutine InputCheckCoroutine;

	protected override void Awake()
	{
		base.Awake();
		ItemOfficeCompanyInfoList = new List<ItemOfficeCompanyInfo>();
		if (ListScrollRect != null) ListScrollRect.onValueChanged.AddListener(OnScrolled);
	}

	private void OnDestroy()
	{
		if (InputCheckCoroutine != null) { StopCoroutine(InputCheckCoroutine); InputCheckCoroutine = null; }
	}

	private void OnDisable()
	{
		if (InputCheckCoroutine != null) { StopCoroutine(InputCheckCoroutine); InputCheckCoroutine = null; }
	}

	public void Init(int focusOfficeIdx)
	{
		if (ItemOfficeCompanyInfoList == null) ItemOfficeCompanyInfoList = new List<ItemOfficeCompanyInfo>();
		ItemOfficeCompanyInfoList.Clear();
		FocusOfficeSlot = null;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		StartCoroutine(FocusOffsetSlot());
		InputCheckCoroutine = StartCoroutine(CheckInput());
	}

	[IteratorStateMachine(typeof(_003CFocusOffsetSlot_003Ed__9))]
	private IEnumerator FocusOffsetSlot()
	{
		yield return null;
		if (FocusOfficeSlot != null && ListScrollRect != null)
		{
			// Normalize scroll position to focus item
		}
	}

	private void OnScrolled(Vector2 value)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckInput_003Ed__11))]
	private IEnumerator CheckInput()
	{
		while (true)
		{
			yield return null;
			// Check for user input to close popup
		}
	}
}
