using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
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
	}

	private void OnDestroy()
	{
	}

	public void Init(int distributeProductIdx, float distributeShowDelay, float progressUIScale)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateProgressUI_003Ed__29))]
	private IEnumerator UpdateProgressUI()
	{
		return null;
	}

	private void UpdateDistributeInfo()
	{
	}

	private void OnDistributeProduct(int productIdx, BigInteger distributeValue)
	{
	}

	private void SubscribeEvents()
	{
	}

	private void ResetSubscribeEvents()
	{
	}

	private void OnChangedSlotOpenState(bool isOpen)
	{
	}

	private void OnChangedSellingState(bool isSelling)
	{
	}

	private void OnChangedPauseState(bool isPause)
	{
	}

	private void PlayDistributeEnter()
	{
	}

	private void PlayDistributeReady()
	{
	}

	private void PlayDistributePause()
	{
	}

	private void PlayDistributeStart()
	{
	}

	private void LoadProductionProgressUI()
	{
	}
}
