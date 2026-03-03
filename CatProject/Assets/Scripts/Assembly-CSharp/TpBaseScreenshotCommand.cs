using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public abstract class TpBaseScreenshotCommand<TParams, TResult> : TpCommand<TParams, TResult> where TParams : TpCommandParams
{
	[CompilerGenerated]
	private sealed class _003CSendPNGScreenshotCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TpBaseScreenshotCommand<TParams, TResult> _003C_003E4__this;

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
		public _003CSendPNGScreenshotCoroutine_003Ed__4(int _003C_003E1__state)
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

	protected readonly ITpCommandHandler Handler;

	private string socket;

	protected TpBaseScreenshotCommand(ITpCommandHandler handler, TParams cmdParams, string socketID)
		: base((TParams)null)
	{
	}

	public abstract override TResult Execute();

	[IteratorStateMachine(typeof(TpBaseScreenshotCommand<, >._003CSendPNGScreenshotCoroutine_003Ed__4))]
	protected IEnumerator SendPNGScreenshotCoroutine()
	{
		return null;
	}

	private string getPNGScreenshot()
	{
		return null;
	}
}
