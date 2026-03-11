using System.Collections.Generic;
using KWGameCore;
using UnityEngine.UI;
using UnityEngine;

public class JigsawBalancyTest : MonoBehaviour
{
	[SerializeField]
	private InputField m_clientIDInputField;

	[SerializeField]
	private JigsawButton m_buttonPrefab;

	[SerializeField]
	private Transform m_buttonsGrid;

	private Pool<JigsawButton> m_buttonPool;

	private List<JigsawButton> m_activeButtons;

	private void Awake()
	{
	}

	public void LoadButtonClicked()
	{
	}

	private void OnButtonClick(JigsawButton button)
	{
	}
}
