using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageManagerHire", false, false)]
public class PageManagerHire : UIBase
{
	[CompilerGenerated]
	private sealed class _003CShowHire_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageManagerHire _003C_003E4__this;

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
		public _003CShowHire_003Ed__13(int _003C_003E1__state)
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

	[Header("PageManagerHire")]
	[SerializeField]
	private Animator[] CEOs;

	[SerializeField]
	private Transform ManagerT;

	[SerializeField]
	private Image AbilityIcon;

	[SerializeField]
	private Text AbilityDescText;

	[SerializeField]
	private GameObject ManagerSkillObj;

	[SerializeField]
	private ItemManagerSkill ManagerSkillIcon;

	private Animator curCEO;

	private Animator curManager;

	private WaitForSeconds wfs;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	public void Set(int managerIdx)
	{
	}

	[IteratorStateMachine(typeof(_003CShowHire_003Ed__13))]
	private IEnumerator ShowHire()
	{
		return null;
	}
}
