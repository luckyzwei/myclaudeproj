using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RewardProgress : MonoBehaviour
{
	private enum ProgressType
	{
		None = 0,
		Gem = 1,
		NormalKey = 2,
		PremiumKey = 3
	}

	[Header("RewardProgress")]
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private RectTransform LayOutRect;

	[Space(5f)]
	[SerializeField]
	private Slider ProgresSlider;

	[SerializeField]
	private Image ProgressIcon;

	[SerializeField]
	private Text ProgressText;

	[SerializeField]
	private GameObject HitObj;

	[Space(5f)]
	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardText;

	[Header("Value")]
	[SerializeField]
	private float padding;

	[SerializeField]
	private float progressTime;

	[SerializeField]
	private float hideTime;

	private ProgressType curType;

	private Vector3 iconPos;

	private int needValue;

	private int rewardValue;

	private Sequence CurSeq;

	private void Awake()
	{
	}

	public Vector3 GetProgressIconPos()
	{
		return default(Vector3);
	}

	private void SetNormalKeyToBox()
	{
	}

	private void SetPremiumKeyToBox()
	{
	}

	public void ShowKeyProgress(int keyIdx, int gainKey, Action goodsEffect = null)
	{
	}
}
