using UnityEngine;
using UnityEngine.UI;

public class EditPlayerNameButton : MonoBehaviour
{
	[SerializeField]
	private Button m_button;

	[SerializeField]
	private string m_location;

	private PopupPlayerProfileEdit m_popup;

	private void Awake()
	{
	}

	private void OnButtonClicked()
	{
	}
}
