using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using KWAnalytics.Analytics;
using UnityEngine;

namespace KWCore.Utils
{
	public class NTPServerTimeManager
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			public Task<IPAddress[]> dnsTask;

			internal bool _003CResolveHostAndConnect_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass35_0
		{
			public DateTime? receivedTime;

			internal void _003CNTPRequestCoroutine_003Eb__0(DateTime? result)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CNTPRequestCoroutine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NTPServerTimeManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

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
			public _003CNTPRequestCoroutine_003Ed__35(int _003C_003E1__state)
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
		private sealed class _003CResolveHostAndConnect_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NTPServerTimeManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

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
			public _003CResolveHostAndConnect_003Ed__29(int _003C_003E1__state)
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
		private sealed class _003CSendNTPRequestSocket_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NTPServerTimeManager _003C_003E4__this;

			public Action<DateTime?> callback;

			private Socket _003Csocket_003E5__2;

			private float _003CstartTime_003E5__3;

			private EndPoint _003CremoteEndPoint_003E5__4;

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
			public _003CSendNTPRequestSocket_003Ed__36(int _003C_003E1__state)
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

		public static Action OnRequestCompleted;

		public static Action OnNTPInitialised;

		private const string NTP_SERVER = "pool.ntp.org";

		private const int NTP_SERVER_PORT = 123;

		private const int NTP_HEADER = 35;

		private const float NTP_TIMEOUT_SECONDS = 2f;

		private const int RELOAD_WAIT_TIME_NO_CONNECTION = 3;

		private const int MAX_NTP_RETRIES = 3;

		private const int NTP_BUFFER_SIZE = 48;

		private static DateTime s_ntpDate;

		private static float s_updateTime;

		private static float s_lastSystemUptime;

		private static int s_attempt;

		private static Stopwatch s_stopwatch;

		private readonly byte[] m_ntpBuffer;

		private readonly WaitForEndOfFrame m_waitForEndOfFrame;

		private readonly EndPoint m_remoteEndPoint;

		private IPEndPoint m_serverEndPoint;

		private IEnumerator m_activeRequestCoroutine;

		private IEnumerator m_resolveHostCoroutine;

		private NTPTimeReceivedEvent m_receivedEvent;

		private bool m_isNtpTimeEventSent;

		public static bool IsTimeInitialized { get; private set; }

		public static DateTime NTPDate => default(DateTime);

		public void Initialise()
		{
		}

		[IteratorStateMachine(typeof(_003CResolveHostAndConnect_003Ed__29))]
		private IEnumerator ResolveHostAndConnect()
		{
			return null;
		}

		private IPAddress[] ResolveDns()
		{
			return null;
		}

		public void DoOnApplicationQuit()
		{
		}

		private void Reset()
		{
		}

		public static bool HasExceededMaxRetries()
		{
			return false;
		}

		private void GetNTPTime()
		{
		}

		[IteratorStateMachine(typeof(_003CNTPRequestCoroutine_003Ed__35))]
		private IEnumerator NTPRequestCoroutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSendNTPRequestSocket_003Ed__36))]
		private IEnumerator SendNTPRequestSocket(Action<DateTime?> callback)
		{
			return null;
		}

		private void SetTime(DateTime time)
		{
		}

		private static float CalculateTimeSinceStartup()
		{
			return 0f;
		}

		private void SendNTPTimeReceivedEvent()
		{
		}
	}
}
