public class TpStatsParams
{
	public float allocatedMemory;

	public float reservedMemory;

	public float monoMemory;

	public float fps;

	public float gcMemory;

	public float systemMemory;

	public float cpuTotalFrameTime;

	public float cpuMainThreadFrameTime;

	public float cpuRenderThreadFrameTime;

	public float gpuFrameTime;

	public float batchesCount;

	public float setPassCallsCount;

	public float trianglesCount;

	public float verticesCount;

	public void ToZero()
	{
	}

	public void ToMax()
	{
	}
}
