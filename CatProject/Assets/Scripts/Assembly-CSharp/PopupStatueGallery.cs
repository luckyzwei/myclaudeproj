using Treeplla;
using UnityEngine;

[UIPath("UI/Popup/PopupStatueGallery", false, false)]
public class PopupStatueGallery : UIBase
{
	[SerializeField]
	private Transform StatueRoot;

	[SerializeField]
	private GameObject StatueItem;

	public override void OnShowBefore()
	{
	}

	private void SetList()
	{
	}
}
