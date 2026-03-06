using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/FindManagerUI", true)]
[FloatingDepth(7)]
public class InGameFindManagerUI : InGameFloatingUI
{
	[SerializeField]
	private Button Btn;

	[SerializeField]
	private GameObject DefaultObj;

	[SerializeField]
	private GameObject PlusObj;

	private bool isOpen;

	private int curOfficeIdx;

	private int curOfficeItemIdx;

	private int curManagerIdx;

	private CompositeDisposable disposable;

	private void Awake()
	{
		disposable = new CompositeDisposable();
		if (Btn != null)
			Btn.onClick.AddListener(OnClickBtn);
		isOpen = false;
		curManagerIdx = -1;
	}

	public void Set(int officeIdx, int itemIdx = 1)
	{
		curOfficeIdx = officeIdx;
		curOfficeItemIdx = itemIdx;
		isOpen = true;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		SetActive(curManagerIdx);
	}

	private void SetActive(int managerIdx)
	{
		curManagerIdx = managerIdx;
		bool hasManager = managerIdx >= 0;
		if (DefaultObj != null)
			DefaultObj.SetActive(hasManager);
		if (PlusObj != null)
			PlusObj.SetActive(!hasManager);
	}

	public void UpdatePlusObj()
	{
		bool hasManager = curManagerIdx >= 0;
		if (PlusObj != null)
			PlusObj.SetActive(!hasManager);
	}

	private void OnClickBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageManager>();
	}

	private void OnDisable()
	{
		if (disposable != null)
			disposable.Clear();
	}

	private void OnDestroy()
	{
		if (disposable != null)
		{
			disposable.Dispose();
			disposable = null;
		}
	}
}
