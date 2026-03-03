using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TutorialEntityConversationPosition : TutorialEntity
{
	[CompilerGenerated]
	private sealed class _003CWaitFrame_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntityConversationPosition _003C_003E4__this;

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
		public _003CWaitFrame_003Ed__20(int _003C_003E1__state)
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
	private TutorialIdent positionId;

	[SerializeField]
	private bool IsAutoNext;

	[SerializeField]
	private float AutoNextTime;

	[SerializeField]
	private Vector3 Padding;

	[SerializeField]
	private TutorialBalloon balloon;

	[SerializeField]
	private TutorialBalloon.arrayDir balloonDir;

	[SerializeField]
	private bool bTextAni;

	[SerializeField]
	private bool bXFix;

	[SerializeField]
	private bool IsUpdatePos;

	[SerializeField]
	private bool IsDelayActiveBalloon;

	public Text title;

	public Text context;

	public string TitleKey;

	public string TextKey;

	private RectTransform TouchArea;

	private bool isNext;

	private string contextOriginal;

	private Vector3 InitPos;

	private float paddingValue;

	public override void StartEntity()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitFrame_003Ed__20))]
	private IEnumerator WaitFrame()
	{
		return null;
	}

	private void Update()
	{
	}

	private void TextAllPrint()
	{
	}
}
