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
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CRun_003Ed__11(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					if (_003C_003E4__this.scenario != null && _003C_003E4__this.scenario.Count > 0 && !_003C_003E4__this.isSkip)
					{
						_003C_003E4__this.curEntity = _003C_003E4__this.scenario.Dequeue();
						_003C_003E4__this.scenarioCurSize++;
						if (_003C_003E4__this.curEntity != null)
						{
							_003C_003E4__this.curEntity.StartEntity();
						_003C_003E2__current = new UnityEngine.WaitUntil(() => _003C_003E4__this.curEntity.Complete);
							_003C_003E1__state = 1;
							return true;
						}
						goto case 1;
					}
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
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
		if (skipBtn != null)
			skipBtn.onClick.AddListener(OnClickSkip);
	}

	public void Init(int Tuto_Idx)
	{
		tutoNum = Tuto_Idx;
		scenario = new Queue<TutorialEntity>();
		ActiveObjIds = new Queue<TutorialIdent>();
		scenarioSize = 0;
		scenarioCurSize = 0;
		isSkip = false;
		curEntity = null;
	}

	public void StartMap()
	{
		if (scenario == null || scenario.Count == 0) return;
		scenarioSize = scenario.Count;
		StartCoroutine(Run());
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__11))]
	private IEnumerator Run()
	{
		var d = new _003CRun_003Ed__11(0);
		d._003C_003E4__this = this;
		return d;
	}

	private void OnClickSkip()
	{
		isSkip = true;
		skipAction?.Invoke();
	}
}
