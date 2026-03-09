using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KWGameCore
{
	public static class CoroutineUtils
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delayInSeconds;

			public Action finishedCallback;

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
			public _003CDelay_003Ed__0(int _003C_003E1__state)
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
		private sealed class _003CDelayRealtime_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delayInSeconds;

			public Action finishedCallback;

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
			public _003CDelayRealtime_003Ed__1(int _003C_003E1__state)
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
		private sealed class _003CLerpAlpha_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Color color;

			public float startAlpha;

			public float endAlpha;

			public float duration;

			public Action<Color> valueChangedCallback;

			public AnimationCurve curve;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpAlpha_003Ed__37(int _003C_003E1__state)
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
		private sealed class _003CLerpAlpha_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Color color;

			public float startAlpha;

			public float endAlpha;

			public float duration;

			public Action<Color> valueChangedCallback;

			public KWEase.Type type;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpAlpha_003Ed__38(int _003C_003E1__state)
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
		private sealed class _003CLerpColour_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KWEase.Type type;

			public Color startColour;

			public Color endColour;

			public float duration;

			public Action<Color> valueChangedCallback;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpColour_003Ed__26(int _003C_003E1__state)
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
		private sealed class _003CLerpColour_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public Color startColour;

			public Color endColour;

			public float duration;

			public Action<Color> valueChangedCallback;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpColour_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CLerpColourInternal_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Color startColour;

			public bool unscaledTime;

			public bool clamp;

			public float duration;

			public KWEase.EaseFunction function;

			public Color endColour;

			public Action<Color> valueChangedCallback;

			public Action finishedCallback;

			private float _003Cdelta_003E5__2;

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
			public _003CLerpColourInternal_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CLerpFloat_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KWEase.Type type;

			public float startValue;

			public float endValue;

			public float duration;

			public Action<float> valueChangedCallback;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpFloat_003Ed__20(int _003C_003E1__state)
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
		private sealed class _003CLerpFloat_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public float startValue;

			public float endValue;

			public float duration;

			public Action<float> valueChangedCallback;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpFloat_003Ed__21(int _003C_003E1__state)
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
		private sealed class _003CLerpFloatInternal_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool unscaledTime;

			public bool clamp;

			public float duration;

			public KWEase.EaseFunction function;

			public float startValue;

			public float endValue;

			public Action<float> valueChangedCallback;

			public Action finishedCallback;

			private float _003Cdelta_003E5__2;

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
			public _003CLerpFloatInternal_003Ed__22(int _003C_003E1__state)
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
		private sealed class _003CLerpGraphicColour_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Graphic graphic;

			public Action<Color> onValueChanged;

			public KWEase.Type type;

			public Color startColour;

			public Color endColour;

			public float duration;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpGraphicColour_003Ed__29(int _003C_003E1__state)
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
		private sealed class _003CLerpGraphicColour_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Graphic graphic;

			public Action<Color> onValueChanged;

			public AnimationCurve curve;

			public Color startColour;

			public Color endColour;

			public float duration;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpGraphicColour_003Ed__30(int _003C_003E1__state)
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
		private sealed class _003CLerpMaterialColour_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Material material;

			public Action<Color> onValueChanged;

			public KWEase.Type type;

			public Color startColour;

			public Color endColour;

			public float duration;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpMaterialColour_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CLerpMaterialColour_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Material material;

			public Action<Color> onValueChanged;

			public AnimationCurve curve;

			public Color startColour;

			public Color endColour;

			public float duration;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpMaterialColour_003Ed__34(int _003C_003E1__state)
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
		private sealed class _003CLerpSpriteColour_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpriteRenderer sprite;

			public Action<Color> onValueChanged;

			public KWEase.Type type;

			public Color startColour;

			public Color endColour;

			public float duration;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpSpriteColour_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CLerpSpriteColour_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpriteRenderer sprite;

			public Action<Color> onValueChanged;

			public AnimationCurve curve;

			public Color startColour;

			public Color endColour;

			public float duration;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpSpriteColour_003Ed__32(int _003C_003E1__state)
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
		private sealed class _003CLerpVector_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KWEase.Type type;

			public Vector3 startValue;

			public Vector3 endValue;

			public float duration;

			public Action<Vector3> valueChangedCallback;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpVector_003Ed__23(int _003C_003E1__state)
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
		private sealed class _003CLerpVector_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public Vector3 startValue;

			public Vector3 endValue;

			public float duration;

			public Action<Vector3> valueChangedCallback;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CLerpVector_003Ed__24(int _003C_003E1__state)
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
		private sealed class _003CLerpVectorInternal_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool unscaledTime;

			public bool clamp;

			public float duration;

			public KWEase.EaseFunction function;

			public Vector3 startValue;

			public Vector3 endValue;

			public Action<Vector3> valueChangedCallback;

			public Action finishedCallback;

			private float _003Cdelta_003E5__2;

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
			public _003CLerpVectorInternal_003Ed__25(int _003C_003E1__state)
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
		private sealed class _003CMoveTo_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KWEase.Type type;

			public Transform transform;

			public Vector3 origin;

			public Vector3 target;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CMoveTo_003Ed__4(int _003C_003E1__state)
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
		private sealed class _003CMoveTo_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public Transform transform;

			public Vector3 origin;

			public Vector3 target;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CMoveTo_003Ed__5(int _003C_003E1__state)
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
		private sealed class _003CMoveToInternal_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool unscaledTime;

			public bool clamp;

			public float duration;

			public KWEase.EaseFunction function;

			public Vector3 origin;

			public Vector3 target;

			public bool isLocal;

			public Transform transform;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			private float _003Cdelta_003E5__2;

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
			public _003CMoveToInternal_003Ed__8(int _003C_003E1__state)
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
		private sealed class _003CMoveToLocal_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KWEase.Type type;

			public Transform transform;

			public Vector3 origin;

			public Vector3 target;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CMoveToLocal_003Ed__6(int _003C_003E1__state)
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
		private sealed class _003CMoveToLocal_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public Transform transform;

			public Vector3 origin;

			public Vector3 target;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CMoveToLocal_003Ed__7(int _003C_003E1__state)
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
		private sealed class _003CRotate_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KWEase.Type type;

			public Transform transform;

			public Vector3 targetRot;

			public float rotationSpeed;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool unscaledTime;

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
			public _003CRotate_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CRotate_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public Transform transform;

			public Vector3 targetRot;

			public float rotationSpeed;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool unscaledTime;

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
			public _003CRotate_003Ed__13(int _003C_003E1__state)
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
		private sealed class _003CRotateInternal_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform transform;

			public Vector3 targetRot;

			public KWEase.EaseFunction function;

			public Action<Vector3> onValueChanged;

			public bool unscaledTime;

			public float rotationSpeed;

			public Action finishedCallback;

			private Quaternion _003ColdRotation_003E5__2;

			private Quaternion _003CnewRotation_003E5__3;

			private float _003Ct_003E5__4;

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
			public _003CRotateInternal_003Ed__14(int _003C_003E1__state)
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
		private sealed class _003CRotateTo_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KWEase.Type type;

			public Transform transform;

			public Vector3 targetRot;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CRotateTo_003Ed__15(int _003C_003E1__state)
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
		private sealed class _003CRotateTo_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public Transform transform;

			public Vector3 targetRot;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CRotateTo_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CRotateToInternal_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform transform;

			public bool isLocal;

			public Vector3 targetRot;

			public bool unscaledTime;

			public float duration;

			public KWEase.EaseFunction function;

			public bool clamp;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			private Quaternion _003CstartRotation_003E5__2;

			private Quaternion _003CendRotation_003E5__3;

			private float _003Ctime_003E5__4;

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
			public _003CRotateToInternal_003Ed__19(int _003C_003E1__state)
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
		private sealed class _003CRotateToLocal_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KWEase.Type type;

			public Transform transform;

			public Vector3 targetRot;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CRotateToLocal_003Ed__17(int _003C_003E1__state)
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
		private sealed class _003CRotateToLocal_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public Transform transform;

			public Vector3 targetRot;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CRotateToLocal_003Ed__18(int _003C_003E1__state)
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
		private sealed class _003CScaleTo_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationCurve curve;

			public Transform transform;

			public Vector3 startScale;

			public Vector3 endScale;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CScaleTo_003Ed__10(int _003C_003E1__state)
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
		private sealed class _003CScaleTo_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KWEase.Type type;

			public Transform transform;

			public Vector3 startScale;

			public Vector3 endScale;

			public float duration;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			public bool clamp;

			public bool unscaledTime;

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
			public _003CScaleTo_003Ed__9(int _003C_003E1__state)
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
		private sealed class _003CScaleToInternal_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool unscaledTime;

			public bool clamp;

			public float duration;

			public KWEase.EaseFunction function;

			public Vector3 startScale;

			public Vector3 endScale;

			public Transform transform;

			public Action<Vector3> onValueChanged;

			public Action finishedCallback;

			private float _003Cdelta_003E5__2;

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
			public _003CScaleToInternal_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CWaitForEndOfFrame_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action finishedCallback;

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
			public _003CWaitForEndOfFrame_003Ed__3(int _003C_003E1__state)
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
		private sealed class _003CWaitFrames_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int frames;

			public Action finishedCallback;

			private int _003Ct_003E5__2;

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
			public _003CWaitFrames_003Ed__2(int _003C_003E1__state)
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

		[IteratorStateMachine(typeof(_003CDelay_003Ed__0))]
		public static IEnumerator Delay(float delayInSeconds, Action finishedCallback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelayRealtime_003Ed__1))]
		public static IEnumerator DelayRealtime(float delayInSeconds, Action finishedCallback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitFrames_003Ed__2))]
		public static IEnumerator WaitFrames(int frames, Action finishedCallback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitForEndOfFrame_003Ed__3))]
		public static IEnumerator WaitForEndOfFrame(Action finishedCallback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMoveTo_003Ed__4))]
		public static IEnumerator MoveTo(Transform transform, Vector3 origin, Vector3 target, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMoveTo_003Ed__5))]
		public static IEnumerator MoveTo(Transform transform, Vector3 origin, Vector3 target, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMoveToLocal_003Ed__6))]
		public static IEnumerator MoveToLocal(Transform transform, Vector3 origin, Vector3 target, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMoveToLocal_003Ed__7))]
		public static IEnumerator MoveToLocal(Transform transform, Vector3 origin, Vector3 target, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMoveToInternal_003Ed__8))]
		private static IEnumerator MoveToInternal(bool isLocal, Transform transform, Vector3 origin, Vector3 target, float duration, KWEase.EaseFunction function, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CScaleTo_003Ed__9))]
		public static IEnumerator ScaleTo(Transform transform, Vector3 startScale, Vector3 endScale, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CScaleTo_003Ed__10))]
		public static IEnumerator ScaleTo(Transform transform, Vector3 startScale, Vector3 endScale, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CScaleToInternal_003Ed__11))]
		private static IEnumerator ScaleToInternal(Transform transform, Vector3 startScale, Vector3 endScale, float duration, KWEase.EaseFunction function, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRotate_003Ed__12))]
		public static IEnumerator Rotate(Transform transform, Vector3 targetRot, float rotationSpeed, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRotate_003Ed__13))]
		public static IEnumerator Rotate(Transform transform, Vector3 targetRot, float rotationSpeed, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRotateInternal_003Ed__14))]
		private static IEnumerator RotateInternal(Transform transform, Vector3 targetRot, float rotationSpeed, KWEase.EaseFunction function, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRotateTo_003Ed__15))]
		public static IEnumerator RotateTo(Transform transform, Vector3 targetRot, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRotateTo_003Ed__16))]
		public static IEnumerator RotateTo(Transform transform, Vector3 targetRot, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRotateToLocal_003Ed__17))]
		public static IEnumerator RotateToLocal(Transform transform, Vector3 targetRot, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRotateToLocal_003Ed__18))]
		public static IEnumerator RotateToLocal(Transform transform, Vector3 targetRot, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRotateToInternal_003Ed__19))]
		private static IEnumerator RotateToInternal(bool isLocal, Transform transform, Vector3 targetRot, float duration, KWEase.EaseFunction function, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpFloat_003Ed__20))]
		public static IEnumerator LerpFloat(float startValue, float endValue, float duration, Action<float> valueChangedCallback, Action finishedCallback = null, KWEase.Type type = KWEase.Type.LINEAR, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpFloat_003Ed__21))]
		public static IEnumerator LerpFloat(float startValue, float endValue, float duration, Action<float> valueChangedCallback, Action finishedCallback = null, AnimationCurve curve = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpFloatInternal_003Ed__22))]
		private static IEnumerator LerpFloatInternal(float startValue, float endValue, float duration, KWEase.EaseFunction function, Action<float> valueChangedCallback, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpVector_003Ed__23))]
		public static IEnumerator LerpVector(Vector3 startValue, Vector3 endValue, float duration, Action<Vector3> valueChangedCallback, KWEase.Type type = KWEase.Type.LINEAR, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpVector_003Ed__24))]
		public static IEnumerator LerpVector(Vector3 startValue, Vector3 endValue, float duration, Action<Vector3> valueChangedCallback, AnimationCurve curve = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpVectorInternal_003Ed__25))]
		private static IEnumerator LerpVectorInternal(Vector3 startValue, Vector3 endValue, float duration, KWEase.EaseFunction function, Action<Vector3> valueChangedCallback, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpColour_003Ed__26))]
		public static IEnumerator LerpColour(Color startColour, Color endColour, float duration, Action<Color> valueChangedCallback, KWEase.Type type = KWEase.Type.LINEAR, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpColour_003Ed__27))]
		public static IEnumerator LerpColour(Color startColour, Color endColour, float duration, Action<Color> valueChangedCallback, AnimationCurve curve = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpColourInternal_003Ed__28))]
		private static IEnumerator LerpColourInternal(Color startColour, Color endColour, float duration, KWEase.EaseFunction function, Action<Color> valueChangedCallback, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpGraphicColour_003Ed__29))]
		public static IEnumerator LerpGraphicColour(Graphic graphic, Color startColour, Color endColour, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpGraphicColour_003Ed__30))]
		public static IEnumerator LerpGraphicColour(Graphic graphic, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpSpriteColour_003Ed__31))]
		public static IEnumerator LerpSpriteColour(SpriteRenderer sprite, Color startColour, Color endColour, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpSpriteColour_003Ed__32))]
		public static IEnumerator LerpSpriteColour(SpriteRenderer sprite, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpMaterialColour_003Ed__33))]
		public static IEnumerator LerpMaterialColour(Material material, Color startColour, Color endColour, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpMaterialColour_003Ed__34))]
		public static IEnumerator LerpMaterialColour(Material material, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpRendererColour(Renderer renderer, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpRendererColour(Renderer renderer, Color startColour, Color endColour, float duration, KWEase.Type type, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpAlpha_003Ed__37))]
		public static IEnumerator LerpAlpha(Color color, float startAlpha, float endAlpha, float duration, Action<Color> valueChangedCallback, AnimationCurve curve = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLerpAlpha_003Ed__38))]
		public static IEnumerator LerpAlpha(Color color, float startAlpha, float endAlpha, float duration, Action<Color> valueChangedCallback, KWEase.Type type = KWEase.Type.LINEAR, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpAlpha(Graphic graphic, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpAlpha(Graphic graphic, float startAlpha, float endAlpha, float duration, AnimationCurve curve, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpAlpha(Material material, float startAlpha, float endAlpha, float duration, AnimationCurve curve = null, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpAlpha(Material material, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpAlpha(Renderer renderer, float startAlpha, float endAlpha, float duration, AnimationCurve curve = null, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpAlpha(Renderer renderer, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpAlpha(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}

		public static IEnumerator LerpAlpha(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration, AnimationCurve curve = null, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return null;
		}
	}
}
