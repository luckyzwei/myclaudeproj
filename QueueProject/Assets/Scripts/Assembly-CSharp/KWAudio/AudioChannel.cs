using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.Utils;
using UnityEngine;
using UnityEngine.Audio;

namespace KWAudio
{
	public class AudioChannel : BaseBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLerp_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AudioChannel _003C_003E4__this;

			public float volume;

			public float time;

			private float _003CstartVolume_003E5__2;

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
			public _003CLerp_003Ed__19(int _003C_003E1__state)
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
		private sealed class _003COnClipEnd_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public AudioChannel _003C_003E4__this;

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
			public _003COnClipEnd_003Ed__16(int _003C_003E1__state)
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

		private float m_baseVolume;

		private AudioSource m_audioSource;

		private Action m_callback;

		private AudioMixerGroup m_audioMixerGroup;

		private bool m_channelPaused;

		private IEnumerator m_pauseFn;

		public void Init(AudioMixerGroup mixerGroup)
		{
		}

		public void SetVolume(float volume = 1f)
		{
		}

		public float GetVolume()
		{
			return 0f;
		}

		public bool GetChannelPaused()
		{
			return false;
		}

		public void SetLooping(bool looping)
		{
		}

		public void Play(AudioClipReference clip, ulong delay = 0uL, bool force = true, bool looping = false, Action callback = null, float pitch = 1f)
		{
		}

		public void PlayOneShot(AudioClipReference clip, float volume = 1f, float pitch = 1f)
		{
		}

		public void Stop()
		{
		}

		public AudioSource GetAudioSource()
		{
			return null;
		}

		public AudioMixerGroup GetAudioMixerGroup()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003COnClipEnd_003Ed__16))]
		private IEnumerator OnClipEnd(float delay)
		{
			return null;
		}

		public void Pause(float time = 0f)
		{
		}

		public void Unpause(float time = 0f)
		{
		}

		[IteratorStateMachine(typeof(_003CLerp_003Ed__19))]
		private IEnumerator Lerp(float volume, float time)
		{
			return null;
		}
	}
}
