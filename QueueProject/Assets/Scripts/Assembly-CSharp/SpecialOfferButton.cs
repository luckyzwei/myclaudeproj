using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class SpecialOfferButton : MonoBehaviour
{
	[SerializeField]
	private Button m_button;

	[SerializeField]
	private GameObject[] m_effects;

	[SerializeField]
	private string m_source;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void CoreEvents_PopupClosed(PopUpBase popUpBase)
	{
	}

	private void Start()
	{
	}

	private void OnButtonPressed()
	{
	}

	private void SetActive(bool value)
	{
	}
}
