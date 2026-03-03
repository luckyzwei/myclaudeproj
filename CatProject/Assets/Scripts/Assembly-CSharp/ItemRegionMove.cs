using UnityEngine;
using UnityEngine.UI;

public class ItemRegionMove : MonoBehaviour
{
	[SerializeField]
	private Button GoBtn;

	[SerializeField]
	private Button GoFactoryBtn;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Title;

	[SerializeField]
	private Text Desc;

	[SerializeField]
	private GameObject LockRoot;

	[SerializeField]
	private GameObject MoveRoot;

	[SerializeField]
	private GameObject NewObj;

	[Space(5f)]
	[SerializeField]
	private GameObject HereObj;

	[SerializeField]
	private Text CommingText;

	[SerializeField]
	private GameObject LevelRoot;

	[SerializeField]
	private Text LevelText;

	[SerializeField]
	private Button InfoBtn;

	private int curIdx;

	private readonly string ReadyIcon;

	private void Awake()
	{
	}

	public void Set(int regionIdx)
	{
	}

	public void OnClickRegionMove()
	{
	}

	public void OnClickFactory()
	{
	}

	public void OnClickInfo()
	{
	}
}
