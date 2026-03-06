using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCEOFire", false, false)]
public class PopupCEOFire : UIBase
{
	[SerializeField]
	private Button FireBtn;

	private Action OnFire;

	protected override void Awake()
	{
		base.Awake();
		if (FireBtn != null) FireBtn.onClick.AddListener(OnClickFire);
	}

	public void Set(Action onFire)
	{
		OnFire = onFire;
	}

	private void OnClickFire()
	{
		OnFire?.Invoke();
		Hide();
	}
}
