using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace KWCore.LowEndDeviceTests
{
	public class BandwidthTest
	{
		[CompilerGenerated]
		private sealed class _003CDownloadFileForTest_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BandwidthTest _003C_003E4__this;

			private UnityWebRequest _003Crequest_003E5__2;

			private Stopwatch _003Cstopwatch_003E5__3;

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
			public _003CDownloadFileForTest_003Ed__9(int _003C_003E1__state)
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

		private const string DOWNLOAD_URL = "https://d2kre6881rwtik.cloudfront.net/anubis-resources/creative-performance-check/test-file-125KB";

		private const int FILE_SIZE = 128000;

		private float m_downloadTime;

		private float m_downloadSpeed;

		private bool m_isLowEndDeviceSupportTestEnabled;

		private IEnumerator m_downloadFileForTestCoroutine;

		private void HandleGameSettingsUpdated()
		{
		}

		public void DoOnApplicationPause(bool paused)
		{
		}

		[IteratorStateMachine(typeof(_003CDownloadFileForTest_003Ed__9))]
		private IEnumerator DownloadFileForTest()
		{
			return null;
		}

		public float GetBandWidthTestDownloadSpeed()
		{
			return 0f;
		}
	}
}
