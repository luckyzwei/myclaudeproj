using System;
using System.Collections.Generic;
using Hiro;
using Nakama;
using TMPro;
using UnityEngine;

namespace KWPlayerProfile
{
	public abstract class StatsWidget<T> : MonoBehaviour where T : struct, Enum
	{
		[Serializable]
		private struct StatText
		{
			public T Id;

			public TMP_Text TmpText;
		}

		[SerializeField]
		private List<StatText> m_statTexts;

		private bool m_isPlayer;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnStatValueChanged(long total, string statID, long awarded)
		{
		}

		public void Config(IApiUser apiUser)
		{
		}

		public void Config(IApiUser iApiUser, bool isPlayer)
		{
		}

		private void Populate(IDictionary<T, IStat> stats)
		{
		}

		private void UpdateStatText(T enumId, long value)
		{
		}
	}
}
