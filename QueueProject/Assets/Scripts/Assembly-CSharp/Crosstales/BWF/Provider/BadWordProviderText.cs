using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crosstales.BWF.Data;
using UnityEngine;
using UnityEngine.Networking;

namespace Crosstales.BWF.Provider
{
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_provider_1_1_bad_word_provider_text.html")]
	public class BadWordProviderText : BadWordProvider
	{
		[CompilerGenerated]
		private sealed class _003CloadResource_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BadWordProviderText _003C_003E4__this;

			public Source src;

			private string _003Cuid_003E5__2;

			private List<string> _003Clist_003E5__3;

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
			public _003CloadResource_003Ed__4(int _003C_003E1__state)
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
		private sealed class _003CloadWeb_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BadWordProviderText _003C_003E4__this;

			public Source src;

			private string _003Cuid_003E5__2;

			private UnityWebRequest _003Cwww_003E5__3;

			private List<string> _003Clist_003E5__4;

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
			public _003CloadWeb_003Ed__3(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private bool _webSuccess;

		public override void Load()
		{
		}

		public override void Save()
		{
		}

		[IteratorStateMachine(typeof(_003CloadWeb_003Ed__3))]
		private IEnumerator loadWeb(Source src)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CloadResource_003Ed__4))]
		private IEnumerator loadResource(Source src)
		{
			return null;
		}
	}
}
