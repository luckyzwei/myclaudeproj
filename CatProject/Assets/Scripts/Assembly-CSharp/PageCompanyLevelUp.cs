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
		public _003CPlayLevelUpSequence_003Ed__19(int _003C_003E1__state)
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
					_003CcompanyLevel_003E5__2 = _003C_003E4__this.PrevLv;
					if (_003C_003E4__this.LevelOnObjs == null) return false;
					_003Ci_003E5__3 = 0;
					goto case 2;
				case 1:
					_003C_003E1__state = -1;
					_003Ci_003E5__3++;
					goto case 2;
				case 2:
					if (_003Ci_003E5__3 < _003C_003E4__this.LevelOnObjs.Count)
					{
						if (_003C_003E4__this.LevelOnObjs[_003Ci_003E5__3] != null)
							_003C_003E4__this.LevelOnObjs[_003Ci_003E5__3].SetActive(_003Ci_003E5__3 <= _003CcompanyLevel_003E5__2);
						_003C_003E2__current = new WaitForSeconds(0.3f);
						_003C_003E1__state = 1;
						return true;
					}
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
		base.Awake();
		if (beforeTween != null) beforeOriginLocalPos = beforeTween.transform.localPosition;
		if (afterTween != null) afterOriginLocalPos = afterTween.transform.localPosition;
	}

	public void Set(int company, int prevPlayerLv, int prevLvCompLv)
	{
		CompanyIdx = company;
		PrevLv = prevLvCompLv;
		if (RewardLevel != null) RewardLevel.text = prevPlayerLv.ToString();
	}

	public override void OnShowBefore()
	{
		if (beforeTween != null) beforeTween.transform.localPosition = beforeOriginLocalPos;
		if (afterTween != null) afterTween.transform.localPosition = afterOriginLocalPos;

		if (LevelOnObjs != null)
		{
			for (int i = 0; i < LevelOnObjs.Count; i++)
			{
				if (LevelOnObjs[i] != null)
					LevelOnObjs[i].SetActive(i < PrevLv);
			}
		}
	}

	public override void OnShowAfter()
	{
		StartCoroutine(PlayLevelUpSequence());
	}

	[IteratorStateMachine(typeof(_003CPlayLevelUpSequence_003Ed__19))]
	private IEnumerator PlayLevelUpSequence()
	{
		var routine = new _003CPlayLevelUpSequence_003Ed__19(0);
		routine._003C_003E4__this = this;
		return routine;
	}

	public Vector3 GetLevelPos()
	{
		if (HudLevelText != null) return HudLevelText.transform.position;
		return transform.position;
	}
}
