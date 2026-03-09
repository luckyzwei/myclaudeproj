using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace KWPlayerProfile.WebImage
{
	public class WebImageWidget : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConfigure_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public string url;

			public WebImageWidget _003C_003E4__this;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[Header("WebImage")]
		[SerializeField]
		private Image m_image;

		public void Configure(Sprite image)
		{
		}

		[AsyncStateMachine(typeof(_003CConfigure_003Ed__2))]
		public void Configure(string url)
		{
		}

		protected virtual void OnSuccess(Sprite sprite)
		{
		}

		protected virtual void OnProgress(float progress)
		{
		}

		protected virtual void OnFail(string exception)
		{
		}
	}
}
