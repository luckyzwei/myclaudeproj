using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemRequireItem : MonoBehaviour
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text NeedLv;

	[SerializeField]
	private GameObject EnoughObj;

	[SerializeField]
	private GameObject NotYetObj;

	[SerializeField]
	private Text NeeText;

	[SerializeField]
	private Button ShortCutBtn;

	private int OfficeIdx;

	private int ItemType;

	private Action<int> OnClickedShortCut;

	public bool IsEnoughItem { get; private set; }

	private void Awake()
	{
	}

	public void Set(int office, int itemtype, Action<int> onClickedCallBack)
	{
	}

	public void Refresh()
	{
	}

	private void OnClickedShortCutBtn()
	{
	}
}
