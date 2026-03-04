using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using System.Runtime.CompilerServices;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemMissionFactoryTab : MonoBehaviour, ITabToggleTab
{
	[CompilerGenerated]
	private sealed class _003CFocusOrderSlot_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemMissionFactoryTab _003C_003E4__this;

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
		public _003CFocusOrderSlot_003Ed__26(int _003C_003E1__state)
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

	[Header("SelectOrder")]
	[SerializeField]
	private Image OrderIcon;

	[SerializeField]
	private Text OrderItemName;

	[SerializeField]
	private Text OrderCount;

	[SerializeField]
	private Text OrderReward;

	[SerializeField]
	private Button OrderCompBtn;

	[SerializeField]
	private Button OrderResetBtn;

	[SerializeField]
	private GameObject OrderWaitObj;

	[SerializeField]
	private GameObject OrderInfoObj;

	[SerializeField]
	private Button ProductShortCutBtn;

	[SerializeField]
	private GameObject OrderCompRedDotObj;

	[Header("Character")]
	[SerializeField]
	private Image OrderCharacterIcon;

	[SerializeField]
	private Text OrderCharacterTalkText;

	[Header("List")]
	[SerializeField]
	private ScrollRect SlotScrollRect;

	[SerializeField]
	private List<ItemFactoryOrder> OrderSlots;

	[Space(5f)]
	[Header("Missions")]
	[SerializeField]
	private List<ItemMission> MissionItems;

	[SerializeField]
	private GameObject MissionListObj;

	[SerializeField]
	private GameObject MissionAllDoneObj;

	[SerializeField]
	private Button FactoryShortCutBtn;

	private int SelectOrder;

	private Action OnGotoNavi;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	public void InitTab(Action onGotoNavi)
	{
	}

	private void InitOrderList()
	{
	}

	private void SetMissionList()
	{
	}

	private void ShowNextOrder()
	{
	}

	[IteratorStateMachine(typeof(_003CFocusOrderSlot_003Ed__26))]
	private IEnumerator FocusOrderSlot()
	{
		yield break;
	}

	private void UpdateOrder()
	{
	}

	private void UpdateSelect()
	{
	}

	public void RefreshSlot()
	{
	}

	private void OnClickSelect(int slot)
	{
	}

	private void OnClickCompOrder()
	{
	}

	private void OnClickResetOrder()
	{
	}

	private void OnClickFactoryShortCut()
	{
	}

	private void OnClickProductShortCut()
	{
	}

	private void OnClickMissionShortCut(int slot)
	{
	}

	private void GetFactoryMissionReward(int rewardType, int rewardIdx, BigInteger rewardCnt, bool isDoubleReward)
	{
	}

	public void Refresh()
	{
	}

	public void Reset()
	{
	}
}
