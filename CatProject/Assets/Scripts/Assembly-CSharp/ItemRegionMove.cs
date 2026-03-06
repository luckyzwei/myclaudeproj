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
		if (GoBtn != null) GoBtn.onClick.AddListener(OnClickRegionMove);
		if (GoFactoryBtn != null) GoFactoryBtn.onClick.AddListener(OnClickFactory);
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
	}

	public void Set(int regionIdx)
	{
		curIdx = regionIdx;
	}

	public void OnClickRegionMove()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null) return;
		// Request region move via game systems
	}

	public void OnClickFactory()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupFactoryWorkPlace>();
	}

	public void OnClickInfo()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}
}
