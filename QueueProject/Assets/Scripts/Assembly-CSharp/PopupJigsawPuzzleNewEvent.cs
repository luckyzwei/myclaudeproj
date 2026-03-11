using KWCore.UI;
using UnityEngine.UI;
using UnityEngine;

public class PopupJigsawPuzzleNewEvent : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-PuzzleCollection-EventStart";

	[SerializeField]
	private Text m_eventName;

	public void Config(string eventName)
	{
	}
}
