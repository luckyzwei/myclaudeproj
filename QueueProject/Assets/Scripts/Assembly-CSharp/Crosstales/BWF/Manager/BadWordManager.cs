using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Crosstales.BWF.Data;
using Crosstales.BWF.Filter;
using Crosstales.BWF.Model.Enum;
using Crosstales.BWF.Provider;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crosstales.BWF.Manager
{
	[DisallowMultipleComponent]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_manager_1_1_bad_word_manager.html")]
	public class BadWordManager : BaseManager<BadWordManager, BadWordFilter>
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass58_0
		{
			public BadWordManager _003C_003E4__this;

			public string text;

			public string[] sourceNames;

			public bool result;

			internal void _003CcontainsAsync_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass59_0
		{
			public BadWordManager _003C_003E4__this;

			public string text;

			public string[] sourceNames;

			public List<string> result;

			internal void _003CgetAllAsync_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass60_0
		{
			public BadWordManager _003C_003E4__this;

			public string text;

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
		private sealed class _003CcontainsAsync_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BadWordManager _003C_003E4__this;

			public string text;

			public string[] sourceNames;

			private _003C_003Ec__DisplayClass58_0 _003C_003E8__1;

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
			public _003CcontainsAsync_003Ed__58(int _003C_003E1__state)
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
		private sealed class _003CgetAllAsync_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BadWordManager _003C_003E4__this;

			public string text;

			public string[] sourceNames;

			private _003C_003Ec__DisplayClass59_0 _003C_003E8__1;

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
			public _003CgetAllAsync_003Ed__59(int _003C_003E1__state)
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
		private sealed class _003CreplaceAllAsync_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BadWordManager _003C_003E4__this;

			public string text;

			public bool markOnly;

			public string prefix;

			public string postfix;

			public string[] sourceNames;

			private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

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
			public _003CreplaceAllAsync_003Ed__60(int _003C_003E1__state)
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

		[FormerlySerializedAs("ReplaceChars")]
		[Header("Specific Settings")]
		[Tooltip("Replace characters for bad words (default: *).")]
		[SerializeField]
		private string replaceChars;

		[Tooltip("Replace mode operations on the input string (default: Default).")]
		[SerializeField]
		private ReplaceMode mode;

		[Tooltip("Remove unnecessary spaces between letters in the input string (default: false).")]
		[SerializeField]
		private bool removeSpaces;

		[Tooltip("Maximal text length for the space detection (default: 3).")]
		[SerializeField]
		private int maxTextLength;

		public string removeChars;

		[FormerlySerializedAs("SimpleCheck")]
		[Tooltip("Use simple detection algorithm. This is the way to check for Chinese, Japanese, Korean and Thai bad words (default: false).")]
		[SerializeField]
		private bool simpleCheck;

		[FormerlySerializedAs("BadWordProviderLTR")]
		[Header("Bad Word Providers")]
		[Tooltip("List of all left-to-right providers.")]
		[SerializeField]
		private List<BadWordProvider> badWordProviderLTR;

		[FormerlySerializedAs("BadWordProviderRTL")]
		[Tooltip("List of all right-to-left providers.")]
		[SerializeField]
		private List<BadWordProvider> badWordProviderRTL;

		[Header("Events")]
		public OnContainsCompleted OnContainsCompleted;

		public OnGetAllCompleted OnGetAllCompleted;

		public OnReplaceAllCompleted OnReplaceAllCompleted;

		private Thread _worker;

		public string ReplaceChars
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReplaceMode Mode
		{
			get
			{
				return default(ReplaceMode);
			}
			set
			{
			}
		}

		public bool RemoveSpaces
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int MaxTextLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string RemoveChars
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool SimpleCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<BadWordProvider> BadWordProviderLTR
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<BadWordProvider> BadWordProviderRTL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Source> Sources => null;

		public int TotalRegexCount => 0;

		protected override OnContainsCompleted onContainsCompleted => null;

		protected override OnGetAllCompleted onGetAllCompleted => null;

		protected override OnReplaceAllCompleted onReplaceAllCompleted => null;

		protected override void Awake()
		{
		}

		private void OnValidate()
		{
		}

		protected override void OnApplicationQuit()
		{
		}

		public static void ResetObject()
		{
		}

		public void Load()
		{
		}

		public bool Contains(string text, params string[] sourceNames)
		{
			return false;
		}

		public void ContainsAsync(string text, params string[] sourceNames)
		{
		}

		public List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		public void GetAllAsync(string text, params string[] sourceNames)
		{
		}

		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
		}

		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", params string[] sourceNames)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CcontainsAsync_003Ed__58))]
		private IEnumerator containsAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CgetAllAsync_003Ed__59))]
		private IEnumerator getAllAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CreplaceAllAsync_003Ed__60))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}
	}
}
