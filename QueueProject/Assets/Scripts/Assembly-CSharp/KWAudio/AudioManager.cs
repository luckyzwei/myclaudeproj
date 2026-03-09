using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace KWAudio
{
	public class AudioManager
	{
		public interface IDelegate
		{
			AudioMixer GetAudioMixer();

			AudioMixerSnapshot GetAllSnapshot();

			AudioMixerSnapshot GetNoneSnapshot();

			AudioMixerSnapshot GetMusicSnapshot();

			AudioMixerSnapshot GetSFXSnapshot();

			AudioSoundList GetAudioSoundList();
		}

		[CompilerGenerated]
		private sealed class _003CSetVolumeInTime_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AudioSource source;

			public float volume;

			public float time;

			private float _003CinitialVolume_003E5__2;

			private float _003Ctimer_003E5__3;

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
			public _003CSetVolumeInTime_003Ed__44(int _003C_003E1__state)
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

		public const int CHANNEL_ONESHOT = -1;

		public const int CHANNEL_MASTER = 0;

		public const int CHANNEL_MUSIC = 1;

		public const int CHANNEL_SFX = 2;

		public const int CHANNEL_PROJECT_1 = 3;

		public const int CHANNEL_PROJECT_2 = 4;

		public const int CHANNEL_PROJECT_3 = 5;

		public const int CHANNEL_PROJECT_4 = 6;

		public const int CHANNEL_PROJECT_5 = 7;

		public const int CHANNEL_PROJECT_6 = 8;

		public const int CHANNEL_PROJECT_7 = 9;

		public const int CHANNEL_PROJECT_8 = 10;

		public const int CHANNEL_PROJECT_9 = 11;

		private IDelegate m_delegate;

		private List<AudioChannel> m_channels;

		private float m_musicPausePosition;

		private int m_oneShotIndex;

		public bool MusicEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SFXEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AudioSoundList AudioSoundList => null;

		public void Initialise(IDelegate del)
		{
		}

		private void HandleOnLoadingFinished()
		{
		}

		private bool IsMusicGameSettingEnabled()
		{
			return false;
		}

		private bool IsSfxGameSettingEnabled()
		{
			return false;
		}

		private void UpdateChannels()
		{
		}

		private void MuteForAds()
		{
		}

		private void PopulateChannels()
		{
		}

		private void HandleAdStartedShow()
		{
		}

		private void HandleAdShown(string s)
		{
		}

		private void HandleAdFailedShow()
		{
		}

		public void SetLooping(int channel, bool looping)
		{
		}

		public void Play(AudioClipReference clipRef, int channel = 0, ulong delay = 0uL, bool force = true, bool looping = false, Action callback = null, float pitch = 1f)
		{
		}

		public AudioSource GetAudioSourceForChannel(int channel)
		{
			return null;
		}

		public void Stop(int channel = 0)
		{
		}

		public void PlayOneShot(AudioClipReference clip, int channel = -1, float volume = 1f, float pitch = 1f)
		{
		}

		public void PlayClipAtPoint(AudioClipReference clip, Vector3 position = default(Vector3))
		{
		}

		public AudioChannel GetChannel(int channel = 0)
		{
			return null;
		}

		public void SetChannelVolumeInTime(int channel, float volume, float time)
		{
		}

		[IteratorStateMachine(typeof(_003CSetVolumeInTime_003Ed__44))]
		private IEnumerator SetVolumeInTime(AudioSource source, float volume, float time)
		{
			return null;
		}

		public void PauseChannel(int channel = 0, float time = 0f)
		{
		}

		public void UnpauseChannel(int channel = 0, float time = 0f)
		{
		}

		public float GetTrackLength(AudioClipReference clip)
		{
			return 0f;
		}

		public float GetPlaybackTime(int channel)
		{
			return 0f;
		}

		public void PlaySFXFromLastPlaybackTime(AudioClipReference clipRef, int channel = 0, ulong delay = 0uL, bool force = true, bool looping = false, Action callback = null, float pitch = 1f)
		{
		}
	}
}
