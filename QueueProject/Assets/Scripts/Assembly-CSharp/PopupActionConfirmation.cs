using System;
using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupActionConfirmation : PopUpBase
{
	private const string PREFAB_NAME = "Prefabs/KWPlayerProfile/Popup-ProfileView";

	[SerializeField]
	private TMP_Text m_descriptionText;

	[SerializeField]
	private Button m_confirmButton;

	[SerializeField]
	private Button m_denyButton;

	[SerializeField]
	private Button m_closeButton;

	private Action m_onConfrimPressed;

	private Action m_onDenyPressed;

	private void Awake()
	{
	}

	private void OnDenyPressed()
	{
	}

	private void OnConfirmPressed()
	{
	}

	public void Config(string description, Action confirmCallback, Action denyCallback)
	{
	}
}
