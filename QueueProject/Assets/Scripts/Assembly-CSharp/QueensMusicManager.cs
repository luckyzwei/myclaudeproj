using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;

public class QueensMusicManager
{
	[CompilerGenerated]
	private sealed class _003CStopMusicCoroutine_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int channel;

		public float targetVolume;

		public float time;

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
		public _003CStopMusicCoroutine_003Ed__3(int _003C_003E1__state)
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

	public static void PlayMenuMusic()
	{
	}

	public static void PlayGameMusic(bool smoothly = true, LevelDifficulty levelDifficulty = LevelDifficulty.NORMAL)
	{
	}

	public static void StopMusic(bool smoothly = true)
	{
	}

	[IteratorStateMachine(typeof(_003CStopMusicCoroutine_003Ed__3))]
	private static IEnumerator StopMusicCoroutine(int channel, float time, float targetVolume)
	{
		return null;
	}
}
