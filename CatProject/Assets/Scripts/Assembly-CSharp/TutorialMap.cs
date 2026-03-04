using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TutorialMap : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRun_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialMap _003C_003E4__this;

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
		public _003CRun_003Ed__11(int _003C_003E1__state)
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
	private Button skipBtn;

	private Queue<TutorialEntity> scenario;

	private Queue<TutorialIdent> ActiveObjIds;

	private int tutoNum;

	private int scenarioSize;

	private int scenarioCurSize;

	private bool isSkip;

	private TutorialEntity curEntity;

	public Action skipAction;

	private void Awake()
	{
	}

	public void Init(int Tuto_Idx)
	{
	}

	public void StartMap()
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__11))]
	private IEnumerator Run()
	{
		yield break;
	}

	private void OnClickSkip()
	{
	}
}
