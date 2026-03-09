using KWCore.UI;
using TMPro;
using UnityEngine;

public class PopupJigsawPuzzleNewEvent : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-PuzzleCollection-EventStart";

	[SerializeField]
	private TextMeshProUGUI m_eventName;

	public void Config(string eventName)
	{
	}
}
