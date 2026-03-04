using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PageConversation", false, false)]
public class PageConversation : UIBase
{
	[Serializable]
	private class ConversationInfo
	{
		public Config.AudienceType Type;

		public string Script;
	}

	[CompilerGenerated]
	private sealed class _003CStartConversation_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageConversation _003C_003E4__this;

		private List<ConversationInfo>.Enumerator _003C_003E7__wrap1;

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
		public _003CStartConversation_003Ed__10(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private TutorialConversation Conversation;

	[SerializeField]
	private Button NextBtn;

	private List<ConversationInfo> Conversations;

	private int CurStep;

	private Color DimColor;

	private bool ClickNext;

	protected override void Awake()
	{
	}

	public void SetSecretaryConversation(Config.SecretaryConversationType type, int target)
	{
	}

	public void SetBuildingConversation(int type, int building, bool showdim = false)
	{
	}

	[IteratorStateMachine(typeof(_003CStartConversation_003Ed__10))]
	private IEnumerator StartConversation()
	{
		yield break;
	}

	private void OnClickNext()
	{
	}
}
