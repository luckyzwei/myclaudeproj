using System;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyHUDComponent : MonoBehaviour
{
	[SerializeField]
	private Text CurrencyText;

	[SerializeField]
	private Image CurrencyIconImage;

	[SerializeField]
	private Button ShortCutBtn;

	public Action OnClickShortcutAction;

	private void Awake()
	{
		if (ShortCutBtn != null)
			ShortCutBtn.onClick.AddListener(OnClickShortcut);
	}

	public void Init(Config.AtlasType atlasType, string iconPath, string valueText, bool bUseShortCut)
	{
		if (CurrencyText != null)
			CurrencyText.text = valueText;
		SetActiveShortCutBtn(bUseShortCut);
	}

	public void SetCurrencyIcon(Sprite icon)
	{
		if (CurrencyIconImage != null)
			CurrencyIconImage.sprite = icon;
	}

	public void SetValueText(string valueText)
	{
		if (CurrencyText != null)
			CurrencyText.text = valueText;
	}

	public Transform GetCurrencyEffectEndTransform()
	{
		if (CurrencyIconImage != null)
			return CurrencyIconImage.transform;
		return transform;
	}

	public void SetActiveShortCutBtn(bool bActive)
	{
		if (ShortCutBtn != null)
			ShortCutBtn.gameObject.SetActive(bActive);
	}

	private void OnClickShortcut()
	{
		OnClickShortcutAction?.Invoke();
	}
}
