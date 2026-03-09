using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnitTesting
{
	public abstract class UTPBasePlayModeUnitTest
	{
		[CompilerGenerated]
		private sealed class _003CWaitUntilConditionIsMetOrTimeout_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float timeoutSeconds;

			public Func<bool> condition;

			private float _003CstartTime_003E5__2;

			private float _003Cduration_003E5__3;

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
			public _003CWaitUntilConditionIsMetOrTimeout_003Ed__1(int _003C_003E1__state)
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

		protected const float TIMEOUT_DURATION = 10f;

		[IteratorStateMachine(typeof(_003CWaitUntilConditionIsMetOrTimeout_003Ed__1))]
		protected static IEnumerator WaitUntilConditionIsMetOrTimeout(Func<bool> condition, float timeoutSeconds = -1f)
		{
			return null;
		}

		protected static void EvaluateTestCase(Func<bool> condition, UnitTestCallback callback, string successMessage, string failureMessage)
		{
		}

		protected static void ReportSuccess(UnitTestCallback callback, string message)
		{
		}

		protected static void ReportFailure(UnitTestCallback callback, string message)
		{
		}

		public virtual void PreTestCaseActions()
		{
		}

		public virtual void PostTestCaseActions()
		{
		}
	}
}
