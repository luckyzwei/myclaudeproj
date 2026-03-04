using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialEntityConversation : TutorialEntity
{
	[Serializable]
	private class Conversation
	{
		public Config.AudienceType Type;

		public string Script;

		public bool isShowImg;
	}

	[CompilerGenerated]
	private sealed class _003CStartScript_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntityConversation _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CStartScript_003Ed__5(int _003C_003E1__state)
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
	private TutorialConversation TutoConversation;

	[SerializeField]
	private List<Conversation> Conversations;

	private bool isNext;

	public override void StartEntity()
	{
	}

	[IteratorStateMachine(typeof(_003CStartScript_003Ed__5))]
	public IEnumerator StartScript()
	{
		yield break;
	}

	protected virtual void Update()
	{
	}
}
