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
		if (LoadedPrevJewelryBoxObj != null) { UnityEngine.Object.Destroy(LoadedPrevJewelryBoxObj); LoadedPrevJewelryBoxObj = null; }
		if (LoadedNextJewelryBoxObj != null) { UnityEngine.Object.Destroy(LoadedNextJewelryBoxObj); LoadedNextJewelryBoxObj = null; }
	}

	private void LoadJewelryBoxPrefab(int stageStep, Transform rootTr, Action<GameObject> onComplete)
	{
		if (rootTr == null) return;
		string path = "Prefab/JewelryBox_" + stageStep;
		GameObject prefab = Resources.Load<GameObject>(path);
		if (prefab != null)
		{
			GameObject obj = UnityEngine.Object.Instantiate(prefab, rootTr);
			onComplete?.Invoke(obj);
		}
	}
}
