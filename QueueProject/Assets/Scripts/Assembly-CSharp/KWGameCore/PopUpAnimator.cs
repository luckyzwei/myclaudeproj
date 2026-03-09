using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace KWGameCore
{
	public class PopUpAnimator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFadeObjectToValue_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PopUpAnimator _003C_003E4__this;

			public KWEase.Type ease;

			public float time;

			public float value;

			private float _003CstartAlpha_003E5__2;

			private float _003Ctimer_003E5__3;

			private KWEase.EaseFunction _003CeaseFunction_003E5__4;

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
			public _003CFadeObjectToValue_003Ed__13(int _003C_003E1__state)
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
		private sealed class _003CIntro_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PopUpAnimator _003C_003E4__this;

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
			public _003CIntro_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003COutro_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PopUpAnimator _003C_003E4__this;

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
			public _003COutro_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CScaleObjectToValue_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PopUpAnimator _003C_003E4__this;

			public KWEase.Type ease;

			public float time;

			public Vector3 value;

			private Vector3 _003CstartScale_003E5__2;

			private float _003Ctimer_003E5__3;

			private KWEase.EaseFunction _003CeaseFunction_003E5__4;

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
			public _003CScaleObjectToValue_003Ed__14(int _003C_003E1__state)
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

		private const float ANIM_TIME_INTRO = 0.25f;

		private const float ANIM_TIME_OUTRO = 0.2f;

		[SerializeField]
		private GameObject m_scaleObject;

		[SerializeField]
		private CanvasGroup m_fadeObject;

		[SerializeField]
		private bool m_introOnStart;

		[Header("Actions")]
		[SerializeField]
		private UnityEvent m_introCompleteEvent;

		[SerializeField]
		private UnityEvent m_outroCompleteEvent;

		private Action m_introCompleteCallback;

		private Action m_outroCompleteCallback;

		private bool m_animating;

		private void Start()
		{
		}

		public void PlayIntro(Action onIntroCompleteCallback)
		{
		}

		[IteratorStateMachine(typeof(_003CIntro_003Ed__12))]
		private IEnumerator Intro()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFadeObjectToValue_003Ed__13))]
		private IEnumerator FadeObjectToValue(float value, float time, KWEase.Type ease)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CScaleObjectToValue_003Ed__14))]
		private IEnumerator ScaleObjectToValue(Vector3 value, float time, KWEase.Type ease)
		{
			return null;
		}

		public void PlayOutro(Action onOutroCompleteCallback)
		{
		}

		[IteratorStateMachine(typeof(_003COutro_003Ed__16))]
		private IEnumerator Outro()
		{
			return null;
		}

		private void OnIntroComplete()
		{
		}

		private void OnOutroComplete()
		{
		}
	}
}
