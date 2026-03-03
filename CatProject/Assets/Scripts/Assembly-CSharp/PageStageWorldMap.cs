using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TextOutline;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageStageWorldMap", false, false)]
public class PageStageWorldMap : UIBase
{
	[Serializable]
	private struct Reward
	{
		public GameObject Root;

		public Image Icon;

		public Text Count;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public PageStageWorldMap _003C_003E4__this;

		public ItemStageWorldSpot nextSpot;

		internal void _003CStartClearEffect_003Eb__0(PageWhite ui)
		{
		}

		internal bool _003CStartClearEffect_003Eb__1()
		{
			return false;
		}

		internal bool _003CStartClearEffect_003Eb__2()
		{
			return false;
		}

		internal void _003CStartClearEffect_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartChapterClear_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageStageWorldMap _003C_003E4__this;

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
		public _003CStartChapterClear_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CStartClearEffect_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageStageWorldMap _003C_003E4__this;

		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		private int _003Cstage_003E5__2;

		private ItemStageWorldSpot _003CcurSpot_003E5__3;

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
		public _003CStartClearEffect_003Ed__35(int _003C_003E1__state)
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
	private GameObject rewardGemParticle;

	[SerializeField]
	private CanvasGroup rewardUICg;

	[SerializeField]
	private CircleOutline rewardOutline;

	[SerializeField]
	private Image FadeWhite;

	[SerializeField]
	private Animator WorldAni;

	[Header("common")]
	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private Text regionText;

	[SerializeField]
	private Button EnterBtn;

	[SerializeField]
	private Button BackGroundBtn;

	[SerializeField]
	private GameObject EnterUI;

	[SerializeField]
	private Button PrevBtn;

	[SerializeField]
	private Button NextBtn;

	[Header("NextChapter")]
	[SerializeField]
	private Image NextChapterIcon;

	[SerializeField]
	private Text NextChapterDesc;

	[SerializeField]
	private GameObject ChapterRewardRoot;

	[SerializeField]
	private List<Reward> ChapterClearReward;

	private int targetStage;

	private float focusValue;

	private PageWhite white;

	private ItemStageChapter PrevChapter;

	private ItemStageChapter CurChapter;

	private ItemStageChapter NextChapter;

	private Action ClearStatusAction;

	private bool isClear;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnShowAfter()
	{
	}

	private void SetClearStatus()
	{
	}

	private void LoadChapterItem(int chapter, Action loadComp = null)
	{
	}

	private void UpdateCurChapter(int chapter)
	{
	}

	private void SetFocus()
	{
	}

	public void SetClearMode(bool value)
	{
	}

	public void ChangeNextChapter()
	{
	}

	[IteratorStateMachine(typeof(_003CStartChapterClear_003Ed__34))]
	private IEnumerator StartChapterClear()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartClearEffect_003Ed__35))]
	private IEnumerator StartClearEffect()
	{
		return null;
	}

	public Image GetFadeWhite()
	{
		return null;
	}

	public PageWhite GetPageWhite()
	{
		return null;
	}

	private void OnScrollValueChange(Vector2 delta)
	{
	}

	private void UpdateChapterBtn()
	{
	}

	public override void Hide()
	{
	}

	private void OnClickPrevChapter()
	{
	}

	private void OnClickNextChapter()
	{
	}

	private void OnClickStageEnter()
	{
	}

	private void OnClickStageSpot(int stage, Transform trans)
	{
	}

	private void OnClickEmpty()
	{
	}

	private void Unload()
	{
	}
}
