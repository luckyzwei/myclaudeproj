using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableDirectorHelper : MonoBehaviour
{
	[SerializeField]
	private DirectorWrapMode m_animationMode;

	private PlayableDirector m_director;

	private Action m_doneCallback;

	private bool m_playing;

	private void Awake()
	{
		m_director = GetComponent<PlayableDirector>();
		if (m_director != null)
		{
			m_director.extrapolationMode = m_animationMode;
		}
	}

	public void Play(Action callback = null)
	{
		m_doneCallback = callback;

		if (m_director == null)
			m_director = GetComponent<PlayableDirector>();

		UnityEngine.Debug.Log($"[PlayableDirectorHelper] Play() on '{gameObject.name}' - director={m_director != null}, playableAsset={(m_director != null ? (m_director.playableAsset != null ? m_director.playableAsset.name : "NULL") : "N/A")}");

		if (m_director == null || m_director.playableAsset == null)
		{
			UnityEngine.Debug.LogWarning($"[PlayableDirectorHelper] No director or playableAsset on {gameObject.name}");
			callback?.Invoke();
			return;
		}

		m_playing = true;
		m_director.time = 0;
		m_director.Play();
		UnityEngine.Debug.Log($"[PlayableDirectorHelper] Playing '{m_director.playableAsset.name}' duration={m_director.duration:F2}s on '{gameObject.name}'");
		StartCoroutine(AnimationCallback());
	}

	public void Stop()
	{
		m_playing = false;
		StopAllCoroutines();

		if (m_director != null)
			m_director.Stop();

		m_doneCallback = null;
	}

	private IEnumerator AnimationCallback()
	{
		if (m_director == null || m_director.playableAsset == null)
			yield break;

		double duration = m_director.duration;
		yield return new WaitForSeconds((float)duration);

		m_playing = false;
		var cb = m_doneCallback;
		m_doneCallback = null;
		cb?.Invoke();
	}

	private void OnDisable()
	{
		m_playing = false;
		StopAllCoroutines();
	}
}
