using UnityEngine;

public class GameModeActivator : MonoBehaviour
{
	[SerializeField]
	private GameManager.GameMode[] m_gameModes;

	[SerializeField]
	private bool m_value;

	private void Awake()
	{
	}
}
