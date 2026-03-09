using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace KWCore.Utils
{
	public class AndroidDeviceSettings : DeviceSettings
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreatePlayStoreCountryClass_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public AndroidDeviceSettings _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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

		private const string CHINESE = "zh";

		private const string TRADITIONAL = "Hant";

		private const string TRADITIONAL_CHINESE = "zh_Hant";

		private const string SIMPLIFIED_CHINESE = "zh_Hans";

		private AndroidJavaClass m_androidLocationCls;

		private AndroidJavaObject m_androidPlayStoreCountryCls;

		public override void Initialise()
		{
		}

		private AndroidJavaClass GetLocationClass()
		{
			return null;
		}

		private AndroidJavaClass GetPermissionsClass()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreatePlayStoreCountryClass_003Ed__9))]
		private void CreatePlayStoreCountryClass()
		{
		}

		public override void RequestProductLocale(string productID)
		{
		}

		public override string GetLanguageCode()
		{
			return null;
		}

		public override void OnReceivedStoreCountryCode(string countryCode)
		{
		}

		public override List<InstalledKeyboard> GetKeyboards()
		{
			return null;
		}

		public override string GetMobileNetworkRegion()
		{
			return null;
		}

		public override bool HasStoragePermission()
		{
			return false;
		}

		public override void RequestStoragePermision(string title, string body, string okay)
		{
		}

		public override bool RunAdvertisingIdPlugin(AdvertisingIdCallback callback)
		{
			return false;
		}
	}
}
