using System;
using UnityEngine;

public class SendQueueMgr : MonoBehaviour
{
	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	private void Update()
	{
	}

	private void ExceptionEvent(Exception e)
	{
		UnityEngine.Debug.LogException(e);
	}

	private void OnApplicationPause(bool isPause)
	{
	}

	private void OnApplicationQuit()
	{
	}
}
