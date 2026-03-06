using UnityEngine;

public class Roulette : MonoBehaviour
{
	private bool isOpen;

	private void Awake()
	{
		isOpen = false;
	}

	private void SetRoulette()
	{
		isOpen = true;
	}

	private void OnDestroy()
	{
		isOpen = false;
	}

	public void OnClickRoulette()
	{
		if (!isOpen) return;
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRatioInfo>();
	}
}
