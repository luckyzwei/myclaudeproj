using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopupJigsawEventStart : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-NewJigsawEvent";

	[SerializeField]
	private Text m_eventName;

	[SerializeField]
	private Image m_image;

	[SerializeField]
	private RewardWidget m_rewardWidget;

	public void Config(string eventClientId, string eventName, Reward joiningReward)
	{
	}

	public void OnButtonPressed()
	{
	}
}
