using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupFeatureUpdate : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CShowCloseButtonCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupFeatureUpdate _003C_003E4__this;

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
		public _003CShowCloseButtonCoroutine_003Ed__7(int _003C_003E1__state)
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

	public const string PREFAB_NAME = "Prefabs/Popups/Popup-FeatureUpdate";

	private const float CLOSE_BUTTON_SHOW_DELAY = 1.5f;

	[Header("Text")]
	[SerializeField]
	private TextMeshProUGUI m_headerText;

	[SerializeField]
	private TextMeshProUGUI m_bodyText;

	[Header("Sprites")]
	[SerializeField]
	private Image m_image;

	[Header("Button")]
	[SerializeField]
	private Button m_closeButton;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CShowCloseButtonCoroutine_003Ed__7))]
	private IEnumerator ShowCloseButtonCoroutine()
	{
		return null;
	}

	private void SetText()
	{
	}

	private void SetImage()
	{
	}
}
