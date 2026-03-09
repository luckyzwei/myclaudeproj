using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.SmartObjects;

public class PvpRewardWidget : QueensRewardWidget
{
	[CompilerGenerated]
	private sealed class _003CShowRewardsCoroutine_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PvpRewardWidget _003C_003E4__this;

		private List<ItemWithAmountCell>.Enumerator _003C_003E7__wrap1;

		private ItemWithAmountCell _003CitemWithAmountCell_003E5__3;

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
		public _003CShowRewardsCoroutine_003Ed__2(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public override void Configure(Reward price)
	{
	}

	public void ShowRewards()
	{
	}

	[IteratorStateMachine(typeof(_003CShowRewardsCoroutine_003Ed__2))]
	private IEnumerator ShowRewardsCoroutine()
	{
		return null;
	}
}
