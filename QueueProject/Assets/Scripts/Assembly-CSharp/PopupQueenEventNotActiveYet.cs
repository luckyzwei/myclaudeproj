using System;
using KWCore.UI;
using UnityEngine.UI;
using UnityEngine;

public class PopupQueenEventNotActiveYet : PopUpBase
{
	private const string PREFAB_NAME = "Prefabs/Popups/PopUp-QueenEventNotActiveYet";

	private const string PREFAB_NAME_SKINS = "Prefabs/Popups/PopUp-QueenEventNotActiveYet-SkinsVariant";

	[SerializeField]
	private Text m_skinsUnlockText;

	[SerializeField]
	private string m_unlockTextFormatKey;

	[SerializeField]
	private GameObject m_schedule;

	[SerializeField]
	protected GameObject m_countDownTimer;

	public static PopupQueenEventNotActiveYet Show(bool skins = false, Action onClose = null)
	{
		return null;
	}

	public void Config()
	{
	}

	private int TimeLeft()
	{
		return 0;
	}

	private void Update()
	{
	}

	public void ShowInfoPopup()
	{
	}
}
