using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;

public class LockInputPopup : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-LockInputOverlay";

	[SerializeField]
	private GameObject m_background;

	public event GameplayEvents.BasicDelegate ButtonClicked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Config(bool showGraphics)
	{
	}

	public void OnButtonClick()
	{
	}
}
