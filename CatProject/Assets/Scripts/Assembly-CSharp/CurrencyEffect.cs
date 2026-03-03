using System;
using System.Collections.Generic;
using System.Numerics;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyEffect : MonoBehaviour
{
	[SerializeField]
	private GameObject GemItem;

	[SerializeField]
	private List<GameObject> MoneyItems;

	[SerializeField]
	private GameObject MaterialItem;

	[SerializeField]
	private GameObject TicketItem;

	[SerializeField]
	private Text RewardCount;

	private Sequence PlayedDotSeq;

	private Action OnEndAction;

	public void Set(int currencyID, BigInteger currencyCount, Vector3 worldStartPos, Vector3 worldEndPos, Action OnEnd = null, float delay = 0f)
	{
	}

	private void InitPos(GameObject targetObj)
	{
	}

	private void OnDestroy()
	{
	}
}
