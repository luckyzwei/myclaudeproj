using UnityEngine;

public class NightSkipVIP : MonoBehaviour
{
	[SerializeField]
	private Animator CharAni;

	public void Show()
	{
		gameObject.SetActive(true);
		if (CharAni != null)
			CharAni.SetTrigger("Show");
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}

	public void OnClickVIP()
	{
		// Handle click
	}
}
