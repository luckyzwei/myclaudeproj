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
		base.Awake();
		if (ConfirmBtn != null) ConfirmBtn.onClick.AddListener(OnClickConfirm);
		if (GemConfirmBtn != null) GemConfirmBtn.onClick.AddListener(OnClickGemConfirm);
	}

	public void Show(NameType type)
	{
		EditType = type;
		if (EditBox != null) EditBox.text = "";
		bool isFree = price <= 0;
		if (FirstFreeObj != null) FirstFreeObj.SetActive(isFree);
		if (ConfirmBtn != null) ConfirmBtn.gameObject.SetActive(isFree);
		if (GemConfirmBtn != null) GemConfirmBtn.gameObject.SetActive(!isFree);
		if (NeedGemCount != null) NeedGemCount.text = price.ToString();
		Show();
	}

	private void OnChangeName(string name)
	{
		if (ConfirmBtn != null) ConfirmBtn.interactable = !string.IsNullOrEmpty(name);
		if (GemConfirmBtn != null) GemConfirmBtn.interactable = !string.IsNullOrEmpty(name);
	}

	private void OnClickConfirm()
	{
		if (EditBox == null || string.IsNullOrEmpty(EditBox.text)) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}

	private void OnClickGemConfirm()
	{
		if (EditBox == null || string.IsNullOrEmpty(EditBox.text)) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}
}
