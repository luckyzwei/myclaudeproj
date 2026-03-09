using System;
using Balancy.API.Payments;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StrikeOutPurchaseButton : MonoBehaviour
{
	private const string ANIM_ANIM_JIGSAWIAPPRICE_EXIT_01 = "Anim-JigsawIAPPrice-Exit-01";

	private const string ANIM_ANIM_JIGSAWIAPPRICE_ENTER_01 = "Anim-JigsawIAPPrice-Enter-01";

	private const string ANIM_ANIM_JIGSAWIAPPRICE_IDLE_01 = "Anim-JigsawIAPPrice-Idle-01";

	private const string ANIM_ANIM_JIGSAWCOLLECT_ENABLED_01 = "Anim-JigsawCollect-Enabled-01";

	[SerializeField]
	private TextMeshProUGUI m_iapPriceTMP;

	[SerializeField]
	private AnimatorHelper m_strikeAnimatorHelper;

	[SerializeField]
	private Button m_button;

	[SerializeField]
	private GameObject m_rewardAdBlocker;

	[SerializeField]
	private AnimatorHelper m_buttonAnimatorHelper;

	private string m_productId;

	private Action m_successCallback;

	public void Configure(string productId, Action successCallback)
	{
	}

	public void ConfigureNewPrice(string productId)
	{
	}

	private void TryPurchaseIap()
	{
	}

	private void PurchaseFinished(PurchaseProductResponseData responseData)
	{
	}

	public void EnableButton()
	{
	}
}
