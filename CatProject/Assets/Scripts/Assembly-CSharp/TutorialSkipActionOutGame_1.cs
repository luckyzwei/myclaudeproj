using UnityEngine;

public class TutorialSkipActionOutGame_1 : MonoBehaviour
{
	[SerializeField]
	private TutorialMap map;

	protected void Awake()
	{
		// Initialize skip action references
	}

	protected void Skip()
	{
		if (map != null) map.SkipTutorial();
	}
}
