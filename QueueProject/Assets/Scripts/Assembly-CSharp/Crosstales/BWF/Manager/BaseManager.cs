using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Crosstales.BWF.Filter;
using Crosstales.Common.Util;
using UnityEngine;

namespace Crosstales.BWF.Manager
{
	[ExecuteInEditMode]
	public abstract class BaseManager<S, T> : Singleton<S> where S : Singleton<S> where T : BaseFilter
	{
		[Tooltip("Disables the ordering of the 'GetAll'-method (prevent possible memory garbage).")]
		[SerializeField]
		private bool disableOrdering;

		protected T _filter;

		public bool DisableOrdering
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isReady => false;

		protected abstract OnContainsCompleted onContainsCompleted { get; }

		protected abstract OnGetAllCompleted onGetAllCompleted { get; }

		protected abstract OnReplaceAllCompleted onReplaceAllCompleted { get; }

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

		private void Start()
		{
		}

		public string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		protected void onContainsComplete(string text, bool result)
		{
		}

		protected void onGetAllComplete(string text, List<string> badWords)
		{
		}

		protected void onReplaceAllComplete(string originalText, string cleanText)
		{
		}
	}
}
