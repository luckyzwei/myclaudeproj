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
		if (ProgressIcon != null)
			iconPos = ProgressIcon.transform.position;
		curType = ProgressType.None;
	}

	public Vector3 GetProgressIconPos()
	{
		if (ProgressIcon != null)
			return ProgressIcon.transform.position;
		return iconPos;
	}

	private void SetNormalKeyToBox()
	{
		curType = ProgressType.NormalKey;
		if (ProgressIcon != null)
			ProgressIcon.gameObject.SetActive(true);
	}

	private void SetPremiumKeyToBox()
	{
		curType = ProgressType.PremiumKey;
		if (ProgressIcon != null)
			ProgressIcon.gameObject.SetActive(true);
	}

	public void ShowKeyProgress(int keyIdx, int gainKey, Action goodsEffect = null)
	{
		if (keyIdx == 0)
			SetNormalKeyToBox();
		else
			SetPremiumKeyToBox();

		needValue = gainKey;
		if (ProgresSlider != null)
			ProgresSlider.value = 0f;
		if (ProgressText != null)
			ProgressText.text = "0/" + needValue;

		if (HitObj != null)
			HitObj.SetActive(true);

		if (CurSeq != null)
		{
			CurSeq.Kill();
			CurSeq = null;
		}
		CurSeq = DOTween.Sequence();
		CurSeq.Append(DOTween.To(() => 0f, (v) =>
		{
			if (ProgresSlider != null) ProgresSlider.value = v;
		}, 1f, progressTime));
		CurSeq.AppendCallback(() =>
		{
			goodsEffect?.Invoke();
		});
		CurSeq.AppendInterval(hideTime);
		CurSeq.AppendCallback(() =>
		{
			if (HitObj != null) HitObj.SetActive(false);
		});
	}
}
