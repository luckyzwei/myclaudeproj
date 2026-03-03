using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemWorkshopProductInfoBox : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInitVisibility_Delay_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemWorkshopProductInfoBox _003C_003E4__this;

		public bool bShow;

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
		public _003CInitVisibility_Delay_003Ed__24(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CPopupFocusToProduct_Delay_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBase popupMenu;

		public ItemWorkshopProductInfoBox _003C_003E4__this;

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
		public _003CPopupFocusToProduct_Delay_003Ed__30(int _003C_003E1__state)
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
	private GameObject RootObj;

	[SerializeField]
	private Image WorkshopProductIcon;

	[SerializeField]
	private Text ProductHasValueText;

	[SerializeField]
	private GameObject ProductHasValueRedDot;

	[SerializeField]
	private Image DistributorIcon;

	[SerializeField]
	private Text ProductOnceDistributeValueText;

	[SerializeField]
	private Button DistributorShortcutBtn;

	[SerializeField]
	private GameObject DistributorNoticeGreenDot;

	[SerializeField]
	private Button BoxVisibilityToggleBtn;

	[SerializeField]
	private Animator BoxAnimator;

	private static readonly string ANIM_STATE_IDLE;

	private static readonly string ANIM_STATE_SHOW;

	private static readonly string ANIM_STATE_HIDE;

	private int WorkshopIdx;

	private int ProductIdx;

	private BigInteger OnceDistributeValue_PerMile;

	private CompositeDisposable Disposables;

	public bool bShowState { get; private set; }

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(int workshopIdx, bool bShow)
	{
	}

	[IteratorStateMachine(typeof(_003CInitVisibility_Delay_003Ed__24))]
	private IEnumerator InitVisibility_Delay(bool bShow)
	{
		return null;
	}

	private void UpdateHasProductValue(BigInteger hasValue_PerMile)
	{
	}

	private void SetWorkshopProductIcon(string iconKey)
	{
	}

	private void SetProductHasValueText(BigInteger hasValue_PerMile)
	{
	}

	private void SetProductOnceDistributeValueText(BigInteger distributeValue_PerMile)
	{
	}

	private void OnClickedDistributorShortcutBtn()
	{
	}

	[IteratorStateMachine(typeof(_003CPopupFocusToProduct_Delay_003Ed__30))]
	private IEnumerator PopupFocusToProduct_Delay(UIBase popupMenu)
	{
		return null;
	}

	private void OnClickedBoxVisibilityToggleBtn()
	{
	}

	public void SetVisibility(bool bVisible, bool bPlayAnim)
	{
	}
}
