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
		if (ShortCutBtn != null) ShortCutBtn.onClick.AddListener(OnClickedShortCutBtn);
	}

	public void Set(int office, int itemtype, Action<int> onClickedCallBack)
	{
		OfficeIdx = office;
		ItemType = itemtype;
		OnClickedShortCut = onClickedCallBack;
		Refresh();
	}

	public void Refresh()
	{
		if (EnoughObj != null) EnoughObj.SetActive(IsEnoughItem);
		if (NotYetObj != null) NotYetObj.SetActive(!IsEnoughItem);
	}

	private void OnClickedShortCutBtn()
	{
		OnClickedShortCut?.Invoke(ItemType);
	}
}
