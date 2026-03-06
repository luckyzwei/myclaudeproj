using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		OnEndAction = OnEnd;
		transform.position = worldStartPos;

		// Hide all items first
		if (GemItem != null) GemItem.SetActive(false);
		if (MoneyItems != null)
			for (int i = 0; i < MoneyItems.Count; i++)
				if (MoneyItems[i] != null) MoneyItems[i].SetActive(false);
		if (MaterialItem != null) MaterialItem.SetActive(false);
		if (TicketItem != null) TicketItem.SetActive(false);

		if (RewardCount != null) RewardCount.text = currencyCount.ToString();

		// Select target based on currencyID
		GameObject targetObj = null;
		// Use simple ID mapping: 0=money, 1=gem, 2=material, 3=ticket
		switch (currencyID)
		{
			case 1:
				targetObj = GemItem;
				break;
			case 2:
				targetObj = MaterialItem;
				break;
			case 3:
				targetObj = TicketItem;
				break;
			default:
				if (MoneyItems != null && MoneyItems.Count > 0)
					targetObj = MoneyItems[0];
				break;
		}

		if (targetObj != null)
		{
			targetObj.SetActive(true);
			InitPos(targetObj);

			PlayedDotSeq = DOTween.Sequence();
			PlayedDotSeq.AppendInterval(delay);
			PlayedDotSeq.Append(targetObj.transform.DOMove(worldEndPos, 0.5f).SetEase(Ease.InOutQuad));
			PlayedDotSeq.AppendCallback(() =>
			{
				OnEndAction?.Invoke();
				Destroy(gameObject);
			});
		}
	}

	private void InitPos(GameObject targetObj)
	{
		if (targetObj != null)
			targetObj.transform.position = transform.position;
	}

	private void OnDestroy()
	{
		if (PlayedDotSeq != null && PlayedDotSeq.IsActive())
		{
			PlayedDotSeq.Kill();
			PlayedDotSeq = null;
		}
	}
}
