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
		public _003CPlayCountCoroutine_003Ed__4(int _003C_003E1__state)
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
					_003CupdateCount_003E5__4 = (int)(duration * updateCountPerSec);
					if (_003CupdateCount_003E5__4 <= 0) _003CupdateCount_003E5__4 = 1;
					_003CupdateDuration_003E5__3 = duration / _003CupdateCount_003E5__4;
					_003CcurCount_003E5__2 = startCount;
					_003Ci_003E5__5 = 0;
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					if (_003Ci_003E5__5 < _003CupdateCount_003E5__4)
					{
						float t = (float)(_003Ci_003E5__5 + 1) / _003CupdateCount_003E5__4;
						BigInteger diff = targetCount - startCount;
						_003CcurCount_003E5__2 = startCount + new BigInteger((float)diff * t);
						string text = useThousandsSeparator
							? ProjectUtility.GetThousandCommaText(_003CcurCount_003E5__2)
							: _003CcurCount_003E5__2.ToString();
						_003C_003E4__this.SetText(text);
						_003Ci_003E5__5++;
						_003C_003E2__current = new WaitForSeconds(_003CupdateDuration_003E5__3);
						_003C_003E1__state = 1;
						return true;
					}
					string finalText = useThousandsSeparator
						? ProjectUtility.GetThousandCommaText(targetCount)
						: targetCount.ToString();
					_003C_003E4__this.SetText(finalText);
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

	private Text Text;

	private void Awake()
	{
		Text = GetComponent<Text>();
	}

	public void SetText(string text)
	{
		if (Text != null)
			Text.text = text;
	}

	public void PlayCount(BigInteger startCount, BigInteger targetCount, float duration, bool useThousandsSeparator, int updateCountPerSec = 15)
	{
		StopAllCoroutines();
		StartCoroutine(PlayCountCoroutine(startCount, targetCount, duration, useThousandsSeparator, updateCountPerSec));
	}

	[IteratorStateMachine(typeof(_003CPlayCountCoroutine_003Ed__4))]
	private IEnumerator PlayCountCoroutine(BigInteger startCount, BigInteger targetCount, float duration, bool useThousandsSeparator, int updateCountPerSec)
	{
		var d = new _003CPlayCountCoroutine_003Ed__4(0);
		d._003C_003E4__this = this;
		d.startCount = startCount;
		d.targetCount = targetCount;
		d.duration = duration;
		d.useThousandsSeparator = useThousandsSeparator;
		d.updateCountPerSec = updateCountPerSec;
		return d;
	}
}
