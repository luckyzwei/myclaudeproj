using UnityEngine;
using UnityEngine.UI;

public class ItemBannerNextRegion : MonoBehaviour
{
	[SerializeField]
	private Button bannerBtn;

	[SerializeField]
	private GameObject LevelRootObj;

	[SerializeField]
	private GameObject GotoNextObj;

	[SerializeField]
	private Text levelText;

	private bool isReady;

	private void Awake()
	{
	}

	public void Init(int targetLevel)
	{
	}

	public void OnClickBtn()
	{
	}
}
