using UnityEngine;
using UnityEngine.UI;

public class ControlSchemeSelector : MonoBehaviour
{
	[SerializeField]
	private Button m_prevControlSchemeButton;

	[SerializeField]
	private Button m_nextControlSchemeButton;

	[SerializeField]
	private Text m_controlSchemeLabel;

	[SerializeField]
	private Transform m_root;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void InitControlSchemeSelector()
	{
	}

	private void RefreshControlSchemeLabel()
	{
	}

	private void OnPrevControlSchemeClicked()
	{
	}

	private void OnNextControlSchemeClicked()
	{
	}

	private void ChangeControlScheme(int delta)
	{
	}

	private void ApplyControlSchemeSelection(int index)
	{
	}

	private static string GetControlSchemeDisplayText(string schemeName)
	{
		return null;
	}
}
