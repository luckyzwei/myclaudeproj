using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KWHaptics.Haptics
{
	public class HapticsManager : MonoBehaviour
	{
		public enum HapticType
		{
			SELECTION = 0,
			LIGHT = 1,
			MEDIUM = 2,
			HEAVY = 3,
			NOTIFICATION = 4,
			SUCCESS = 5,
			WARNING = 6,
			FAIL = 7
		}

		public enum HapticIntensityDir
		{
			Flat = 0,
			Ascending = 1,
			Descending = -1
		}

		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public Action callback;

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
			public _003CDelay_003Ed__21(int _003C_003E1__state)
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
		private sealed class _003CPlayBurstSequence_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HapticType hapticType;

			public HapticIntensityDir intensityDir;

			public int hapticBurstCount;

			public float timeBetweenHaptics;

			public float length;

			public HapticsManager _003C_003E4__this;

			public bool useRealTime;

			public Action onComplete;

			private bool _003ChasIntensityChange_003E5__2;

			private int _003CstartIntensity_003E5__3;

			private int _003CendIntensity_003E5__4;

			private float _003Cdelay_003E5__5;

			private int _003Ci_003E5__6;

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
			public _003CPlayBurstSequence_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CPlaySeemlessHaptic_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HapticsManager _003C_003E4__this;

			public HapticType type;

			public bool useRealTime;

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
			public _003CPlaySeemlessHaptic_003Ed__20(int _003C_003E1__state)
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
		private sealed class _003CStartContinuousHapticsCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HapticsManager _003C_003E4__this;

			public HapticType type;

			public bool useRealTime;

			public float duration;

			public float delay;

			private float _003CtriggerTime_003E5__2;

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
			public _003CStartContinuousHapticsCoroutine_003Ed__19(int _003C_003E1__state)
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

		private const float HAPTICS_INTERVAL = 0.06f;

		private HapticsBase m_haptics;

		private Coroutine m_continousHapticsCoroutine;

		private Coroutine m_burstHapticsCoroutine;

		private bool m_supported;

		private bool m_autoTriggerOnUIClicks;

		public bool Enabled => false;

		public bool Supported => false;

		public bool AutoTriggerOnUIClicks
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Initialise()
		{
		}

		public void SetHapticsEnable(bool enableHaptics)
		{
		}

		public void Trigger(HapticType type)
		{
		}

		public void TriggerForDuration(HapticType type, float totalDuration = 0f, float burstDuration = 0f, float delay = 0f, bool useRealTime = false, Action callback = null)
		{
		}

		[IteratorStateMachine(typeof(_003CStartContinuousHapticsCoroutine_003Ed__19))]
		private IEnumerator StartContinuousHapticsCoroutine(HapticType type, float duration, float delay, bool useRealTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPlaySeemlessHaptic_003Ed__20))]
		private IEnumerator PlaySeemlessHaptic(HapticType type, bool useRealTime)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__21))]
		private IEnumerator Delay(float delay, Action callback)
		{
			return null;
		}

		public void StopBurstHaptics()
		{
		}

		public void StopContinuousHaptics()
		{
		}

		public void StopAllContinousHaptics()
		{
		}

		public void TriggerBurst(int hapticBurstAmount = 15, float timeBetweenHapticsBurst = 0.1f, HapticType hapticType = HapticType.MEDIUM, bool useRealTime = false, Action onComplete = null)
		{
		}

		public void TriggerBurst(int hapticBurstAmount, float timeBetweenHapticsBurst = 0.1f, HapticType hapticType = HapticType.MEDIUM, HapticIntensityDir intensityDir = HapticIntensityDir.Flat, bool useRealTime = false, Action onComplete = null)
		{
		}

		public void TriggerBurst(int hapticBurstAmount, float length, float timeBetweenHapticsBurst, HapticType hapticType = HapticType.MEDIUM, HapticIntensityDir intensityDir = HapticIntensityDir.Flat, bool useRealTime = false, Action onComplete = null)
		{
		}

		[IteratorStateMachine(typeof(_003CPlayBurstSequence_003Ed__28))]
		private IEnumerator PlayBurstSequence(int hapticBurstCount, float length, float timeBetweenHaptics, HapticType hapticType, HapticIntensityDir intensityDir, bool useRealTime, Action onComplete = null)
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
