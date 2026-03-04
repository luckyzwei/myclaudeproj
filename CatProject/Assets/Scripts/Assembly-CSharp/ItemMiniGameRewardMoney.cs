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
	}

	private void InitPos(GameObject targetObj)
	{
	}

	private void PlaySeq(Vector3 worldEndPos)
	{
	}

	private void OnDestroy()
	{
	}
}
