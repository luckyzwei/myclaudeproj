using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Balancy.API.Payments;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

public class AppStore : IDetailedStoreListener, IStoreListener
{
	public interface IDelegate
	{
		void OnFetchedAppStoreProducts(ProductCollection products);

		void OnAppStorePurchasedComplete(UnityEngine.Purchasing.Product product);

		void OnAppStorePurchasedFailed(string failureReason);
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAsyncGetProducts_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public List<string> productIDs;

		public AppStore _003C_003E4__this;

		private ConfigurationBuilder _003Cbuilder_003E5__2;

		private List<string>.Enumerator _003C_003E7__wrap2;

		private string _003CproductID_003E5__4;

		private TaskAwaiter<Balancy.API.Payments.Product> _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetProductByIdAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Balancy.API.Payments.Product> _003C_003Et__builder;

		public string productID;

		private TaskAwaiter<Balancy.API.Payments.Product> _003C_003Eu__1;

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

	private static IStoreController m_StoreController;

	private static IExtensionProvider m_StoreExtensionProvider;

	private IDelegate m_delegate;

	public void Initialise(IDelegate iDelegate)
	{
	}

	public void FetchProducts(List<string> productIDs)
	{
	}

	[AsyncStateMachine(typeof(_003CAsyncGetProducts_003Ed__6))]
	private void AsyncGetProducts(List<string> productIDs)
	{
	}

	[AsyncStateMachine(typeof(_003CGetProductByIdAsync_003Ed__7))]
	private Task<Balancy.API.Payments.Product> GetProductByIdAsync(string productID)
	{
		return null;
	}

	public UnityEngine.Purchasing.Product GetProduct(string productID)
	{
		return null;
	}

	public bool IsInitialized()
	{
		return false;
	}

	public void BuyProductID(string productId)
	{
	}

	public void RestorePurchases(Action<bool> onComplete = null)
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, PurchaseFailureDescription failureDescription)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error, string message)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
	{
		return default(PurchaseProcessingResult);
	}

	public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, PurchaseFailureReason failureReason)
	{
	}
}
