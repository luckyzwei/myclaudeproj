using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCompanyOut", false, false)]
public class PopupCompanyOut : UIBase
{
	[SerializeField]
	private Text RemainTime;

	[SerializeField]
	private Text DirectOutPriceText;

	[SerializeField]
	private Button DirectOutBtn;

	[SerializeField]
	private Button MaxOutBtn;

	private CompositeDisposable disposables;

	private int OfficeIdx;

	protected override void Awake()
	{
	}

	public void Set(int office)
	{
	}

	public void OnClickCancel()
	{
	}

	private int GetCompanyGrade()
	{
		return 0;
	}

	public void OnClickMaxCancel()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
