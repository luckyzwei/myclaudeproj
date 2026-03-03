using System.Diagnostics;

public class TpLog
{
	[Conditional("TREEPLLA_LOG")]
	public static void Log(string message)
	{
	}

	[Conditional("TREEPLLA_LOG")]
	public static void LogWarning(string message)
	{
	}

	[Conditional("TREEPLLA_LOG")]
	public static void LogError(string message)
	{
	}
}
