using UnityEngine;
using UnityEngine.UI;

public class BoxOpenNotiObj : MonoBehaviour
{
	[SerializeField]
	private Image BoxImg;

	private string passSpriteName;

	private int curIdx;

	private void Awake()
	{
		curIdx = 0;
		CheckOpenBoxCount();
	}

	private void CheckOpenBoxCount()
	{
	}

	private void OnChangeOpenBox(int idx)
	{
		curIdx = idx;
		CheckOpenBoxCount();
	}
}
