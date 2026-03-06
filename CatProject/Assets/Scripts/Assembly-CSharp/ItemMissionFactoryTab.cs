using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using System.Runtime.CompilerServices;
using Treeplla;
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
		Disposables = new CompositeDisposable();
		if (OrderCompBtn != null) OrderCompBtn.onClick.AddListener(OnClickCompOrder);
		if (OrderResetBtn != null) OrderResetBtn.onClick.AddListener(OnClickResetOrder);
		if (FactoryShortCutBtn != null) FactoryShortCutBtn.onClick.AddListener(OnClickFactoryShortCut);
		if (ProductShortCutBtn != null) ProductShortCutBtn.onClick.AddListener(OnClickProductShortCut);
	}

	public void InitTab(Action onGotoNavi)
	{
		OnGotoNavi = onGotoNavi;
		SelectOrder = 0;
		InitOrderList();
		SetMissionList();
		UpdateSelect();
	}

	private void InitOrderList()
	{
		if (OrderSlots == null) return;
		for (int i = 0; i < OrderSlots.Count; i++)
		{
			int slotIdx = i;
			if (OrderSlots[i] != null)
			{
				// Bind slot click callback
			}
		}
	}

	private void SetMissionList()
	{
		if (MissionItems == null || MissionListObj == null) return;
		bool hasActiveMission = false;
		for (int i = 0; i < MissionItems.Count; i++)
		{
			if (MissionItems[i] != null && MissionItems[i].gameObject.activeSelf)
				hasActiveMission = true;
		}
		MissionListObj.SetActive(hasActiveMission);
		if (MissionAllDoneObj != null) MissionAllDoneObj.SetActive(!hasActiveMission);
	}

	private void ShowNextOrder()
	{
		if (OrderSlots == null || OrderSlots.Count == 0) return;
		int nextSlot = (SelectOrder + 1) % OrderSlots.Count;
		OnClickSelect(nextSlot);
	}

	[IteratorStateMachine(typeof(_003CFocusOrderSlot_003Ed__26))]
	private IEnumerator FocusOrderSlot()
	{
		yield return null;
		if (SlotScrollRect != null && OrderSlots != null && SelectOrder >= 0 && SelectOrder < OrderSlots.Count)
		{
			var targetRt = OrderSlots[SelectOrder].GetComponent<RectTransform>();
			if (targetRt != null)
			{
				float normalizedPos = (float)SelectOrder / Mathf.Max(1, OrderSlots.Count - 1);
				SlotScrollRect.horizontalNormalizedPosition = Mathf.Clamp01(normalizedPos);
			}
		}
	}

	private void UpdateOrder()
	{
		if (OrderSlots == null) return;
		for (int i = 0; i < OrderSlots.Count; i++)
		{
			if (OrderSlots[i] != null)
			{
				// Refresh order slot data
			}
		}
		UpdateSelect();
	}

	private void UpdateSelect()
	{
		if (OrderSlots == null || SelectOrder < 0 || SelectOrder >= OrderSlots.Count) return;

		// Update selected order info UI
		if (OrderInfoObj != null) OrderInfoObj.SetActive(true);
		if (OrderWaitObj != null) OrderWaitObj.SetActive(false);

		// Update complete button red dot
		if (OrderCompRedDotObj != null) OrderCompRedDotObj.SetActive(false);
	}

	public void RefreshSlot()
	{
		UpdateOrder();
	}

	private void OnClickSelect(int slot)
	{
		if (slot < 0 || OrderSlots == null || slot >= OrderSlots.Count) return;
		SelectOrder = slot;
		UpdateSelect();
		StartCoroutine(FocusOrderSlot());
	}

	private void OnClickCompOrder()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateOrder();
	}

	private void OnClickResetOrder()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateOrder();
	}

	private void OnClickFactoryShortCut()
	{
		OnGotoNavi?.Invoke();
	}

	private void OnClickProductShortCut()
	{
		// Navigate to product production
		OnGotoNavi?.Invoke();
	}

	private void OnClickMissionShortCut(int slot)
	{
		OnGotoNavi?.Invoke();
	}

	private void GetFactoryMissionReward(int rewardType, int rewardIdx, BigInteger rewardCnt, bool isDoubleReward)
	{
		BigInteger finalCnt = isDoubleReward ? rewardCnt * 2 : rewardCnt;
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.UserData != null)
		{
			root.UserData.SetReward(rewardType, rewardIdx, 0, finalCnt);
		}
	}

	public void Refresh()
	{
		UpdateOrder();
		SetMissionList();
	}

	public void Reset()
	{
		SelectOrder = 0;
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}
}
