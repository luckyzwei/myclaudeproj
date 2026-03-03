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
	}

	public void Set(Action onFire)
	{
	}

	private void OnClickFire()
	{
	}
}
