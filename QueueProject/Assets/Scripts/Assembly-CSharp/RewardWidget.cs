using System.Collections.Generic;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using UnityEngine;

public class RewardWidget : MonoBehaviour
{
	[SerializeField]
	protected Transform m_layout;

	[SerializeField]
	protected ItemWithAmountCell m_ItemWithAmountCellPrefab;

	[Header("Optional")]
	[SerializeField]
	protected GameObject m_plusPrefab;

	protected GameObject m_plus;

	public virtual void Configure(Reward price)
	{
	}

	public virtual void SpawnCell(ItemWithAmountCell container)
	{
	}

	public virtual void AddItem(ItemWithAmount itemToAdd)
	{
	}

	public virtual void Configure(Dictionary<KwaleeItem, int> rewards)
	{
	}
}
