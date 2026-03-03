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
	}

	public void SetRewards(int order, bool isSpecial = false)
	{
	}

	public void UpdateBtn(bool isInit = false)
	{
	}

	private void OnClickReward()
	{
	}

	private void SetPriceText(int shopIdx)
	{
	}

	public void HideAllBubble()
	{
	}
}
