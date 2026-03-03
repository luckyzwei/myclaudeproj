using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupManagerBoxOpen", false, false)]
public class PopupManagerBoxOpen : UIBase
{
	[Header("PopupManagerBoxOpen")]
	[SerializeField]
	private Button OpenBtn;

	[SerializeField]
	private Button ManyOpenBtn;

	[SerializeField]
	private CardBoxComponent CardBoxComponent;

	[SerializeField]
	private Image CardBoxIcon;

	[SerializeField]
	private Image KeyIcon;

	[SerializeField]
	private Image CurKeyIcon;

	[Space(5f)]
	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Text KeyCountText;

	[SerializeField]
	private Text BoxCountText;

	[SerializeField]
	private Text CurKeyCountText;

	[SerializeField]
	private Text OpenText;

	[SerializeField]
	private Text ManyOpenText;

	private Action<int> OpenCb;

	private int openCount;

	protected override void Awake()
	{
	}

	public void Set(int goodsIdx, int itemIdx, Action<int> callBack)
	{
	}

	public void OnClickOpenBtn()
	{
	}

	public void OnClickManyOpenBtn()
	{
	}
}
