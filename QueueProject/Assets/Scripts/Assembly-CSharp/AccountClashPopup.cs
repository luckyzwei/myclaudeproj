using System;
using KWCore.UI;
using UnityEngine.UI;
using UnityEngine;

public class AccountClashPopup : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-AccountClash";

	[SerializeField]
	private Text m_contentText;

	[TextLookup(null, true)]
	[SerializeField]
	private string m_localissedContent;

	private NakamaSocialLogin.HandleAccountClashResultDelegate m_resultCallback;

	public static Action SwappedAccount;

	public void Initialise(NakamaSocialLogin.HandleAccountClashResultDelegate resultCallback, string name)
	{
	}

	public void OnTakeCurrentPressed()
	{
	}

	public void OnTakeOtherPressed()
	{
	}
}
