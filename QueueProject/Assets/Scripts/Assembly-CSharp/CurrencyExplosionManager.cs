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
				return m_origins != null && m_origins.Count > 0 ? m_origins[0] : null;
			}
			set
			{
				if (m_origins == null) m_origins = new List<CurrencyExplosionOrigin>();
				if (m_origins.Count == 0) m_origins.Add(value);
				else m_origins[0] = value;
			}
		}

		public CurrencyExplosionReceiver Receiver
		{
			get
			{
				return m_receivers != null && m_receivers.Count > 0 ? m_receivers[0] : null;
			}
			set
			{
				if (m_receivers == null) m_receivers = new List<CurrencyExplosionReceiver>();
				if (m_receivers.Count == 0) m_receivers.Add(value);
				else m_receivers[0] = value;
			}
		}

		public CurrencyExplosionPair(CurrencyExplosionOrigin origin, CurrencyExplosionReceiver receiver)
		{
			m_origins = new List<CurrencyExplosionOrigin>();
			m_receivers = new List<CurrencyExplosionReceiver>();
			if (origin != null) m_origins.Add(origin);
			if (receiver != null) m_receivers.Add(receiver);
		}

		public bool IsValid()
		{
			return Origin != null && Receiver != null;
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
			this.item = item;
			this.numAwarded = numAwarded;
			this.origin = origin;
			this.onFirstElementReached = onFirstElementReached;
			this.receiver = receiver;
			this.onFinishedActions = onFinishedActions;
			this.clientId = clientId;
			originalParent = parent;
			originalSiblingIndex = siblingIndex;
			placeHolderGameObject = placeholderGO;
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
		m_registeredPairs = new Dictionary<string, CurrencyExplosionPair>();
		m_currencyExplosionDatasDictionary = new Dictionary<string, CurrencyExplosionTweenData>();
		m_queuedCountByReceiver = new Dictionary<GameObject, List<QueuedExplosionData>>();
		m_onGoingFlows = 0;

		if (m_currencyExplosionsData != null)
		{
			for (int i = 0; i < m_currencyExplosionsData.Length; i++)
			{
				var data = m_currencyExplosionsData[i];
				if (data != null && !string.IsNullOrEmpty(data.ClientdId))
					m_currencyExplosionDatasDictionary[data.ClientdId] = data;
			}
		}
	}

	protected void TrySpawnPopUp()
	{
		if (m_currencyExplosionPopUp == null)
		{
			var prefab = Resources.Load<CurrencyExplosionPopUp>("prefabs/CurrencyExplosionPopUp");
			if (prefab != null)
				m_currencyExplosionPopUp = Instantiate(prefab, transform);
		}
	}

	private void TryRemovePopUp()
	{
		if (m_currencyExplosionPopUp != null && m_onGoingFlows <= 0)
		{
			Destroy(m_currencyExplosionPopUp.gameObject);
			m_currencyExplosionPopUp = null;
		}
	}

	public void PrepareForExplosion(string clientID)
	{
		if (m_registeredPairs == null || !m_registeredPairs.ContainsKey(clientID)) return;
		TrySpawnPopUp();
	}

	public void DoExplosion(Reward reward, Action onQueueFinished = null, float delay = 0f, bool pauseBank = true, string clientId = "default", bool reParentReceiver = false, Transform overrideOrigin = null)
	{
		if (reward == null) { onQueueFinished?.Invoke(); return; }

		var queue = new Queue<QueuedExplosionData>();
		// Queue reward items
		var explosionData = new QueuedExplosionData(null, 1, overrideOrigin != null ? overrideOrigin.position : Vector3.zero,
			GetReceiverFromId(clientId), null, null, clientId);
		queue.Enqueue(explosionData);

		m_onGoingFlows++;
		TrySpawnPopUp();
		StartCoroutine(ExecuteQueueCoroutine(queue, onQueueFinished, delay));
	}

	private GameObject CreatePlaceHolderFor(Transform item)
	{
		if (item == null) return null;
		var placeholder = new GameObject("Placeholder");
		placeholder.transform.SetParent(item.parent);
		placeholder.transform.SetSiblingIndex(item.GetSiblingIndex());
		return placeholder;
	}

	[IteratorStateMachine(typeof(_003CExecuteQueueCoroutine_003Ed__17))]
	private IEnumerator ExecuteQueueCoroutine(Queue<QueuedExplosionData> queue, Action onQueueFinished = null, float delay = 0f)
	{
		if (delay > 0)
			yield return new WaitForSeconds(delay);

		while (queue.Count > 0)
		{
			var data = queue.Dequeue();
			CreateExplosionFromQueueData(data, data.onFirstElementReached, data.onFinishedActions);
			if (m_timeBetweenExplosions > 0)
				yield return new WaitForSeconds(m_timeBetweenExplosions);
		}

		TryFinishQueue(0, onQueueFinished);
	}

	private void TryFinishQueue(int queueCount, Action onQueueFinished)
	{
		if (queueCount <= 0)
		{
			m_onGoingFlows--;
			TryRemovePopUp();
			onQueueFinished?.Invoke();
		}
	}

	private void RestoreParent(QueuedExplosionData data)
	{
		if (data.originalParent != null && data.receiver != null)
		{
			data.receiver.transform.SetParent(data.originalParent);
			data.receiver.transform.SetSiblingIndex(data.originalSiblingIndex);
		}
		if (data.placeHolderGameObject != null)
			Destroy(data.placeHolderGameObject);
	}

	public void DoExplosion(Sprite sprite, int numObtained, Vector3 origin, Transform target, Action firstElementReached = null, Action finished = null, string clientId = "default")
	{
		var receiver = GetReceiverFromId(clientId);
		var data = new QueuedExplosionData(null, numObtained, origin, receiver, firstElementReached, finished, clientId);
		m_onGoingFlows++;
		TrySpawnPopUp();
		CreateExplosionFromQueueData(data, firstElementReached, finished);
	}

	public void DoExplosion(string clientID, int numObtained, Vector3 origin, Transform target, Action firstElementReached = null, Action finished = null, string clientId = "default")
	{
		var receiver = GetReceiverFromId(clientID);
		var data = new QueuedExplosionData(null, numObtained, origin, receiver, firstElementReached, finished, clientID);
		m_onGoingFlows++;
		TrySpawnPopUp();
		CreateExplosionFromQueueData(data, firstElementReached, finished);
	}

	protected virtual void CreateExplosionFromQueueData(QueuedExplosionData explosionData, Action firstElementReached = null, Action finished = null)
	{
		// Base implementation - subclasses provide actual explosion visuals
		firstElementReached?.Invoke();
		finished?.Invoke();
		m_onGoingFlows--;
		TryRemovePopUp();
	}

	protected UnnyObject GetItemSprite(KwaleeItem kwaleeItem)
	{
		return null; // Loaded from Balancy
	}

	public void RegisterReceiver(CurrencyExplosionReceiver receiver)
	{
		if (receiver == null || m_registeredPairs == null) return;
		string id = receiver.ClientID;
		if (string.IsNullOrEmpty(id)) return;
		if (!m_registeredPairs.ContainsKey(id))
			m_registeredPairs[id] = new CurrencyExplosionPair(null, receiver);
		else
			m_registeredPairs[id].Receiver = receiver;
	}

	public void RemoveReceiver(CurrencyExplosionReceiver receiver)
	{
		if (receiver == null || m_registeredPairs == null) return;
		string id = receiver.ClientID;
		if (!string.IsNullOrEmpty(id) && m_registeredPairs.ContainsKey(id))
			m_registeredPairs.Remove(id);
	}

	public void RegisterOrigin(CurrencyExplosionOrigin origin)
	{
		if (origin == null || m_registeredPairs == null) return;
		string id = origin.GetClientID();
		if (string.IsNullOrEmpty(id)) return;
		if (!m_registeredPairs.ContainsKey(id))
			m_registeredPairs[id] = new CurrencyExplosionPair(origin, null);
		else
			m_registeredPairs[id].Origin = origin;
	}

	public void RemoveOrigin(CurrencyExplosionOrigin origin)
	{
		if (origin == null || m_registeredPairs == null) return;
		string id = origin.GetClientID();
		if (!string.IsNullOrEmpty(id) && m_registeredPairs.ContainsKey(id))
		{
			var pair = m_registeredPairs[id];
			if (pair.Receiver == null)
				m_registeredPairs.Remove(id);
		}
	}

	public CurrencyExplosionReceiver GetReceiverFromId(string clientId)
	{
		if (string.IsNullOrEmpty(clientId) || m_registeredPairs == null) return null;
		if (m_registeredPairs.TryGetValue(clientId, out var pair))
			return pair.Receiver;
		return null;
	}
}
