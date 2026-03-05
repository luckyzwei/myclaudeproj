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
			get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CStartScript_003Ed__5(int _003C_003E1__state)
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
					if (_003C_003E4__this.Conversations == null || _003C_003E4__this.Conversations.Count == 0)
					{
						_003C_003E4__this.Done();
						return false;
					}
					_003Ci_003E5__2 = 0;
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					if (_003Ci_003E5__2 < _003C_003E4__this.Conversations.Count)
					{
						var conv = _003C_003E4__this.Conversations[_003Ci_003E5__2];
						if (_003C_003E4__this.TutoConversation != null && conv != null)
						{
							_003C_003E4__this.TutoConversation.Set(conv.Type, conv.Script, conv.isShowImg);
						}
						_003C_003E4__this.isNext = false;
						goto case 2;
					}
					_003C_003E4__this.Done();
					return false;
				case 2:
					_003C_003E1__state = -1;
					if (!_003C_003E4__this.isNext)
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 2;
						return true;
					}
					_003Ci_003E5__2++;
					goto case 1;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
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
		base.StartEntity();
		isNext = false;
		StartCoroutine(StartScript());
	}

	[IteratorStateMachine(typeof(_003CStartScript_003Ed__5))]
	public IEnumerator StartScript()
	{
		var d = new _003CStartScript_003Ed__5(0);
		d._003C_003E4__this = this;
		return d;
	}

	protected virtual void Update()
	{
		// Check for tap/click to advance conversation
		if (Input.GetMouseButtonDown(0))
		{
			isNext = true;
		}
	}
}
