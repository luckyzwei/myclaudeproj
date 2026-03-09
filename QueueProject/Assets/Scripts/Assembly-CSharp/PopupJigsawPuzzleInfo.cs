using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupJigsawPuzzleInfo : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-PuzzleCollection-Info";

	[SerializeField]
	private TMP_Text m_seasonName;

	[SerializeField]
	private Image m_titleImage;

	public void Config(string clientId)
	{
	}
}
