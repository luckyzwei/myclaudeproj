using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace KWCore.CoreRequests
{
	public class CoreRequestsHandler
	{
		[CompilerGenerated]
		private sealed class _003CQueueTicker_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CoreRequestsHandler _003C_003E4__this;

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
			public _003CQueueTicker_003Ed__14(int _003C_003E1__state)
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
		private sealed class _003CSendRequestToServer_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CoreRequestsHandler _003C_003E4__this;

			public CoreRequest coreRequest;

			private CoreRequest _003Crequest_003E5__2;

			private UnityWebRequest _003CwebRequest_003E5__3;

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
			public _003CSendRequestToServer_003Ed__17(int _003C_003E1__state)
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

		private const float QUEUE_REFRESH_TIME = 0.5f;

		private bool m_isProcessActive;

		private bool m_hasInternetAccess;

		private CoreRequestsCache m_coreRequestsCache;

		private Queue<CoreRequest> m_coreRequestsQueue;

		private List<CoreRequest> m_requestsPending;

		public void Initialise()
		{
		}

		public void AddNewCoreRequest(CoreRequest request)
		{
		}

		public void FlushQueueAndCache()
		{
		}

		public string BeautifyJsonSubstring(string jsonData)
		{
			return null;
		}

		public void DoOnApplicationQuit()
		{
		}

		public void DoOnApplicationPause(bool pause)
		{
		}

		private void StartProcessingRequests()
		{
		}

		[IteratorStateMachine(typeof(_003CQueueTicker_003Ed__14))]
		private IEnumerator QueueTicker()
		{
			return null;
		}

		private void ProcessRequests()
		{
		}

		private bool HasInternetConnection()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CSendRequestToServer_003Ed__17))]
		private IEnumerator SendRequestToServer(CoreRequest coreRequest)
		{
			return null;
		}

		private UnityWebRequest SelectWebRequestMethod(CoreRequest coreRequest)
		{
			return null;
		}

		private void SetUpRequestHeaders(UnityWebRequest request, CoreRequest requestData)
		{
		}

		private CoreRequest ConfigureAuthRequest(CoreRequest request)
		{
			return null;
		}

		private string SerializePayload(Hashtable payload)
		{
			return null;
		}

		private void CacheRequests()
		{
		}
	}
}
