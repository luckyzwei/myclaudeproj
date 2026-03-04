using System;
using System.Threading;

namespace WebSocketSharp.Net
{
	internal class HttpStreamAsyncResult : IAsyncResult
	{
		private byte[] _buffer;

		private AsyncCallback _callback;

		private bool _completed;

		private int _count;

		private Exception _exception;

		private int _offset;

		private object _state;

		private object _sync;

		private int _syncRead;

		private ManualResetEvent _waitHandle;

		internal byte[] Buffer
		{
		get { return _buffer; }
		set { _buffer = value; }
	}

		internal int Count
		{
		get { return _count; }
		set { _count = value; }
	}

		internal Exception Exception => null;

		internal bool HasException => false;

		internal int Offset
		{
		get { return _offset; }
		set { _offset = value; }
	}

		internal int SyncRead
		{
		get { return _syncRead; }
		set { _syncRead = value; }
	}

		public object AsyncState => null;

		public WaitHandle AsyncWaitHandle => null;

		public bool CompletedSynchronously => false;

		public bool IsCompleted => false;

		internal HttpStreamAsyncResult(AsyncCallback callback, object state)
	{
		_callback = callback;
	}

		internal void Complete()
		{
		}

		internal void Complete(Exception exception)
		{
		}
	}
}
