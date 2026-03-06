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
		SetDir(arrayDir.Bottom);
	}

	public void SetDir(arrayDir i)
	{
		if (arrays == null) return;
		for (int idx = 0; idx < arrays.Length; idx++)
			if (arrays[idx] != null) arrays[idx].SetActive(idx == (int)i);
	}
}
