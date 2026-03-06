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
		public _003CShowHire_003Ed__13(int _003C_003E1__state)
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
					// Show CEO enter animation
					if (_003C_003E4__this.curCEO != null)
						_003C_003E4__this.curCEO.gameObject.SetActive(true);
					_003C_003E2__current = _003C_003E4__this.wfs;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					// Show manager enter
					if (_003C_003E4__this.curManager != null)
						_003C_003E4__this.curManager.gameObject.SetActive(true);
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
		base.Awake();
		wfs = new WaitForSeconds(0.5f);
	}

	public override void OnShowBefore()
	{
		if (CEOs != null)
		{
			for (int i = 0; i < CEOs.Length; i++)
			{
				if (CEOs[i] != null)
					CEOs[i].gameObject.SetActive(false);
			}
		}
	}

	public override void OnHideAfter()
	{
		if (curCEO != null)
		{
			curCEO.gameObject.SetActive(false);
			curCEO = null;
		}
		if (curManager != null)
		{
			curManager.gameObject.SetActive(false);
			curManager = null;
		}
	}

	public void Set(int managerIdx)
	{
		if (CEOs != null && managerIdx >= 0 && managerIdx < CEOs.Length)
			curCEO = CEOs[managerIdx];

		if (ManagerSkillObj != null) ManagerSkillObj.SetActive(false);
		if (AbilityDescText != null) AbilityDescText.text = "";

		StartCoroutine(ShowHire());
	}

	[IteratorStateMachine(typeof(_003CShowHire_003Ed__13))]
	private IEnumerator ShowHire()
	{
		var routine = new _003CShowHire_003Ed__13(0);
		routine._003C_003E4__this = this;
		return routine;
	}
}
