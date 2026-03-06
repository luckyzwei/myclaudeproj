using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupUpdate", false, false)]
public class PopupUpdate : UIBase
{
	[SerializeField]
	private Button hideBtn;

	[SerializeField]
	private Button updateBtn;

	[SerializeField]
	private Text gemText;

	private Action<bool> action;

	protected override void Awake()
	{
		base.Awake();
		if (updateBtn != null) updateBtn.onClick.AddListener(GoUpdate);
		if (hideBtn != null) hideBtn.onClick.AddListener(OnClickHide);
	}

	public void Init(Action<bool> _action, bool isHardUpdate = false)
	{
		action = _action;
		if (hideBtn != null) hideBtn.gameObject.SetActive(!isHardUpdate);
	}

	private void GoUpdate()
	{
		action?.Invoke(true);
		Hide();
	}

	private void OnClickHide()
	{
		action?.Invoke(false);
		Hide();
	}
}
