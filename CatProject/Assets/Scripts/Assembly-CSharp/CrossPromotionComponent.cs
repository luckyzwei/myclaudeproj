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
	}

	public void Set(int idx, SpriteAtlas spriteAtlas, bool reward, string channel, string appName, Action onReward)
	{
	}

	public void SetRewardIcon(Sprite sprite)
	{
	}

	private void OnClick()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void GenerateUserInviteLink(string origin, string templete_id, string channel, string app_name)
	{
	}
}
