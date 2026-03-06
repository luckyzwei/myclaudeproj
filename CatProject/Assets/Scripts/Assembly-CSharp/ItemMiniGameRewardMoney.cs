using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ItemMiniGameRewardMoney : MonoBehaviour
{
	[SerializeField]
	private GameObject MoneyRoot;

	[SerializeField]
	private List<ParticleSystemRenderer> MoneyParticleRenderers;

	[SerializeField]
	private Text RewardCountText;

	private Action OnEndAction;

	private Sequence PlayedDotSeq;

	private int LoadCount;

	public void Set(BigInteger currencyCount, Vector3 worldStartPos, Vector3 worldEndPos, Action OnEnd = null)
	{
		OnEndAction = OnEnd;
		if (RewardCountText != null)
			RewardCountText.text = "+" + ProjectUtility.GetThousandCommaText(currencyCount);
		if (MoneyRoot != null) MoneyRoot.SetActive(true);
		InitPos(MoneyRoot);
		PlaySeq(worldEndPos);
	}

	private void InitPos(GameObject targetObj)
	{
		if (targetObj != null)
			targetObj.transform.localPosition = Vector3.zero;
	}

	private void PlaySeq(Vector3 worldEndPos)
	{
		if (MoneyRoot == null) return;
		PlayedDotSeq = DOTween.Sequence();
		PlayedDotSeq.Append(MoneyRoot.transform.DOMove(worldEndPos, 0.5f));
		PlayedDotSeq.OnComplete(() =>
		{
			if (MoneyRoot != null) MoneyRoot.SetActive(false);
			OnEndAction?.Invoke();
		});
	}

	private void OnDestroy()
	{
		if (PlayedDotSeq != null) { PlayedDotSeq.Kill(); PlayedDotSeq = null; }
	}
}
