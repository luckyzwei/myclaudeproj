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
		public _003CFocusActiveItem_003Ed__9(int _003C_003E1__state)
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
	}

	public override void OnShowBefore()
	{
	}

	private void Set()
	{
	}

	[IteratorStateMachine(typeof(_003CFocusActiveItem_003Ed__9))]
	private IEnumerator FocusActiveItem()
	{
		return null;
	}

	private void OnClickMove()
	{
	}

	private void OnClickInfo()
	{
	}
}
