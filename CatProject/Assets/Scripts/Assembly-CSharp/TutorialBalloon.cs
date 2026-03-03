using UnityEngine;

public class TutorialBalloon : MonoBehaviour
{
	public enum arrayDir
	{
		Bottom = 0,
		Top = 1
	}

	[SerializeField]
	private GameObject[] arrays;

	private void Awake()
	{
	}

	public void SetDir(arrayDir i)
	{
	}
}
