using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupFactoryOrganize", false, false)]
public class PopupFactoryOrganize : UIBase
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text Desc;

	[SerializeField]
	private Text Count;

	[SerializeField]
	private Slider Progress;

	[SerializeField]
	private Text TargetCount;

	[SerializeField]
	private Button OrganizeBtn;

	private int ProductIdx;

	protected override void Awake()
	{
		base.Awake();
		if (OrganizeBtn != null) OrganizeBtn.onClick.AddListener(OnClickOrganize);
	}

	public void Set(int product)
	{
		ProductIdx = product;
	}

	private void OnValueChanged(float value)
	{
		if (Count != null) Count.text = ((int)value).ToString();
	}

	private void OnClickOrganize()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}
}
