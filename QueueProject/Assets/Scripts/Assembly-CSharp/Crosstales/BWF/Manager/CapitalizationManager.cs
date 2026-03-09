using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Crosstales.BWF.Filter;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crosstales.BWF.Manager
{
	[DisallowMultipleComponent]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_manager_1_1_capitalization_manager.html")]
	public class CapitalizationManager : BaseManager<CapitalizationManager, CapitalizationFilter>
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			public CapitalizationManager _003C_003E4__this;

			public string text;

			public bool result;

			internal void _003CcontainsAsync_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			public CapitalizationManager _003C_003E4__this;

			public string text;

			public List<string> result;

			internal void _003CgetAllAsync_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			public CapitalizationManager _003C_003E4__this;

			public string text;

			public bool markOnly;

			public string prefix;

			public string postfix;

			public string result;

			internal void _003CreplaceAllAsync_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CcontainsAsync_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CapitalizationManager _003C_003E4__this;

			public string text;

			private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

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
			public _003CcontainsAsync_003Ed__26(int _003C_003E1__state)
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
		private sealed class _003CgetAllAsync_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CapitalizationManager _003C_003E4__this;

			public string text;

			private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

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
			public _003CgetAllAsync_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CreplaceAllAsync_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CapitalizationManager _003C_003E4__this;

			public string text;

			public bool markOnly;

			public string prefix;

			public string postfix;

			private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

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
			public _003CreplaceAllAsync_003Ed__28(int _003C_003E1__state)
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

		[FormerlySerializedAs("CapitalizationCharsNumber")]
		[Header("Specific Settings")]
		[Tooltip("Defines the number of allowed capital letters in a row. (default: 3).")]
		[SerializeField]
		private int capitalizationCharsNumber;

		[Header("Events")]
		public OnContainsCompleted OnContainsCompleted;

		public OnGetAllCompleted OnGetAllCompleted;

		public OnReplaceAllCompleted OnReplaceAllCompleted;

		private Thread _worker;

		public int CapitalizationCharsNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override OnContainsCompleted onContainsCompleted => null;

		protected override OnGetAllCompleted onGetAllCompleted => null;

		protected override OnReplaceAllCompleted onReplaceAllCompleted => null;

		protected override void Awake()
		{
		}

		protected override void OnApplicationQuit()
		{
		}

		private void OnValidate()
		{
		}

		public static void ResetObject()
		{
		}

		public void Load()
		{
		}

		public bool Contains(string text)
		{
			return false;
		}

		public void ContainsAsync(string text)
		{
		}

		public List<string> GetAll(string text)
		{
			return null;
		}

		public void GetAllAsync(string text)
		{
		}

		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}

		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
		}

		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CcontainsAsync_003Ed__26))]
		private IEnumerator containsAsync(string text)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CgetAllAsync_003Ed__27))]
		private IEnumerator getAllAsync(string text)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CreplaceAllAsync_003Ed__28))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}
	}
}
