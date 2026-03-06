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
		base.Awake();
		disposables = new CompositeDisposable();
		if (DirectOutBtn != null) DirectOutBtn.onClick.AddListener(OnClickCancel);
		if (MaxOutBtn != null) MaxOutBtn.onClick.AddListener(OnClickMaxCancel);
	}

	public void Set(int office)
	{
		OfficeIdx = office;
	}

	public void OnClickCancel()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}

	private int GetCompanyGrade()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return 0;
		return 0;
	}

	public void OnClickMaxCancel()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
