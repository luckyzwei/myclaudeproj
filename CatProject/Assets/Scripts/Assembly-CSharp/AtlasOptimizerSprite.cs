using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AtlasOptimizerSprite : MonoBehaviour
{
	public enum AtlasType
	{
		BG = 0,
		Stage = 1,
		Character = 2,
		Seasonal_BG = 3,
		BizAcquisition = 4
	}

	[CompilerGenerated]
	private sealed class _003CSetSprite_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AtlasOptimizerSprite _003C_003E4__this;

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
		public _003CSetSprite_003Ed__6(int _003C_003E1__state)
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

	public AtlasType loadType;

	public static int CallCount;

	private Coroutine Coroutine;

	private void Awake()
	{
		CallCount++;
		Coroutine = StartCoroutine(SetSprite());
	}

	private float GetWaitTime()
	{
		// Stagger load time based on call count to avoid frame spikes
		return CallCount * 0.01f;
	}

	[IteratorStateMachine(typeof(_003CSetSprite_003Ed__6))]
	private IEnumerator SetSprite()
	{
		float waitTime = GetWaitTime();
		if (waitTime > 0f)
			yield return new WaitForSeconds(waitTime);
		// Load sprite from atlas based on loadType
		CallCount--;
	}

	private void OnDestroy()
	{
		if (Coroutine != null)
		{
			StopCoroutine(Coroutine);
			Coroutine = null;
		}
	}
}
