using PathCreation;
using UnityEngine;

public class InGamePath : MonoBehaviour
{
	[SerializeField]
	private PathCreator mainPath;

	[SerializeField]
	private float totalTime;

	private bool slot;

	public float TotalDuration { get { return 0f; } }

	public void SetPath(PathCreator path)
	{
	}

	public void SetTime(float time)
	{
	}

	public Vector3 GetPathByRatio(float ratio, EndOfPathInstruction inst = EndOfPathInstruction.Stop)
	{
		return default(Vector3);
	}

	public Vector3 GetPathByTime(float time, EndOfPathInstruction inst = EndOfPathInstruction.Stop)
	{
		return default(Vector3);
	}

	public int GetPathIdxAtTime(float time, EndOfPathInstruction inst = EndOfPathInstruction.Stop)
	{
		return 0;
	}

	public int GetPathIdxAtRatio(float ratio, EndOfPathInstruction inst = EndOfPathInstruction.Stop)
	{
		return 0;
	}

	public Vector3 GetPathIndex(int idx)
	{
		return default(Vector3);
	}

	public int GetPathIndexMax()
	{
		return 0;
	}

	public Vector3 GetPathFirst()
	{
		return default(Vector3);
	}

	public Vector3 GetPathLast()
	{
		return default(Vector3);
	}

	public float GetTimebyIdx(int idx)
	{
		return 0f;
	}

	public float GetPathRatioByTime(float time)
	{
		return 0f;
	}

	public int GetRatioByIdx(Vector3 point)
	{
		return 0;
	}
}
