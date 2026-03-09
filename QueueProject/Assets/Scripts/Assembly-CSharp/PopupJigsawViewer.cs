using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupJigsawViewer : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public bool puzzleRevealed;

		public bool jigsawCompleteAnimFinished;

		internal void _003CRevealFlow_003Eb__0()
		{
		}

		internal bool _003CRevealFlow_003Eb__1()
		{
			return false;
		}

		internal void _003CRevealFlow_003Eb__2()
		{
		}

		internal bool _003CRevealFlow_003Eb__3()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRevealFlow_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupJigsawViewer _003C_003E4__this;

		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

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
		public _003CRevealFlow_003Ed__22(int _003C_003E1__state)
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

	private const string ANIM_ANIM_JIGSAWVIEWER_INTRO = "Anim-JigsawViewer-Intro";

	private const string ANIM_ANIM_JIGSAWVIEWER_OUTRO = "Anim-JigsawViewer-Outro";

	private const string ANIM_ANIM_JIGSAWVIEWER_JIGSAWCOMPLETE = "Anim-JigsawViewer-JigsawComplete";

	private const string ANIM_ANIM_JIGSAWVIEWER_JIGSAWANIMATION = "Anim-JigsawViewer-JigsawAnimation";

	public const string PREFAB_NAME = "Prefabs/Popups/Popup-JigsawViewer";

	public const string PREFAB_NAME_PAST_EVENT = "Prefabs/Popups/Popup-JigsawViewerPastEvent";

	public const float REWARD_FLOW_DELAY = 0.5f;

	public const float CLOSE_BUTTONS_DELAY = 0.5f;

	[SerializeField]
	private JigsawPuzzleCompletedCell m_jigsawPuzzleCell;

	[SerializeField]
	private AnimatorHelper m_animator;

	[SerializeField]
	private GameObject m_closeButton;

	[SerializeField]
	private Button m_closeBackgroundButton;

	[SerializeField]
	private TextMeshProUGUI m_puzzleText;

	[SerializeField]
	private Button m_jigsawFinishNowButton;

	[SerializeField]
	private QueensRewardWidget m_queensRewardWidget;

	[SerializeField]
	private GameObject m_rvGroup;

	private string m_clientID;

	private bool m_isCompleteFlow;

	private JigsawPuzzleCell m_jigsawCell;

	private bool m_analyticsSent;

	public void Config(string clientId, bool completeFlow, bool isCompleted, JigsawPuzzleCell jigsawPuzzleCell = null)
	{
	}

	private void OnAnimIntroComplete()
	{
	}

	[IteratorStateMachine(typeof(_003CRevealFlow_003Ed__22))]
	private IEnumerator RevealFlow()
	{
		return null;
	}

	private void ShowRewardFlow()
	{
	}

	private void CheckNextFlow()
	{
	}

	private void OnRewardGiven()
	{
	}

	private void EnableCloseButtons()
	{
	}

	private void ShowJigsawRv()
	{
	}

	private void CompleteJigsaw()
	{
	}
}
