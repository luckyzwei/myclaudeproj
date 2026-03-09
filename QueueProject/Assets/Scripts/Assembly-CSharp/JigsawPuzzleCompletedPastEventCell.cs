using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class JigsawPuzzleCompletedPastEventCell : JigsawPuzzleCompletedCell, ILoadingInterface
{
	[SerializeField]
	private bool m_generateAtlas;

	[SerializeField]
	private bool m_loopAnimation;

	private bool m_isCompleted;

	private AsyncOperationHandle<GameObject> m_handle;

	private AddressableLoader m_activeLoader;

	protected override void PrepareData()
	{
	}

	protected override void PreparePuzzle()
	{
	}

	private void LoadPuzzle(Object puzzle)
	{
	}

	protected override void ShowPainting(bool generateAtlas = false)
	{
	}

	public void OnButtonPressed()
	{
	}

	public bool IsDone()
	{
		return false;
	}

	public float GetProgress()
	{
		return 0f;
	}

	public string GetLoadingDescription()
	{
		return null;
	}
}
