using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Crosstales.BWF.Data;
using Crosstales.BWF.Model.Enum;
using Crosstales.Common.Util;
using UnityEngine;

namespace Crosstales.BWF
{
	[ExecuteInEditMode]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_b_w_f_manager.html")]
	public class BWFManager : Singleton<BWFManager>
	{
		public delegate void BWFReady();

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass40_0
		{
			public string text;

			public ManagerMask mask;

			public string[] sourceNames;

			public bool result;

			internal void _003CcontainsAsync_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass41_0
		{
			public string text;

			public ManagerMask mask;

			public string[] sourceNames;

			public List<string> result;

			internal void _003CgetAllAsync_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass42_0
		{
			public string text;

			public ManagerMask mask;

			public bool markOnly;

			public string prefix;

			public string postfix;

			public string[] sourceNames;

			public string result;

			internal void _003CreplaceAllAsync_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CcontainsAsync_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string text;

			public ManagerMask mask;

			public string[] sourceNames;

			public BWFManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

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
			public _003CcontainsAsync_003Ed__40(int _003C_003E1__state)
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
		private sealed class _003CgetAllAsync_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string text;

			public ManagerMask mask;

			public string[] sourceNames;

			public BWFManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

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
			public _003CgetAllAsync_003Ed__41(int _003C_003E1__state)
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
		private sealed class _003CreplaceAllAsync_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string text;

			public ManagerMask mask;

			public bool markOnly;

			public string prefix;

			public string postfix;

			public string[] sourceNames;

			public BWFManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

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
			public _003CreplaceAllAsync_003Ed__42(int _003C_003E1__state)
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

		[Tooltip("Disables the ordering of the 'GetAll'-method (prevent possible memory garbage).")]
		public bool DisableOrdering;

		private bool _sentReady;

		private Thread _worker;

		private readonly List<string> _getAllResult;

		[Header("Events")]
		public OnReady OnReady;

		public OnContainsCompleted OnContainsCompleted;

		public OnGetAllCompleted OnGetAllCompleted;

		public OnReplaceAllCompleted OnReplaceAllCompleted;

		public bool isReady => false;

		public int TotalRegexCount => 0;

		public event BWFReady OnBWFReady
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event ContainsComplete OnContainsComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event GetAllComplete OnGetAllComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event ReplaceAllComplete OnReplaceAllComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void OnApplicationQuit()
		{
		}

		private void Update()
		{
		}

		public void Load(ManagerMask mask = ManagerMask.All)
		{
		}

		public List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		public bool Contains(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return false;
		}

		public void ContainsAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		public List<string> GetAll(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		public void GetAllAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		public string ReplaceAll(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		public string ReplaceAll(string text, ManagerMask mask, bool markOnly, string prefix, string postfix, params string[] sourceNames)
		{
			return null;
		}

		public void ReplaceAllAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		public void ReplaceAllAsync(string text, ManagerMask mask, bool markOnly, string prefix, string postfix, params string[] sourceNames)
		{
		}

		public string Mark(string text, List<string> unwantedWords, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		public string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CcontainsAsync_003Ed__40))]
		private IEnumerator containsAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CgetAllAsync_003Ed__41))]
		private IEnumerator getAllAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CreplaceAllAsync_003Ed__42))]
		private IEnumerator replaceAllAsync(string text, ManagerMask mask = ManagerMask.All, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		private static void contains(out bool result, string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			result = default(bool);
		}

		private static void getAll(out List<string> result, string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			result = null;
		}

		private static void replaceAll(out string result, string text, ManagerMask mask = ManagerMask.All, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			result = null;
		}

		private void onBWFReady()
		{
		}

		private void onContainsComplete(string text, bool result)
		{
		}

		private void onGetAllComplete(string text, List<string> badWords)
		{
		}

		private void onReplaceAllComplete(string originalText, string cleanText)
		{
		}
	}
}
