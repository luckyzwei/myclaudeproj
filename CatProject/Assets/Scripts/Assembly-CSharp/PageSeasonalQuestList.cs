using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageSeasonalQuestList", false, false)]
public class PageSeasonalQuestList : FullScreenUI
{
	[CompilerGenerated]
	private sealed class _003CFocusActiveItem_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageSeasonalQuestList _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CFocusActiveItem_003Ed__9(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					// Focus scroll to active quest item
					if (_003C_003E4__this.ItemScrollRect != null)
						_003C_003E4__this.ItemScrollRect.verticalNormalizedPosition = 1f;
					return false;
				default:
					return false;
			}
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
	private ScrollRect ItemScrollRect;

	[SerializeField]
	private List<itemSeasonalQuest> listItem;

	[SerializeField]
	private Button btnMove;

	[SerializeField]
	private Button btnInfo;

	[SerializeField]
	private Text textSeasonalPoint;

	[SerializeField]
	private Transform LastComp;

	protected override void Awake()
	{
		base.Awake();
		if (btnMove != null) btnMove.onClick.AddListener(OnClickMove);
		if (btnInfo != null) btnInfo.onClick.AddListener(OnClickInfo);
	}

	public override void OnShowBefore()
	{
		Set();
		StartCoroutine(FocusActiveItem());
	}

	private void Set()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;

		if (textSeasonalPoint != null) textSeasonalPoint.text = "0";

		// Update quest list items
		if (listItem != null)
		{
			for (int i = 0; i < listItem.Count; i++)
			{
				if (listItem[i] != null)
					listItem[i].gameObject.SetActive(true);
			}
		}
	}

	[IteratorStateMachine(typeof(_003CFocusActiveItem_003Ed__9))]
	private IEnumerator FocusActiveItem()
	{
		var routine = new _003CFocusActiveItem_003Ed__9(0);
		routine._003C_003E4__this = this;
		return routine;
	}

	private void OnClickMove()
	{
		Hide();
	}

	private void OnClickInfo()
	{
		// Show seasonal quest info popup
	}
}
