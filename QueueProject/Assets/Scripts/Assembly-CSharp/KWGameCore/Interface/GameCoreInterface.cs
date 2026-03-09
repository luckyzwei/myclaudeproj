using System;
using System.Collections.Generic;
using KWGameCore.Bank;
using UnityEngine;

namespace KWGameCore.Interface
{
	public class GameCoreInterface : MonoBehaviour, BaseBank.IDelegate
	{
		[Serializable]
		public class BankConfig
		{
			public string bankType;
		}

		[SerializeField]
		private string m_gameRewardCurrencyID;

		[SerializeField]
		private BankConfig m_selectedBank;

		[Header("Option to add multiple currencies for games that use Kanga Bank")]
		[SerializeField]
		private List<string> m_currencies;

		[Header("Subscription/VIP")]
		[SerializeField]
		private GameObject m_prefabSubscriptionFullScreen;

		public string GetGameRewardCurrencyID()
		{
			return null;
		}

		public string GetBankType()
		{
			return null;
		}

		public List<string> GetGameCurrenciesKanga()
		{
			return null;
		}

		public GameObject GetSubscriptionFullScreenPrefab()
		{
			return null;
		}
	}
}
