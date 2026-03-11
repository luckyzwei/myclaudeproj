using UnityEngine;
using UnityEngine.UI;

public class PlayButtonController : MonoBehaviour
{
	private const string LEVEL_FORMAT_KEY = "HomeScreen.LevelX";

	[SerializeField]
	private Button[] m_buttons;

	[SerializeField]
	private Text[] m_texts;

	private void Start()
	{
	}

	public void ActivatePlayButton(bool value)
	{
	}
}
