using Balancy.Models.Inventory;
using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine.UI;
using UnityEngine;

public class BoosterUnlockPopUp : PopUpBase
{
	private const string ANIM_BOOSTERUNLOCK_INTRO = "BoosterUnlock-Intro";

	private const string ANIM_BOOSTERUNLOCK_OUTRO = "BoosterUnlock-Outro";

	public const string PREFAB_NAME = "Prefabs/Popups/Popup-BoosterUnlock";

	[SerializeField]
	private Text m_boosterName;

	[SerializeField]
	private Text m_boosterDescription;

	[SerializeField]
	private ItemWithAmountCell m_itemWithAmountCell;

	private new AnimatorHelper m_animatorHelper;

	private ItemWithAmount m_itemWithAmount;

	private bool m_hasClaimed;

	public void Config(BoosterItem boosterItem)
	{
	}

	public void Claim()
	{
	}
}
