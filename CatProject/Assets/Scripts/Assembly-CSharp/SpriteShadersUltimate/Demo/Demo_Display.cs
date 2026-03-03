using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpriteShadersUltimate.Demo
{
	public class Demo_Display : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCycleShader_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Demo_Display _003C_003E4__this;

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
			public _003CCycleShader_003Ed__19(int _003C_003E1__state)
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
		private sealed class _003CHandlePosition_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Demo_Display _003C_003E4__this;

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
			public _003CHandlePosition_003Ed__20(int _003C_003E1__state)
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

		public static Demo_Display selected;

		[Header("Material Settings:")]
		public string firstProperty;

		public bool ignorePlayer;

		public float cycleTime;

		private Transform shader;

		private Material frameMaterial;

		private bool isHovered;

		private float lastScale;

		private float activeUntil;

		private int mainIndex;

		private Renderer mainRenderer;

		private Material mainMaterial;

		private Transform extraSprites;

		private int row;

		private int slot;

		private int maxSlots;

		private float camWidth;

		private void Start()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CCycleShader_003Ed__19))]
		private IEnumerator CycleShader()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CHandlePosition_003Ed__20))]
		private IEnumerator HandlePosition()
		{
			return null;
		}

		private Transform GetMainSprite(int index)
		{
			return null;
		}

		public void ChangeIndex()
		{
		}

		public bool HasAlternatives()
		{
			return false;
		}

		public void UpdateIndex()
		{
		}

		private void OnMouseOver()
		{
		}

		private void OnMouseExit()
		{
		}

		private void OnMouseDown()
		{
		}

		public void Select()
		{
		}

		public void Deselect()
		{
		}

		public void ResetMaterial()
		{
		}

		public Material InstantiateMaterial()
		{
			return null;
		}

		private void UpdatePosition()
		{
		}
	}
}
