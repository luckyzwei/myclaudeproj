using PathCreation;
using UnityEngine;

public class InGamePath : MonoBehaviour
{
	[SerializeField]
	private PathCreator mainPath;

	[SerializeField]
	private float totalTime;

	private bool slot;

	public float TotalDuration { get { return totalTime; } }

	public void SetPath(PathCreator path)
	{
		mainPath = path;
	}

	public void SetTime(float time)
	{
		totalTime = time;
	}

	public Vector3 GetPathByRatio(float ratio, EndOfPathInstruction inst = EndOfPathInstruction.Stop)
	{
		if (mainPath == null || mainPath.path == null) return Vector3.zero;
		float dist = Mathf.Clamp01(ratio) * mainPath.path.length;
		return mainPath.path.GetPointAtDistance(dist, inst);
	}

	public Vector3 GetPathByTime(float time, EndOfPathInstruction inst = EndOfPathInstruction.Stop)
	{
		if (totalTime <= 0f) return GetPathByRatio(0f, inst);
		return GetPathByRatio(time / totalTime, inst);
	}

	public int GetPathIdxAtTime(float time, EndOfPathInstruction inst = EndOfPathInstruction.Stop)
	{
		if (totalTime <= 0f) return 0;
		return GetPathIdxAtRatio(time / totalTime, inst);
	}

	public int GetPathIdxAtRatio(float ratio, EndOfPathInstruction inst = EndOfPathInstruction.Stop)
	{
		// Approximate path index from ratio
		int max = GetPathIndexMax();
		if (max <= 0) return 0;
		return Mathf.Clamp(Mathf.FloorToInt(Mathf.Clamp01(ratio) * max), 0, max - 1);
	}

	public Vector3 GetPathIndex(int idx)
	{
		if (mainPath == null || mainPath.path == null) return Vector3.zero;
		int max = GetPathIndexMax();
		if (max <= 0 || idx < 0 || idx >= max) return Vector3.zero;
		float ratio = (float)idx / max;
		return GetPathByRatio(ratio);
	}

	public int GetPathIndexMax()
	{
		if (mainPath == null || mainPath.path == null) return 0;
		return mainPath.path.NumPoints;
	}

	public Vector3 GetPathFirst()
	{
		return GetPathByRatio(0f);
	}

	public Vector3 GetPathLast()
	{
		return GetPathByRatio(1f);
	}

	public float GetTimebyIdx(int idx)
	{
		int max = GetPathIndexMax();
		if (max <= 0) return 0f;
		return totalTime * ((float)idx / max);
	}

	public float GetPathRatioByTime(float time)
	{
		if (totalTime <= 0f) return 0f;
		return Mathf.Clamp01(time / totalTime);
	}

	public int GetRatioByIdx(Vector3 point)
	{
		if (mainPath == null || mainPath.path == null) return 0;
		float closestTime = mainPath.path.GetClosestTimeOnPath(point);
		int max = GetPathIndexMax();
		if (max <= 0) return 0;
		return Mathf.Clamp(Mathf.FloorToInt(closestTime * max), 0, max - 1);
	}
}
