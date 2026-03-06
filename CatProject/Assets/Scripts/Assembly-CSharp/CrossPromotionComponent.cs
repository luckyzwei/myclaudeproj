using System;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class CrossPromotionComponent : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI tmpTextDesc;

	[SerializeField]
	private Text textDesc;

	[SerializeField]
	private Image imgIcon;

	[SerializeField]
	private Image imgBG;

	[SerializeField]
	private Button btn;

	[SerializeField]
	private GameObject objReward;

	[SerializeField]
	private Image rewardIcon;

	private string url;

	private bool isReward;

	private bool openUrl;

	private Action OnReward;

	private void Awake()
	{
		if (btn != null) btn.onClick.AddListener(OnClick);
	}

	public void Set(int idx, SpriteAtlas spriteAtlas, bool reward, string channel, string appName, Action onReward)
	{
		isReward = reward;
		OnReward = onReward;
		openUrl = false;
		if (objReward != null) objReward.SetActive(reward);
	}

	public void SetRewardIcon(Sprite sprite)
	{
		if (rewardIcon != null && sprite != null) rewardIcon.sprite = sprite;
	}

	private void OnClick()
	{
		openUrl = true;
		if (!string.IsNullOrEmpty(url))
			Application.OpenURL(url);
	}

	private void OnApplicationPause(bool pause)
	{
		if (!pause && openUrl)
		{
			openUrl = false;
			if (isReward) OnReward?.Invoke();
		}
	}

	private void GenerateUserInviteLink(string origin, string templete_id, string channel, string app_name)
	{
	}
}
