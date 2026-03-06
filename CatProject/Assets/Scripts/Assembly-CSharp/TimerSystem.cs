using System.Collections.Generic;

public class TimerSystem
{
	private List<int> mins;

	private int maxTime;

	public bool IsFirstDay { get; set; }

	public void UpdateOneSeconds()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.GamePlayTimeSec == null) return;
		long playTime = root.GamePlayTimeSec.Value;
		CheckPlayMin(playTime);
	}

	public void CheckFirstDay()
	{
		IsFirstDay = true;
	}

	private void CheckPlayMin(long playTime)
	{
		if (mins == null) return;
		int playMin = (int)(playTime / 60);
		for (int i = 0; i < mins.Count; i++)
		{
			if (playMin >= mins[i])
				LogPlayMin(mins[i]);
		}
	}

	private void LogPlayMin(int min)
	{
		UnityEngine.Debug.Log($"[Timer] PlayMin:{min}");
	}
}
