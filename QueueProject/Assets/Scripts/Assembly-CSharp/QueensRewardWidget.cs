using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using UnityEngine;

public class QueensRewardWidget : RewardWidget
{
	[CompilerGenerated]
	private sealed class _003CDoubleRewardCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QueensRewardWidget _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDoubleRewardCoroutine_003Ed__12(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Banner Section")]
	[SerializeField]
	private ItemWithAmountCell m_bannerItemWithAmountPrefab;

	[SerializeField]
	private Transform m_bannerRewardLayout;

	private Action m_doubleRewardCallback;

	protected List<ItemWithAmountCell> m_itemCells;

	[Header("Double Reward Animation")]
	[SerializeField]
	private float m_startDelay;

	[SerializeField]
	private float m_tallyDuration;

	[SerializeField]
	private float m_scaleUpAmount;

	[SerializeField]
	private float m_delayBeforeExplosion;

	private Dictionary<ItemWithAmountCell, int> m_originalAmounts;

	public override void Configure(Reward price)
	{
	}

	public override void Configure(Dictionary<KwaleeItem, int> rewards)
	{
	}

	public void DoubleReward(Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CDoubleRewardCoroutine_003Ed__12))]
	private IEnumerator DoubleRewardCoroutine()
	{
		return null;
	}

	private int GetCurrentAmount(ItemWithAmountCell cell)
	{
		return 0;
	}

	public override void AddItem(ItemWithAmount itemToAdd)
	{
	}
}
