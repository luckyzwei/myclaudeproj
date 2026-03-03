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
	}

	public void Init(Config.AtlasType atlasType, string iconPath, string valueText, bool bUseShortCut)
	{
	}

	public void SetCurrencyIcon(Sprite icon)
	{
	}

	public void SetValueText(string valueText)
	{
	}

	public Transform GetCurrencyEffectEndTransform()
	{
		return null;
	}

	public void SetActiveShortCutBtn(bool bActive)
	{
	}

	private void OnClickShortcut()
	{
	}
}
