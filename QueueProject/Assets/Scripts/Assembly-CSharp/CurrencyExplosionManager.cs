using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using KWCore.Utils;
using UnityEngine;

public class CurrencyExplosionManager : MonoSingleton<CurrencyExplosionManager>
{
	protected class CurrencyExplosionPair
	{
		private List<CurrencyExplosionOrigin> m_origins;

		private List<CurrencyExplosionReceiver> m_receivers;

		public CurrencyExplosionOrigin Origin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurrencyExplosionReceiver Receiver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurrencyExplosionPair(CurrencyExplosionOrigin origin, CurrencyExplosionReceiver receiver)
		{
		}

		public bool IsValid()
		{
			return false;
		}
	}

	protected struct QueuedExplosionData
	{
		public KwaleeItem item;

		public int numAwarded;

		public Vector3 origin;

		public Action onFirstElementReached;

		public CurrencyExplosionReceiver receiver;

		public Action onFinishedActions;

		public string clientId;

		public Transform originalParent;

		public int originalSiblingIndex;

		public GameObject placeHolderGameObject;

		public QueuedExplosionData(KwaleeItem item, int numAwarded, Vector3 origin, CurrencyExplosionReceiver receiver, Action onFirstElementReached, Action onFinishedActions, string clientId, Transform parent = null, int siblingIndex = 0, GameObject placeholderGO = null)
		{
			this.item = null;
			this.numAwarded = 0;
			this.origin = default(Vector3);
			this.onFirstElementReached = null;
			this.receiver = null;
			this.onFinishedActions = null;
			this.clientId = null;
			originalParent = null;
			originalSiblingIndex = 0;
			placeHolderGameObject = null;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public CurrencyExplosionManager _003C_003E4__this;

		public Action onQueueFinished;
	}

	[CompilerGenerated]
	private sealed class _003CExecuteQueueCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrencyExplosionManager _003C_003E4__this;

		public Action onQueueFinished;

		public float delay;

		public Queue<QueuedExplosionData> queue;

		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

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
		public _003CExecuteQueueCoroutine_003Ed__17(int _003C_003E1__state)
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
	protected float m_timeBetweenExplosions;

	[SerializeField]
	private CurrencyExplosionTweenData[] m_currencyExplosionsData;

	[SerializeField]
	private bool m_runRealtime;

	protected Dictionary<string, CurrencyExplosionTweenData> m_currencyExplosionDatasDictionary;

	protected CurrencyExplosionPopUp m_currencyExplosionPopUp;

	private Dictionary<GameObject, List<QueuedExplosionData>> m_queuedCountByReceiver;

	private int m_onGoingFlows;

	private bool m_receiverNeedsParentResetting;

	protected Dictionary<string, CurrencyExplosionPair> m_registeredPairs;

	protected override void Init()
	{
	}

	protected void TrySpawnPopUp()
	{
	}

	private void TryRemovePopUp()
	{
	}

	public void PrepareForExplosion(string clientID)
	{
	}

	public void DoExplosion(Reward reward, Action onQueueFinished = null, float delay = 0f, bool pauseBank = true, string clientId = "default", bool reParentReceiver = false, Transform overrideOrigin = null)
	{
	}

	private GameObject CreatePlaceHolderFor(Transform item)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CExecuteQueueCoroutine_003Ed__17))]
	private IEnumerator ExecuteQueueCoroutine(Queue<QueuedExplosionData> queue, Action onQueueFinished = null, float delay = 0f)
	{
		return null;
	}

	private void TryFinishQueue(int queueCount, Action onQueueFinished)
	{
	}

	private void RestoreParent(QueuedExplosionData data)
	{
	}

	public void DoExplosion(Sprite sprite, int numObtained, Vector3 origin, Transform target, Action firstElementReached = null, Action finished = null, string clientId = "default")
	{
	}

	public void DoExplosion(string clientID, int numObtained, Vector3 origin, Transform target, Action firstElementReached = null, Action finished = null, string clientId = "default")
	{
	}

	protected virtual void CreateExplosionFromQueueData(QueuedExplosionData explosionData, Action firstElementReached = null, Action finished = null)
	{
	}

	protected UnnyObject GetItemSprite(KwaleeItem kwaleeItem)
	{
		return null;
	}

	public void RegisterReceiver(CurrencyExplosionReceiver receiver)
	{
	}

	public void RemoveReceiver(CurrencyExplosionReceiver receiver)
	{
	}

	public void RegisterOrigin(CurrencyExplosionOrigin origin)
	{
	}

	public void RemoveOrigin(CurrencyExplosionOrigin origin)
	{
	}

	public CurrencyExplosionReceiver GetReceiverFromId(string clientId)
	{
		return null;
	}
}
