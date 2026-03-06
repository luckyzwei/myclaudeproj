using UnityEngine;

public class ExceptionManager : MonoBehaviour
{
	public int ErrorCount { get; private set; }

	private void Awake()
	{
		ErrorCount = 0;
		Application.logMessageReceived += LogcaughtException;
	}

	private void LogcaughtException(string logText, string stackTrace, LogType logType)
	{
		if (logType == LogType.Exception || logType == LogType.Error)
		{
			ErrorCount++;
			Debug.LogWarning($"[ExceptionManager] Caught: {logText}");
		}
	}

	private void OnDestroy()
	{
		Application.logMessageReceived -= LogcaughtException;
	}
}
