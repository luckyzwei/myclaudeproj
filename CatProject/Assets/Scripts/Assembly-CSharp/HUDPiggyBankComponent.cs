using UnityEngine;
using UnityEngine.UI;

public class HUDPiggyBankComponent : MonoBehaviour
{
	[Header("PiggyBank")]
	[SerializeField]
	private Button PiggyBtn;

	[SerializeField]
	private Text PiggyCount;

	[SerializeField]
	private Image PiggyIcon;

	[SerializeField]
	private GameObject PiggyReddot;

	[SerializeField]
	private DoTweenScriptComponent PiggyTween;

	[SerializeField]
	private GameObject ParentsObj;

	private void Awake()
	{
		if (PiggyBtn != null) PiggyBtn.onClick.AddListener(OnClickPiggyBankBtn);
	}

	private void OnDestroy()
	{
		// Cleanup
	}

	public void SetPiggyBank()
	{
		UpdatePiggyValue();
	}

	public void UpdatePiggyValue()
	{
		// Update display
	}

	private void OnClickPiggyBankBtn()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupAdsSupply>();
	}
}
