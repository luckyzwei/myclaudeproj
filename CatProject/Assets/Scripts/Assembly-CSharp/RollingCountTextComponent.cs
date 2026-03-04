using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RollingCountTextComponent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayCountCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int updateCountPerSec;

		public RollingCountTextComponent _003C_003E4__this;

		public bool useThousandsSeparator;

		public BigInteger targetCount;

		public BigInteger startCount;

		public float duration;

		private BigInteger _003CcurCount_003E5__2;

		private float _003CupdateDuration_003E5__3;

		private int _003CupdateCount_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CPlayCountCoroutine_003Ed__4(int _003C_003E1__state)
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

	private Text Text;

	private void Awake()
	{
	}

	public void SetText(string text)
	{
	}

	public void PlayCount(BigInteger startCount, BigInteger targetCount, float duration, bool useThousandsSeparator, int updateCountPerSec = 15)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayCountCoroutine_003Ed__4))]
	private IEnumerator PlayCountCoroutine(BigInteger startCount, BigInteger targetCount, float duration, bool useThousandsSeparator, int updateCountPerSec)
	{
		yield break;
	}
}
