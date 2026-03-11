using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using UnityEngine;
using UnityEngine.UI;

public class ItemWithAmountCell : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoTallyAnimation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemWithAmountCell _003C_003E4__this;

		public string format;

		public int targetAmount;

		private float _003Ctimer_003E5__2;

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
		public _003CDoTallyAnimation_003Ed__22(int _003C_003E1__state)
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

	private const string DEFAULT_AMOUNT_FORMAT = "{0}";

	[SerializeField]
	private Image m_icon;

	[SerializeField]
	protected Text m_amount;

	[SerializeField]
	private bool m_displayAmount;

	[SerializeField]
	private bool m_showAmountIfMaxStack1;

	[SerializeField]
	private bool m_showNameIfValue1;

	[SerializeField]
	protected bool m_displayDigitSpace;

	[SerializeField]
	private bool m_useShopFormat;

	[Header("Effects")]
	[SerializeField]
	protected bool m_tallyAmount;

	[SerializeField]
	protected float m_tallyTime;

	[SerializeField]
	protected float m_delayTallyTime;

	private KwaleeItem m_storedItem;

	private Coroutine m_tallyCoroutine;

	private bool m_tryTally;

	private int m_amountValue;

	private static readonly NumberFormatInfo DigitSpaceFormat;

	public KwaleeItem StoredItem => null;

	public void Initialise(ItemWithAmount itemWithAmount)
	{
	}

	public void Initialise(Item item, int amount)
	{
	}

	protected virtual void Initialise(KwaleeItem kwaleeItem, int amount)
	{
	}

	protected virtual void HandleAmountDisplay(int amount, KwaleeItem kwaleeItem)
	{
	}

	protected void SetUI(int amount, KwaleeItem kwaleeItem)
	{
	}

	[IteratorStateMachine(typeof(_003CDoTallyAnimation_003Ed__22))]
	private IEnumerator DoTallyAnimation(int targetAmount, string format)
	{
		return null;
	}

	protected string GetAmountText(string format, int amount, bool digitSpace)
	{
		return null;
	}

	private void OnEnable()
	{
	}
}
