using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LaunchingPad : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitDelay_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LaunchingPad _003C_003E4__this;

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
		public _003CWaitDelay_003Ed__12(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWaitInit_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CWaitInit_003Ed__13(int _003C_003E1__state)
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

	public Transform addSlotBtnTrans;

	[SerializeField]
	private Animation ani;

	[SerializeField]
	private float delayTime;

	[SerializeField]
	private int floor;

	[SerializeField]
	private int slotIdx;

	[SerializeField]
	private List<SpriteRenderer> targetSRs;

	[SerializeField]
	private Material grayScaleMat;

	private Material originMat;

	private Action MoveCallback;

	public void Shot(Action moveCallback)
	{
		MoveCallback = moveCallback;
		StartCoroutine(WaitDelay());
	}

	public void SetEnable(bool value)
	{
		// 그레이스케일 / 컬러 전환
		if (targetSRs == null) return;
		for (int i = 0; i < targetSRs.Count; i++)
		{
			if (targetSRs[i] == null) continue;
			targetSRs[i].material = value ? originMat : grayScaleMat;
		}
	}

	private void Awake()
	{
		// 원본 머티리얼 저장
		if (targetSRs != null && targetSRs.Count > 0 && targetSRs[0] != null)
		{
			originMat = targetSRs[0].material;
		}
		StartCoroutine(WaitInit());
	}

	[IteratorStateMachine(typeof(_003CWaitDelay_003Ed__12))]
	private IEnumerator WaitDelay()
	{
		// 딜레이 후 애니메이션 재생
		if (delayTime > 0f)
			yield return new WaitForSeconds(delayTime);
		if (ani != null)
			ani.Play();
		// 애니메이션 완료 후 콜백
		if (ani != null && ani.clip != null)
			yield return new WaitForSeconds(ani.clip.length);
		MoveCallback?.Invoke();
		MoveCallback = null;
	}

	[IteratorStateMachine(typeof(_003CWaitInit_003Ed__13))]
	private IEnumerator WaitInit()
	{
		yield return null;
		// 초기화 대기 후 활성화 상태 설정
		SetEnable(true);
	}
}
