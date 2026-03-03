using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageCompanyLevelUp", false, false)]
public class PageCompanyLevelUp : UIBase
{
	[CompilerGenerated]
	private sealed class _003CPlayLevelUpSequence_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageCompanyLevelUp _003C_003E4__this;

		private int _003CcompanyLevel_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CPlayLevelUpSequence_003Ed__19(int _003C_003E1__state)
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

	[Header("PageCompanyLevelUp")]
	[SerializeField]
	private Image CompanyIcon;

	[SerializeField]
	private Text CompanyName;

	[SerializeField]
	private List<Image> LevelObjs;

	[SerializeField]
	private List<GameObject> LevelOnObjs;

	[SerializeField]
	private Text RewardLevel;

	[SerializeField]
	private Text BeforeRentalFee;

	[SerializeField]
	private Text NewRentalFee;

	[Space(5f)]
	[SerializeField]
	private Text CloseText;

	[SerializeField]
	private Text HudLevelText;

	[Space(5f)]
	[SerializeField]
	private DoTweenScriptComponent beforeTween;

	[SerializeField]
	private DoTweenScriptComponent afterTween;

	private Vector3 beforeOriginLocalPos;

	private Vector3 afterOriginLocalPos;

	private int CompanyIdx;

	private int PrevLv;

	protected override void Awake()
	{
	}

	public void Set(int company, int prevPlayerLv, int prevLvCompLv)
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnShowAfter()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayLevelUpSequence_003Ed__19))]
	private IEnumerator PlayLevelUpSequence()
	{
		return null;
	}

	public Vector3 GetLevelPos()
	{
		return default(Vector3);
	}
}
