using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/LoadingRenovate", false, false)]
public class LoadingRenovate : Loading
{
	[SerializeField]
	private Text BeforeRegionText;

	[SerializeField]
	private Text AfterRegionText;

	[SerializeField]
	private Image CeoImg;

	public override void Show()
	{
	}

	public override void Hide(bool Immediately = true, Action action = null)
	{
	}
}
