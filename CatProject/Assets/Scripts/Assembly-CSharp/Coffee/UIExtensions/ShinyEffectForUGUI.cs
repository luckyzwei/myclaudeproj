using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class ShinyEffectForUGUI : BaseMeshEffect
	{
		private struct Matrix2x3
		{
			public float m00;

			public float m01;

			public float m02;

			public float m10;

			public float m11;

			public float m12;

			public Matrix2x3(Rect rect, float cos, float sin)
			{
				m00 = 0f;
				m01 = 0f;
				m02 = 0f;
				m10 = 0f;
				m11 = 0f;
				m12 = 0f;
			}

			public static Vector2 operator *(Matrix2x3 m, Vector2 v)
			{
				return default(Vector2);
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoPlay_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShinyEffectForUGUI _003C_003E4__this;

			public float duration;

			public AnimatorUpdateMode updateMode;

			private float _003Ctime_003E5__2;

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
			public _003CCoPlay_003Ed__40(int _003C_003E1__state)
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

		public const string shaderName = "UI/Hidden/UI-Effect-Shiny";

		[SerializeField]
		[Range(0f, 1f)]
		private float m_Location;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_Width;

		[SerializeField]
		[Range(0.01f, 1f)]
		private float m_Softness;

		[FormerlySerializedAs("m_Alpha")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_Brightness;

		[SerializeField]
		[Range(-180f, 180f)]
		private float m_Rotation;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_Highlight;

		[SerializeField]
		private Material m_EffectMaterial;

		public new Graphic graphic => null;

		public float location
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float softness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Use brightness instead (UnityUpgradable) -> brightness")]
		public float alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float brightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float highlight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual Material effectMaterial => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		public void Play()
		{
		}

		public void Play(float duration)
		{
		}

		public void Play(float duration, AnimatorUpdateMode updateMode)
		{
		}

		private void _SetDirty()
		{
		}

		[IteratorStateMachine(typeof(_003CCoPlay_003Ed__40))]
		private IEnumerator CoPlay(float duration, AnimatorUpdateMode updateMode = AnimatorUpdateMode.Normal)
		{
			return null;
		}

		private static float _PackToFloat(float x, float y, float z, float w)
		{
			return 0f;
		}

		private static float _PackToFloat(float x, float y)
		{
			return 0f;
		}
	}
}
