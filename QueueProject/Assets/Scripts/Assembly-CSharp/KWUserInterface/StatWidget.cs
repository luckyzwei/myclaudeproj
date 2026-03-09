using System.Collections.Generic;
using System.Reflection;
using KWHaptics.Haptics;
using UnityEngine;

namespace KWUserInterface
{
	public class StatWidget : MonoBehaviour
	{
		private const string ANIM_HIDDEN = "Hidden";

		private const string ANIM_VISIBLE = "Visible";

		private const string TEXT_PROPERTY = "text";

		[SerializeField]
		private string m_statID;

		[SerializeField]
		private GameObject m_currentValue;

		[SerializeField]
		private int m_valueInterpSpeed;

		[SerializeField]
		protected float m_valueDelay;

		[Header("Animations")]
		[SerializeField]
		protected AnimatorHelper m_animatorHelper;

		[Header("Haptics")]
		[SerializeField]
		private bool m_hapticsEnabled;

		[SerializeField]
		private float m_timeBetweenHaptics;

		[SerializeField]
		private HapticsManager.HapticType m_hapticType;

		private float m_hapticTimer;

		private static readonly List<string> SUPPORTED_TEXT_COMPONENTS;

		private ulong m_moneyToAdd;

		private long m_value;

		private bool m_audioPlayed;

		private float m_delayTimer;

		private bool m_paused;

		protected long m_followValue;

		protected PropertyInfo m_textProperty;

		protected Component m_textComponent;

		private void Awake()
		{
		}

		private void SetTextReference()
		{
		}

		protected virtual void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateValueText()
		{
		}

		private void HandleStatValueChanged(long total, string statID, long diffAmount)
		{
		}

		public void SetValue(long newValue, bool animate = true)
		{
		}

		private void Update()
		{
		}

		private void UpdateVisuals()
		{
		}

		private void DoHaptics()
		{
		}

		protected virtual void SetTextValue()
		{
		}
	}
}
