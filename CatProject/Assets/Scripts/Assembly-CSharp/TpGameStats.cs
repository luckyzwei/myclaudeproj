using System.Collections.Generic;
using Unity.Profiling;

public class TpGameStats
{
	private static readonly float StatsListSamplingInterval;

	private static readonly int CsvFileUpdateCondition;

	private List<TpStats> statsList;

	private string externalPath;

	private TpStats stats;

	private int cycleCount;

	private float accDeltaTime;

	private bool isRunning;

	private ProfilerRecorder systemMemoryRecorder;

	private ProfilerRecorder gcMemoryRecorder;

	private ProfilerRecorder cpuTotalFrameTimeRecorder;

	private ProfilerRecorder cpuMainThreadFrameTimeRecorder;

	private ProfilerRecorder cpuRenderThreadFrameTimeRecorder;

	private ProfilerRecorder gpuFrameTimeRecorder;

	private ProfilerRecorder batchesCountRecorder;

	private ProfilerRecorder setPassCallsCountRecorder;

	private ProfilerRecorder TrianglesCountRecorder;

	private ProfilerRecorder VerticesCountRecorder;

	public void Start()
	{
	}

	public void UpdateStatus(int cycleCount)
	{
	}

	public void Cycle()
	{
	}

	private void FlushStatsList()
	{
	}

	public string Query(int startIndex)
	{
		return null;
	}

	public void Stop()
	{
	}

	public void AppendCsvFile(string content)
	{
	}

	public void SetCommandEvent(TpCommandParams cmdParams)
	{
	}

	public void SetComment(string comment)
	{
	}
}
