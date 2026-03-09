using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro.System;
using Nakama;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Hiro.Unity
{
	public sealed class UnityPurchasingSystem : IInitializeSystem, ISystem, IStoreListener, IDetailedStoreListener
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UnityPurchasingSystem _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<Task> _003C_003Eu__2;

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

		public const string EmptyLocalizedProductPrice = "???";

		private IExtensionProvider _extensionProvider;

		private TaskCompletionSource<PurchaseEventArgs> _purchaseInitiatedTask;

		private IStoreController _storeController;

		private readonly EconomySystem _economySystem;

		private readonly TaskCompletionSource<bool> _initializeTask;

		private readonly Nakama.ILogger _logger;

		public bool IsInitialized => false;

		public IStoreController StoreController => null;

		public string Name => null;

		public UnityPurchasingSystem(Nakama.ILogger logger, EconomySystem economySystem)
		{
		}

		public Task AddProductsAsync(IEnumerable<ProductDefinition> productDefinitions)
		{
			return null;
		}

		public Task<PurchaseEventArgs> BuyProductAsync(IEconomyListStoreItem storeItem)
		{
			return null;
		}

		public Task<PurchaseEventArgs> BuyProductByIdAsync(string productId)
		{
			return null;
		}

		public string GetLocalizedProductPrice(IEconomyListStoreItem storeItem)
		{
			return null;
		}

		public string GetLocalizedProductPriceById(string productId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__19))]
		public Task InitializeAsync()
		{
			return null;
		}

		public Task InitializeFailedAsync(Nakama.ILogger logger, Exception e)
		{
			return null;
		}

		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		[Obsolete("This is deprecated in newer versions of the Unity Purchasing package.")]
		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
		{
			return default(PurchaseProcessingResult);
		}

		public Task RestorePurchasesAsync()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static EconomyStoreType GetStoreType(RuntimePlatform platform)
		{
			return default(EconomyStoreType);
		}
	}
}
