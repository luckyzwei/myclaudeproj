using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAcquisitionBankLvUp", false, false)]
public class PopupAcquisitionBankLvUp : UIBase
{
	[SerializeField]
	private Transform PrevBankImgRootTr;

	[SerializeField]
	private Transform NextBankImgRootTr;

	[SerializeField]
	private Text PrevMaxCntText;

	[SerializeField]
	private Text NextMaxCntText;

	[SerializeField]
	private Text LevelUpDescText;

	private GameObject LoadedPrevJewelryBoxObj;

	private GameObject LoadedNextJewelryBoxObj;

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	private void LoadJewelryBoxPrefab(int stageStep, Transform rootTr, Action<GameObject> onComplete)
	{
	}
}
