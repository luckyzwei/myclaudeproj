using UnityEngine;

public class EnableByGameMode : MonoBehaviour
{
	[SerializeField]
	private GameType targetType;

	[SerializeField]
	private bool reverse;

	private void Awake()
	{
	}
}
