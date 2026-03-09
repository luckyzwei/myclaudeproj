using KWCore.UI;
using UnityEngine;

public class PopUpSpinWheel : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/KWSpinWheel/Popup-SpinWheel";

	[SerializeField]
	private GameObject[] m_visibleCloseButtons;

	private bool m_isClosingAllowed;

	private void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnSpinStarted()
	{
	}

	private void OnSpinCompleted()
	{
	}

	public new void Close(bool playAudio)
	{
	}

	public new void OnClosedPopUpPressed()
	{
	}

	private void ClosePopup()
	{
	}
}
