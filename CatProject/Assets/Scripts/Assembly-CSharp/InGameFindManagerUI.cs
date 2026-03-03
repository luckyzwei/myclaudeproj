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
	}

	public void Set(int officeIdx, int itemIdx = 1)
	{
	}

	private void SetActive(int managerIdx)
	{
	}

	public void UpdatePlusObj()
	{
	}

	private void OnClickBtn()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
