using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KWCore.LowEndDeviceTests
{
	public class FramerateTest
	{
		[CompilerGenerated]
		private sealed class _003CCalculateAverageFPS_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FramerateTest _003C_003E4__this;

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
			public _003CCalculateAverageFPS_003Ed__11(int _003C_003E1__state)
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

		private float m_stageStartTime;

		private float m_totalFrameTime;

		private int m_frameCount;

		private int m_screenRefreshRate;

		private float m_fpsSum;

		private float m_averageFPS;

		private bool m_isLowEndDeviceSupportTestEnabled;

		private void HandleGameSettingsUpdated()
		{
		}

		private void HandleStageStartedEvent(int stageNumber, bool hasStages = false)
		{
		}

		private void HandleStageCompletedEvent(int stageNumber, bool hasStages = false)
		{
		}

		[IteratorStateMachine(typeof(_003CCalculateAverageFPS_003Ed__11))]
		private IEnumerator CalculateAverageFPS()
		{
			return null;
		}

		public float GetAverageFPS()
		{
			return 0f;
		}
	}
}
