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
		if (bannerBtn != null)
			bannerBtn.onClick.AddListener(OnClickBtn);
	}

	public void Init(int targetLevel)
	{
		isReady = targetLevel <= 0;
		if (LevelRootObj != null)
			LevelRootObj.SetActive(!isReady);
		if (GotoNextObj != null)
			GotoNextObj.SetActive(isReady);
		if (levelText != null)
			levelText.text = targetLevel.ToString();
	}

	public void OnClickBtn()
	{
		if (!isReady) return;
	}
}
