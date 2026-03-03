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
	}

	public override void OnShowBefore()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void InitDefine()
	{
	}

	private void LoadCeo()
	{
	}

	private void SetRemainTimeText()
	{
	}

	private void SetCurrencyInfo(int eventIdx)
	{
	}

	private void UpdateHasCurrencyValue()
	{
	}

	private void MakeUpStage()
	{
	}

	private void CreateNeedItem()
	{
	}

	private void SetHintItems()
	{
	}

	private void RestoreItemPool()
	{
	}

	private void TryLoadFloor(string floorPath)
	{
	}

	private void PlaceTreasureItems()
	{
	}

	private void OnClickedCell(Vector2Int position)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitBlockCoroutine_003Ed__59))]
	private IEnumerator WaitBlockCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitAndStageClearCoroutine_003Ed__60))]
	private IEnumerator WaitAndStageClearCoroutine(bool isGameClear)
	{
		return null;
	}

	private void GetBonusMoney(Vector2Int cellPos)
	{
	}

	private void PlayFloorRemoveFx(Vector2Int cellPos)
	{
	}

	private void SetBubbleTextQueue(E_SpeechType speechType, int findItemIdx)
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickMission()
	{
	}

	private void OnClickShop()
	{
	}

	private void OnClickExchangeShop()
	{
	}

	public static float GetInverseScaleFactor(Vector2 size, float minSize, float maxSize, float minScale, float maxScale)
	{
		return 0f;
	}
}
