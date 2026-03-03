using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupEditName", false, false)]
public class PopupEditName : UIBase
{
	public enum NameType
	{
		CharName = 0,
		CompanyName = 1
	}

	[SerializeField]
	private Button ConfirmBtn;

	[SerializeField]
	private Button GemConfirmBtn;

	[SerializeField]
	private Text NeedGemCount;

	[SerializeField]
	private Text DescText;

	[SerializeField]
	private InputField EditBox;

	[SerializeField]
	private GameObject FirstFreeObj;

	private NameType EditType;

	private int price;

	protected override void Awake()
	{
	}

	public void Show(NameType type)
	{
	}

	private void OnChangeName(string name)
	{
	}

	private void OnClickConfirm()
	{
	}

	private void OnClickGemConfirm()
	{
	}
}
