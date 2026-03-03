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
	}

	public void Set(int product)
	{
	}

	private void OnValueChanged(float value)
	{
	}

	private void OnClickOrganize()
	{
	}
}
