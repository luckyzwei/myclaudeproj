using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using System.Runtime.CompilerServices;
using UniRx;
using UnityEngine;

public class DockDistributorObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateProgressUI_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DockDistributorObject _003C_003E4__this;

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
		public _003CUpdateProgressUI_003Ed__29(int _003C_003E1__state)
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

	[Header("OnOpen")]
	[SerializeField]
	private GameObject GateObj;

	[SerializeField]
	private GameObject ReturnDistributeObj;

	[SerializeField]
	private List<GameObject> OpenActiveObjects;

	private DoTweenScriptComponent Gate_DoTween;

	private DoTweenScriptComponent ReturnDistribute_DoTween;

	[Header("Ready")]
	[SerializeField]
	private GameObject ReadyDistributeObj;

	[SerializeField]
	private GameObject ReadyChimneyObj;

	[SerializeField]
	private List<GameObject> ReadyActiveObjects;

	private DoTweenScriptComponent ReadyChimneyObj_DoTween;

	[Header("Start")]
	[SerializeField]
	private GameObject StartDistributeObj;

	private DoTweenScriptComponent StartDistribute_DoTween;

	[SerializeField]
	private List<GameObject> StartActiveObjects;

	[SerializeField]
	private Transform ProgressTrans;

	private int DistributeProductIdx;

	private int DistributeCoolTimeSec;

	private DateTime LastDistributeTime;

	private InGameSeasonalProgress DistributeProgressUI;

	private WeakReference<Coroutine> UpdateCoroutine;

	private bool bTryLoadProgressUI;

	private bool bActiveProgressUI;

	private bool IsSellingProduct;

	private bool IsPauseDistribute;

	private float DistributeNextShowDelay;

	private float ProgressUIScale;

	private bool bWaitNextDistribute;

	private CompositeDisposable Disposables;

	private void Awake()
	{
		Disposables = new CompositeDisposable();
		bTryLoadProgressUI = false;
		bActiveProgressUI = false;
		IsSellingProduct = false;
		IsPauseDistribute = false;
		bWaitNextDistribute = false;
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public void Init(int distributeProductIdx, float distributeShowDelay, float progressUIScale)
	{
		DistributeProductIdx = distributeProductIdx;
		DistributeNextShowDelay = distributeShowDelay;
		ProgressUIScale = progressUIScale;
		IsSellingProduct = false;
		IsPauseDistribute = false;
		bWaitNextDistribute = false;

		if (Gate_DoTween == null && GateObj != null)
			Gate_DoTween = GateObj.GetComponent<DoTweenScriptComponent>();
		if (ReturnDistribute_DoTween == null && ReturnDistributeObj != null)
			ReturnDistribute_DoTween = ReturnDistributeObj.GetComponent<DoTweenScriptComponent>();
		if (ReadyChimneyObj_DoTween == null && ReadyChimneyObj != null)
			ReadyChimneyObj_DoTween = ReadyChimneyObj.GetComponent<DoTweenScriptComponent>();
		if (StartDistribute_DoTween == null && StartDistributeObj != null)
			StartDistribute_DoTween = StartDistributeObj.GetComponent<DoTweenScriptComponent>();

		UpdateDistributeInfo();
		SubscribeEvents();
	}

	[IteratorStateMachine(typeof(_003CUpdateProgressUI_003Ed__29))]
	private IEnumerator UpdateProgressUI()
	{
		while (IsSellingProduct && !IsPauseDistribute)
		{
			if (DistributeCoolTimeSec > 0 && DistributeProgressUI != null)
			{
				var elapsed = (float)(DateTime.UtcNow - LastDistributeTime).TotalSeconds;
				float progress = Mathf.Clamp01(elapsed / DistributeCoolTimeSec);
				DistributeProgressUI.UpdateValue(progress);
			}
			yield return null;
		}
	}

	private void UpdateDistributeInfo()
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData == null || stageData.DistributorData == null) return;
		var distData = stageData.DistributorData;
		if (distData.ProductSellingCoolTimeSec != null)
			DistributeCoolTimeSec = distData.ProductSellingCoolTimeSec.Value;
		if (distData.SaleProductsMap != null && distData.SaleProductsMap.TryGetValue(DistributeProductIdx, out var productData))
		{
			IsSellingProduct = productData.isSelling != null && productData.isSelling.Value;
			IsPauseDistribute = productData.isPauseSelling != null && productData.isPauseSelling.Value;
			LastDistributeTime = productData.lastSellingDataTime;
		}
	}

	private void OnDistributeProduct(int productIdx, BigInteger distributeValue)
	{
		if (productIdx != DistributeProductIdx) return;
		LastDistributeTime = DateTime.UtcNow;
		bWaitNextDistribute = true;
	}

	private void SubscribeEvents()
	{
		ResetSubscribeEvents();
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData == null || stageData.DistributorData == null) return;
		var distData = stageData.DistributorData;
		if (distData.SaleProductsMap != null && distData.SaleProductsMap.TryGetValue(DistributeProductIdx, out var productData))
		{
			if (productData.isSelling != null)
				productData.isSelling.Subscribe(OnChangedSellingState).AddTo(Disposables);
			if (productData.isPauseSelling != null)
				productData.isPauseSelling.Subscribe(OnChangedPauseState).AddTo(Disposables);
		}
	}

	private void ResetSubscribeEvents()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	private void OnChangedSlotOpenState(bool isOpen)
	{
		if (isOpen)
			PlayDistributeEnter();
	}

	private void OnChangedSellingState(bool isSelling)
	{
		IsSellingProduct = isSelling;
		if (isSelling)
		{
			PlayDistributeStart();
			LoadProductionProgressUI();
		}
		else
		{
			PlayDistributeReady();
		}
	}

	private void OnChangedPauseState(bool isPause)
	{
		IsPauseDistribute = isPause;
		if (isPause)
			PlayDistributePause();
		else if (IsSellingProduct)
			PlayDistributeStart();
	}

	private void PlayDistributeEnter()
	{
		if (OpenActiveObjects != null)
			for (int i = 0; i < OpenActiveObjects.Count; i++)
				if (OpenActiveObjects[i] != null) OpenActiveObjects[i].SetActive(true);
		if (Gate_DoTween != null) Gate_DoTween.Play();
	}

	private void PlayDistributeReady()
	{
		if (ReadyActiveObjects != null)
			for (int i = 0; i < ReadyActiveObjects.Count; i++)
				if (ReadyActiveObjects[i] != null) ReadyActiveObjects[i].SetActive(true);
		if (StartActiveObjects != null)
			for (int i = 0; i < StartActiveObjects.Count; i++)
				if (StartActiveObjects[i] != null) StartActiveObjects[i].SetActive(false);
		if (ReadyDistributeObj != null) ReadyDistributeObj.SetActive(true);
		if (StartDistributeObj != null) StartDistributeObj.SetActive(false);
		if (ReadyChimneyObj_DoTween != null) ReadyChimneyObj_DoTween.Play();
	}

	private void PlayDistributePause()
	{
		if (DistributeProgressUI != null)
			DistributeProgressUI.SetProgressState(InGameSeasonalProgress.E_ProgressState.Pause);
	}

	private void PlayDistributeStart()
	{
		if (StartActiveObjects != null)
			for (int i = 0; i < StartActiveObjects.Count; i++)
				if (StartActiveObjects[i] != null) StartActiveObjects[i].SetActive(true);
		if (ReadyActiveObjects != null)
			for (int i = 0; i < ReadyActiveObjects.Count; i++)
				if (ReadyActiveObjects[i] != null) ReadyActiveObjects[i].SetActive(false);
		if (StartDistributeObj != null) StartDistributeObj.SetActive(true);
		if (ReadyDistributeObj != null) ReadyDistributeObj.SetActive(false);
		if (StartDistribute_DoTween != null) StartDistribute_DoTween.Play();
		if (DistributeProgressUI != null)
			DistributeProgressUI.SetProgressState(InGameSeasonalProgress.E_ProgressState.Progress);
		LastDistributeTime = DateTime.UtcNow;
		StartCoroutine(UpdateProgressUI());
	}

	private void LoadProductionProgressUI()
	{
		if (bTryLoadProgressUI || DistributeProgressUI != null) return;
		bTryLoadProgressUI = true;
		if (ProgressTrans == null) return;
		// Load progress UI via resource system
	}
}
