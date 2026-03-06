using Treeplla;
using UnityEngine;

public class ContentsOpenActive : MonoBehaviour
{
	[SerializeField]
	private Config.ContentsOpenType openType;

	[SerializeField]
	private bool reverse;

	[SerializeField]
	private bool onlyMain;

	[SerializeField]
	private bool enableCheck;

	[SerializeField]
	private bool isTutoClear;

	[SerializeField]
	private int tutorialIdx;

	[SerializeField]
	private int ForceActiveRegion;

	private void Awake()
	{
		Refresh();
	}

	private void OnEnable()
	{
		Refresh();
	}

	public void Refresh()
	{
		bool isOpen = false;
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root != null && root.ContentsOpenSystem != null)
		{
			isOpen = root.ContentsOpenSystem.isContentsOpen(openType);
		}
		if (reverse)
			isOpen = !isOpen;
		gameObject.SetActive(isOpen);
	}
}
