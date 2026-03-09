using UnityEngine;
using UnityEngine.Audio;

namespace KWAudio.Interface
{
	public class AudioInterface : MonoBehaviour, AudioManager.IDelegate
	{
		[SerializeField]
		private AudioMixer m_audioMixer;

		[SerializeField]
		private AudioMixerSnapshot m_allSnapshot;

		[SerializeField]
		private AudioMixerSnapshot m_noneSnapshot;

		[SerializeField]
		private AudioMixerSnapshot m_musicSnapshot;

		[SerializeField]
		private AudioMixerSnapshot m_sfxSnapshot;

		[SerializeField]
		private AudioSoundList m_audioSoundList;

		public AudioMixer GetAudioMixer()
		{
			return null;
		}

		public AudioMixerSnapshot GetAllSnapshot()
		{
			return null;
		}

		public AudioMixerSnapshot GetMusicSnapshot()
		{
			return null;
		}

		public AudioMixerSnapshot GetNoneSnapshot()
		{
			return null;
		}

		public AudioMixerSnapshot GetSFXSnapshot()
		{
			return null;
		}

		public virtual AudioSoundList GetAudioSoundList()
		{
			return null;
		}
	}
}
