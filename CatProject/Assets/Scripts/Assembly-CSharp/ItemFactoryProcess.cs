using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ItemFactoryProcess : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckInput_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemFactoryProcess _003C_003E4__this;

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
		public _003CCheckInput_003Ed__5(int _003C_003E1__state)
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

	[SerializeField]
	private List<ItemFactoryProcessProduct> Products;

	[SerializeField]
	private List<ItemFactoryProcessLine> MakeLines;

	[SerializeField]
	private ScrollRect ScrollRect;

	public void Set(Config.FactoryType type)
	{
	}

	public void ShowFocusObj(List<int> productIdxList, bool bShow)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckInput_003Ed__5))]
	private IEnumerator CheckInput()
	{
		yield break;
	}
}
