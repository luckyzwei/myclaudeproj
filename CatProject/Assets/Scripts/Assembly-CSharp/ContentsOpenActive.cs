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
	}

	private void OnEnable()
	{
	}

	public void Refresh()
	{
	}
}
