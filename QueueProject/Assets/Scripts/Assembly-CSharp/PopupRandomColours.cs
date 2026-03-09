using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupRandomColours : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/PopUps/Popup-RandomColours";

	[SerializeField]
	private Toggle m_toggle;

	[SerializeField]
	private TMP_InputField m_inputField;

	private void Awake()
	{
	}

	private void UseRndValueChanged(bool value)
	{
	}

	private void SeedChanged(string value)
	{
	}

	public void AddSeed(int step)
	{
	}

	private void RefreshColours()
	{
	}
}
