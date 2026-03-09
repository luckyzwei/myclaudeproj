using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JigsawButton : MonoBehaviour
{
	public delegate void ButtonClickedDelegate(JigsawButton button);

	[SerializeField]
	private TMP_Text m_text;

	[SerializeField]
	private Image m_image;

	private string m_clientID;

	private int m_index;

	private int m_value;

	private static Color[] s_colors;

	public string ClientID => null;

	public int Index => 0;

	public int Value => 0;

	public event ButtonClickedDelegate ButtonClicked
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

	private void Awake()
	{
	}

	private void OnButtonClicked()
	{
	}

	public void Config(string clientID, int index)
	{
	}

	public void SetValue(int value)
	{
	}

	public void ClearEvent()
	{
	}
}
