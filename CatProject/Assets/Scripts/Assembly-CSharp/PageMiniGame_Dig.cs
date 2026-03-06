using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageMiniGame_Dig", false, false)]
public class PageMiniGame_Dig : UIBase
{
	private enum E_SpeechType
	{
		None = 0,
		EmptyFloor = 1,
		FindItem = 2,
		ClearStage = 3
	}

	private enum E_SpeakerType
	{
		Mother = 0,
		Ceo = 1
	}

	[CompilerGenerated]
	private sealed class _003CWaitAndStageClearCoroutine_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageMiniGame_Dig _003C_003E4__this;

		public bool isGameClear;

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
		public _003CWaitAndStageClearCoroutine_003Ed__60(int _003C_003E1__state)
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
	private sealed class _003CWaitBlockCoroutine_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageMiniGame_Dig _003C_003E4__this;

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
		public _003CWaitBlockCoroutine_003Ed__59(int _003C_003E1__state)
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

	private static readonly string FloorPathBase;

	private static readonly float BUBBLE_TEXT_SHOW_TIME;

	[Header("Character")]
	[SerializeField]
	private Transform MyCeoRoot;

	[SerializeField]
	private AutoPlayBubble MotherBubble;

	[SerializeField]
	private AutoPlayBubble CeoBubble;

	[Header("Game")]
	[SerializeField]
	private Button InfoButton;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private ItemArticle UseCurrencyItem;

	[SerializeField]
	private Transform FloorRootTr;

	[SerializeField]
	private Transform ItemPoolTr;

	[SerializeField]
	private GameObject ItemRefAsset;

	[SerializeField]
	private GameObject ScreenCoverObj;

	[SerializeField]
	private Transform HintItemListRootTr;

	[Header("Game - Effect")]
	[SerializeField]
	private Transform FxPoolTr;

	[SerializeField]
	private GameObject MoneyGetFxRefAsset;

	[SerializeField]
	private GameObject FloorRemoveFxRefAsset;

	[Header("Game - Progress")]
	[SerializeField]
	private ItemMiniGameRewardProgress RewardProgress;

	[Header("RightTop")]
	[SerializeField]
	private Button MissionBtn;

	[SerializeField]
	private Button ShopBtn;

	[SerializeField]
	private Button ExchangeShopBtn;

	private AddressableLoadGameObject CeoLoadObject;

	private ItemMiniGame_DigFloor ItemDigFloor;

	private AddressableLoadGameObject FloorLoadObject;

	private List<ItemMiniGame_DigTreasure> ItemObjList;

	private List<ItemMiniGame_DigTreasureHint> HintItemObjList;

	private List<ItemMiniGameRewardMoney> MoneyGetFxList;

	private List<GameObject> FloorRemoveFxList;

	private int BONUS_MONEY_TIME_SEC;

	private bool IsInitDefine;

	private int ScheduleIdx;

	private int EventIdx;

	private int StageIdx;

	private int StageGridSize;

	private int UseCurrencyIdx;

	private BigInteger NeedCurrencyValue;

	private Queue<(string localKey, E_SpeakerType speakerType)> BubbleTextQueue;

	private float BubbleTextRemainTime;

	private List<string> EmptyFloorBubbleText;

	private string StageClearBubbleText;

	private CompositeDisposable Disposables;

	protected override void Awake()
	{
		base.Awake();
		Disposables = new CompositeDisposable();
		ItemObjList = new List<ItemMiniGame_DigTreasure>();
		HintItemObjList = new List<ItemMiniGame_DigTreasureHint>();
		MoneyGetFxList = new List<ItemMiniGameRewardMoney>();
		FloorRemoveFxList = new List<GameObject>();
		BubbleTextQueue = new Queue<(string, E_SpeakerType)>();
		EmptyFloorBubbleText = new List<string>();

		if (InfoButton != null) InfoButton.onClick.AddListener(OnClickInfo);
		if (MissionBtn != null) MissionBtn.onClick.AddListener(OnClickMission);
		if (ShopBtn != null) ShopBtn.onClick.AddListener(OnClickShop);
		if (ExchangeShopBtn != null) ExchangeShopBtn.onClick.AddListener(OnClickExchangeShop);
	}

	public override void OnShowBefore()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		InitDefine();
		LoadCeo();
		SetRemainTimeText();
		MakeUpStage();
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	private void Update()
	{
		if (BubbleTextRemainTime > 0f)
		{
			BubbleTextRemainTime -= Time.deltaTime;
			if (BubbleTextRemainTime <= 0f)
			{
				if (MotherBubble != null) MotherBubble.PlayHide();
				if (CeoBubble != null) CeoBubble.PlayHide();

				if (BubbleTextQueue.Count > 0)
				{
					var next = BubbleTextQueue.Dequeue();
					var bubble = next.Item2 == E_SpeakerType.Mother ? MotherBubble : CeoBubble;
					if (bubble != null) bubble.PlayShowImmediately();
					BubbleTextRemainTime = BUBBLE_TEXT_SHOW_TIME;
				}
			}
		}
	}

	private void InitDefine()
	{
		if (IsInitDefine) return;
		IsInitDefine = true;
	}

	private void LoadCeo()
	{
	}

	private void SetRemainTimeText()
	{
		if (RemainTimeText != null) RemainTimeText.text = "";
	}

	private void SetCurrencyInfo(int eventIdx)
	{
		EventIdx = eventIdx;
		UpdateHasCurrencyValue();
	}

	private void UpdateHasCurrencyValue()
	{
	}

	private void MakeUpStage()
	{
		RestoreItemPool();
		TryLoadFloor(FloorPathBase);
		CreateNeedItem();
		SetHintItems();
		PlaceTreasureItems();
	}

	private void CreateNeedItem()
	{
		ItemObjList.Clear();
	}

	private void SetHintItems()
	{
		HintItemObjList.Clear();
	}

	private void RestoreItemPool()
	{
		for (int i = 0; i < ItemObjList.Count; i++)
		{
			if (ItemObjList[i] != null)
				ItemObjList[i].transform.SetParent(ItemPoolTr);
		}
		ItemObjList.Clear();
	}

	private void TryLoadFloor(string floorPath)
	{
	}

	private void PlaceTreasureItems()
	{
	}

	private void OnClickedCell(Vector2Int position)
	{
		if (ScreenCoverObj != null && ScreenCoverObj.activeSelf) return;
		if (ScreenCoverObj != null) ScreenCoverObj.SetActive(true);
		StartCoroutine(WaitBlockCoroutine());
	}

	[IteratorStateMachine(typeof(_003CWaitBlockCoroutine_003Ed__59))]
	private IEnumerator WaitBlockCoroutine()
	{
		yield return new WaitForSeconds(0.5f);
		if (ScreenCoverObj != null) ScreenCoverObj.SetActive(false);
	}

	[IteratorStateMachine(typeof(_003CWaitAndStageClearCoroutine_003Ed__60))]
	private IEnumerator WaitAndStageClearCoroutine(bool isGameClear)
	{
		yield return new WaitForSeconds(1f);
		if (isGameClear)
		{
			SetBubbleTextQueue(E_SpeechType.ClearStage, 0);
		}
	}

	private void GetBonusMoney(Vector2Int cellPos)
	{
		PlayFloorRemoveFx(cellPos);
	}

	private void PlayFloorRemoveFx(Vector2Int cellPos)
	{
		if (FloorRemoveFxRefAsset == null || FxPoolTr == null) return;
		GameObject fx = null;
		if (FloorRemoveFxList.Count > 0)
		{
			fx = FloorRemoveFxList[FloorRemoveFxList.Count - 1];
			FloorRemoveFxList.RemoveAt(FloorRemoveFxList.Count - 1);
		}
		if (fx == null)
			fx = UnityEngine.Object.Instantiate(FloorRemoveFxRefAsset, FxPoolTr);
		fx.SetActive(true);
	}

	private void SetBubbleTextQueue(E_SpeechType speechType, int findItemIdx)
	{
		switch (speechType)
		{
			case E_SpeechType.EmptyFloor:
				if (EmptyFloorBubbleText != null && EmptyFloorBubbleText.Count > 0)
				{
					int randIdx = UnityEngine.Random.Range(0, EmptyFloorBubbleText.Count);
					BubbleTextQueue.Enqueue((EmptyFloorBubbleText[randIdx], E_SpeakerType.Mother));
				}
				break;
			case E_SpeechType.FindItem:
				BubbleTextQueue.Enqueue(("", E_SpeakerType.Ceo));
				break;
			case E_SpeechType.ClearStage:
				if (!string.IsNullOrEmpty(StageClearBubbleText))
					BubbleTextQueue.Enqueue((StageClearBubbleText, E_SpeakerType.Mother));
				break;
		}
		if (BubbleTextRemainTime <= 0f && BubbleTextQueue.Count > 0)
		{
			var next = BubbleTextQueue.Dequeue();
			var bubble = next.Item2 == E_SpeakerType.Mother ? MotherBubble : CeoBubble;
			if (bubble != null) bubble.PlayShowImmediately();
			BubbleTextRemainTime = BUBBLE_TEXT_SHOW_TIME;
		}
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMiniGameOpen>();
	}

	private void OnClickMission()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMission>();
	}

	private void OnClickShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickExchangeShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupEventExchange>();
	}

	public static float GetInverseScaleFactor(Vector2 size, float minSize, float maxSize, float minScale, float maxScale)
	{
		float t = Mathf.InverseLerp(minSize, maxSize, Mathf.Max(size.x, size.y));
		return Mathf.Lerp(maxScale, minScale, t);
	}
}
