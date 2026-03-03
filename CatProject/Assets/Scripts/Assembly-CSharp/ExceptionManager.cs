using UnityEngine;

public class ExceptionManager : MonoBehaviour
{
	public int ErrorCount { get; private set; }

	private void Awake()
	{
	}

	private void LogcaughtException(string logText, string stackTrace, LogType logType)
	{
	}

	private void OnDestroy()
	{
	}
}
