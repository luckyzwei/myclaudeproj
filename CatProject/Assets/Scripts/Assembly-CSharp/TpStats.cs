using System;
using System.Collections.Generic;

public class TpStats
{
	public TpStatsParams maxStats;

	public TpStatsParams minStats;

	public TpStatsParams avgStats;

	public List<TpGameStatsCommandParams> commandParams;

	public List<string> comments;

	public DateTime now;

	public void UpdateAllocatedMemory(float allocatedRam, int statsCount)
	{
	}

	public void UpdateReservedMemory(float reservedRam, int statsCount)
	{
	}

	public void UpdateMonoMemory(float monoRam, int statsCount)
	{
	}

	public void UpdateFPS(float currentFPS, int statsCount)
	{
	}

	public void UpdateGcMemory(float gcMemory, int statsCount)
	{
	}

	public void UpdateSystemMemory(float systemMemory, int statsCount)
	{
	}

	public void UpdateCpuTotalFrameTime(float cpuTotalFrameTime, int cycleCount)
	{
	}

	public void UpdateCpuMainThreadFrameTime(float cpuMainThreadFrameTime, int cycleCount)
	{
	}

	public void UpdateCpuRenderThreadFrameTime(float cpuRenderThreadFrameTime, int cycleCount)
	{
	}

	public void UpdateGpuFrameTime(float gpuFrameTime, int cycleCount)
	{
	}

	public void UpdateBatchesCount(int batchesCount, int cycleCount)
	{
	}

	public void UpdateSetPassCallsCount(int setPathCallsCount, int cycleCount)
	{
	}

	public void UpdateTrianglesCount(int trianglesCount, int cycleCount)
	{
	}

	public void UpdateVerticesCount(int verticesCount, int cycleCount)
	{
	}

	public string ConvertToCsv()
	{
		return null;
	}

	public static string GetCsvColumns()
	{
		return null;
	}

	public void AddCommandEvent(TpCommandParams commandParams)
	{
	}

	public void UpdateTime()
	{
	}

	public void AddComment(string comment)
	{
	}
}
