using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemOnetimeReward : MonoBehaviour
{
	[SerializeField]
	private GameObject ProgressOn;

	[SerializeField]
	private Text CurLevelText;

	[SerializeField]
	private DoTweenScriptComponent CurLevelDoTweenComponent;

	[SerializeField]
	private List<ItemArticle> ItemArticles;

	[Header("Button")]
	[SerializeField]
	private GameObject BtnRoot;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private Button CashBtn;

	[SerializeField]
	private Text CashText;

	[SerializeField]
	private GameObject ReddotObject;

	[SerializeField]
	private Animator LockAnimator;

	[SerializeField]
	private GameObject DimObject;

	[Header("Info")]
	[SerializeField]
	private Button[] infoButtons;

	[SerializeField]
	private GameObject[] infoIcons;

	[SerializeField]
	private GameObject[] infoBubbles;

	[SerializeField]
	private Text[] infoTexts;

	private int curLevel;

	private int curStep;

	private int curSpecialIdx;

	private List<OneTimeEventSystem.OnetimeRewardData> curRewards;

	private bool hasCompanyExpReward;

	private void Awake()
	{
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnClickReward);
	}

	public void SetRewards(int order, bool isSpecial = false)
	{
		curStep = order;
		curSpecialIdx = isSpecial ? order : 0;
		UpdateBtn(true);
	}

	public void UpdateBtn(bool isInit = false)
	{
		if (DimObject != null) DimObject.SetActive(false);
		if (ReddotObject != null) ReddotObject.SetActive(false);
	}

	private void OnClickReward()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void SetPriceText(int shopIdx)
	{
		if (CashText != null) CashText.text = "";
	}

	public void HideAllBubble()
	{
		if (infoBubbles != null)
		{
			for (int i = 0; i < infoBubbles.Length; i++)
			{
				if (infoBubbles[i] != null)
					infoBubbles[i].SetActive(false);
			}
		}
	}
}
