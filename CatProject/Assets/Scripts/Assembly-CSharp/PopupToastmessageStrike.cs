using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupToastmessageStrike", false, false)]
public class PopupToastmessageStrike : UIBase
{
	[Header("PopupToastmessageStrike")]
	[SerializeField]
	private GameObject RemainTimeObj;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Button ConfirmBtn;

	private bool isShowRemainTime;

	private float timer;

	protected override void Awake()
	{
		base.Awake();
		if (ConfirmBtn != null) ConfirmBtn.onClick.AddListener(OnClickConfirm);
	}

	public override void OnShowBefore()
	{
		timer = 0f;
		isShowRemainTime = false;
	}

	public void SetActiveTime(bool isShow)
	{
		isShowRemainTime = isShow;
		if (RemainTimeObj != null) RemainTimeObj.SetActive(isShow);
	}

	private void Update()
	{
		if (!isShowRemainTime) return;
		timer += Time.deltaTime;
	}

	public void OnClickConfirm()
	{
		Hide();
	}
}
