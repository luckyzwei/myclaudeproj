using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public class UnityMainThreadDispatcher : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActionWrapper_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action a;

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
		public _003CActionWrapper_003Ed__5(int _003C_003E1__state)
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
					a?.Invoke();
					return false;
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

	private static readonly Queue<Action> _executionQueue = new Queue<Action>();

	public void Update()
	{
		lock (_executionQueue)
		{
			while (_executionQueue.Count > 0)
			{
				var action = _executionQueue.Dequeue();
				action?.Invoke();
			}
		}
	}

	public void Enqueue(IEnumerator action)
	{
		lock (_executionQueue)
		{
			_executionQueue.Enqueue(() => StartCoroutine(action));
		}
	}

	public void Enqueue(Action action)
	{
		lock (_executionQueue)
		{
			_executionQueue.Enqueue(action);
		}
	}

	public Task EnqueueAsync(Action action)
	{
		var tcs = new TaskCompletionSource<bool>();
		lock (_executionQueue)
		{
			_executionQueue.Enqueue(() =>
			{
				try
				{
					action?.Invoke();
					tcs.TrySetResult(true);
				}
				catch (Exception e)
				{
					tcs.TrySetException(e);
				}
			});
		}
		return tcs.Task;
	}

	[IteratorStateMachine(typeof(_003CActionWrapper_003Ed__5))]
	private IEnumerator ActionWrapper(Action a)
	{
		var d = new _003CActionWrapper_003Ed__5(0);
		d.a = a;
		return d;
	}

	private void Awake()
	{
		// Initialize
	}

	private void OnDestroy()
	{
		lock (_executionQueue)
		{
			_executionQueue.Clear();
		}
	}
}
