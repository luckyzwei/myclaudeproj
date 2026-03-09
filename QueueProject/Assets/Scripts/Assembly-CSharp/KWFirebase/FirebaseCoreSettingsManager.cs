using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWGameSettings;

namespace KWFirebase
{
	public class FirebaseCoreSettingsManager : GameSettingsInterface, IGameSettings
	{
		[CompilerGenerated]
		private sealed class _003CSendGameSettingsUpdatedDelayed_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CSendGameSettingsUpdatedDelayed_003Ed__8(int _003C_003E1__state)
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

		private FirebaseGameSettings m_settings;

		private long m_totalTimeInPause;

		private long m_lastPauseTime;

		public override IGameSettings GetGameSettingsServer()
		{
			return null;
		}

		public void Initialise(GameSettingsInterface settingsInterface)
		{
		}

		public void DoOnApplicationPause(bool isPaused)
		{
		}

		public GameSettings GetGameSettings()
		{
			return null;
		}

		private void OnRemoteConfigUpdated()
		{
		}

		[IteratorStateMachine(typeof(_003CSendGameSettingsUpdatedDelayed_003Ed__8))]
		private IEnumerator SendGameSettingsUpdatedDelayed()
		{
			return null;
		}

		private void SendGameSettingsReceivedAnalyticEvent()
		{
		}
	}
}
