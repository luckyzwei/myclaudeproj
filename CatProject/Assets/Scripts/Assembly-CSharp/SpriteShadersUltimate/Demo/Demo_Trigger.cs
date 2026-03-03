using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpriteShadersUltimate.Demo
{
	public class Demo_Trigger : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPlayEvent_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Demo_TriggerEvent demoEvent;

			public Demo_Trigger _003C_003E4__this;

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
			public _003CPlayEvent_003Ed__6(int _003C_003E1__state)
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

		private ShaderFaderSSU fader;

		public List<Demo_TriggerEvent> events;

		private void Start()
		{
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		private void OnTriggerExit2D(Collider2D collision)
		{
		}

		public void ChangeState(bool isActive)
		{
		}

		[IteratorStateMachine(typeof(_003CPlayEvent_003Ed__6))]
		private IEnumerator PlayEvent(Demo_TriggerEvent demoEvent)
		{
			return null;
		}
	}
}
