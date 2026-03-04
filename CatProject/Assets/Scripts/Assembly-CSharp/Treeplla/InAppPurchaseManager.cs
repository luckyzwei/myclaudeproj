using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Security;

namespace Treeplla
{
	public class InAppPurchaseManager : MonoBehaviour, IDetailedStoreListener, IStoreListener
	{
		private enum ProcessPurchaseType
		{
			Initialzing = 0,
			BuyProduct = 1,
			RestorePurchase = 2
		}

		public enum Result
		{
			Failed = 0,
			Success = 1
		}

		private enum ReceiptValidationError
		{
			Unknown = 0,
			ConnectionError = 1,
			InvalidReceipt = 2,
			DuplicateReceipt = 3,
			JsonParsingFailed = 4
		}

		[Serializable]
		public class Receipts
		{
			public string Store;

			public string TransactionID;

			public string Payload;

			public Payload PayloadData;

			public void CovertPayloadData()
			{
			}
		}

		[Serializable]
		public class Payload
		{
			public jsonData jsonData;

			public string json;

			public string signature;

			public void CovertJsonData()
			{
			}
		}

		[Serializable]
		public class jsonData
		{
			public string orderId;

			public string packageName;

			public string productId;

			public string purchaseTime;

			public string purchaseState;

			public bool acknowledged;

			public string purchaseToken;
		}

		[Serializable]
		public abstract class ISendData
		{
			public string orderId;

			public string packageName;

			public string productId;

			public int itemidx;

			public string priceCode;

			public string price;
		}

		[Serializable]
		public class GoogleSendData : ISendData
		{
			public long purchaseTime;

			public long purchaseState;

			public bool acknowledged;

			public string purchaseToken;

			public string signature;
		}

		[Serializable]
		public class AppleSendData : ISendData
		{
			public string receipt;
		}

		private class ReturnData
		{
			public int result;
		}

		private struct ProcessPurchaseStreamData
		{
			public Result result;

			public string productId;
		}

		[CompilerGenerated]
		private sealed class _003CPostJson_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string serverURL;

			public string jsonSendData;

			public Action<ReceiptValidationError> OnFail;

			public Action OnSuccess;

			public bool log;

			private UnityWebRequest _003Cwww_003E5__2;

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
			public _003CPostJson_003Ed__111(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CWaitTime_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public Action End;

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
			public _003CWaitTime_003Ed__91(int _003C_003E1__state)
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

		private const string googleTreepllaPurchaseServerURL = "https://us-central1-inapppurchasevalidation-c062c.cloudfunctions.net/verifyInAppPurchaseGoogle";

		private const string appleTreepllaPurchaseServerURL = "https://us-central1-inapppurchasevalidation-c062c.cloudfunctions.net/verifyInAppPurchaseApple";

		private List<string> nonConsumableItemList;

		public static readonly string NoAds_productID;

		public static readonly string NoadsSale_productID;

		public static readonly string GemPass_productID;

		public static readonly string GemPass2_productID;

		public static readonly string GemPass3_productID;

		public static readonly string GemPassSale_productID;

		public static readonly string MultiRevenue_productID;

		public static readonly string MultiRevenueSale_productID;

		public static readonly string OfflineTimeAdd_productID;

		public static readonly string NewOfflineTimeAdd_productID;

		public static readonly string FactorySlot_productID;

		public static readonly string BizAcq_BattleSpeed_Special_productID;

		public static readonly string BizAcq_StagePass_Special_productID;

		public static readonly int NoAds_PackageIdx;

		public static readonly int NoAdsSale_PackageIdx;

		public static readonly int GemPass1_PackageIdx;

		public static readonly int GemPass2_PackageIdx;

		public static readonly int GemPass3_PackageIdx;

		public static readonly int GemPassSale_PackageIdx;

		public static readonly int OnePlusSix_PackageIdx;

		public static readonly int Piggy_packageIdx;

		public static readonly int MultiRevenue_PackageIdx;

		public static readonly int MultiRevenueSale_PackageIdx;

		public static readonly int OfflineTimeAdd_PackageIdx;

		public static readonly int AuctionPass_PackageIdx;

		public static readonly int OpenNow_Factory_PackageIdx;

		public static readonly int FactorySlot_PackageIdx;

		public static readonly int Seasonal_Statue_PackageIdx;

		public static readonly int Seasonal_PremiumBuildingSlot_PackageIdx;

		public static readonly int BizAcq_BattleSpeed_Special_PackageIdx;

		public static readonly int Seasonal_PremiumPass_PackageIdx;

		public static readonly int OpenNow_Stage3_PackageIdx;

		public static readonly int OpenNow_Stage4_PackageIdx;

		public static readonly int OpenNow_Stage5_PackageIdx;

		public static readonly int OpenNow_Stage6_PackageIdx;

		public static readonly int OpenNow_Stage_PackageIdx_Start;

		public static readonly int BizAcq_StagePass_Special_Package_Start_Idx;

		public static readonly int BizAcq_StagePass_Special_Package_End_Idx;

		public static readonly string AutoTreat_ProductID;

		public static readonly List<int> GemPass_PackageIdxs;

		private bool checkNonConsumable;

		private bool serverWait;

		private ProcessPurchaseType processPurchaseType;

		private static IStoreController storeController;

		private static IExtensionProvider extensionProvider;

		private Subject<ProcessPurchaseStreamData> buyProductStream;

		private Subject<ProcessPurchaseStreamData> restoreTransactionStream;

		private Subject<PurchaseEventArgs> processPurchaseStream;

		private ReactiveProperty<string> prevTransactionID;

		private int tableIdx;

		public bool recoveryNoads { get; private set; }

		public bool recoveryRevenue { get; private set; }

		public bool recoveryPass { get; private set; }

		public bool recoveryPass2 { get; private set; }

		public bool recoveryPass3 { get; private set; }

		public bool recoveryOffline { get; private set; }

		public void Init()
		{
		}

		private bool IsNonConsumableProduct(string productId)
		{
			return false;
		}

		public bool IsInitialized()
		{
			return false;
		}

		public bool checkItemBougthAnything()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CWaitTime_003Ed__91))]
		public IEnumerator WaitTime(float time, Action End)
	{
		yield break;
	}

		public bool checkItemBought(string productId)
		{
			return false;
		}

		public void BuyProductID(string productId, int _tableIdx, Action<Result> onCompeleteAction)
		{
		}

		public void RestorePurchase(Action<Result> onCompeleteAction)
		{
		}

		public void OnInitialized(IStoreController sc, IExtensionProvider ep)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason reason)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		private Subject<bool> FetchProducts()
		{
			return null;
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
		{
		}

		public Product GetProduct(string productID)
		{
			return null;
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			return default(PurchaseProcessingResult);
		}

		private bool HandleAppleReceipt(Product product)
		{
			return false;
		}

		private bool HandleGoogleReceipt(Product purchasedProduct)
		{
			return false;
		}

		private void ValidateReceipt(Product product, ISendData sendData)
		{
		}

		private bool TryRestoreNonConsumableItem(string productID)
		{
			return false;
		}

		private ISendData ToAppleSendData(Product product, AppleInAppPurchaseReceipt apple, string transactionReceipt)
		{
			return null;
		}

		private void SendInAppPurchaseEvent(ISendData sendData, string productTransactionID, string productId)
		{
		}

		private ISendData ToGoogleSendData(Product product, GooglePlayReceipt google, Receipts receipts)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPostJson_003Ed__111))]
		private IEnumerator PostJson(string jsonSendData, ISendData data, string serverURL, Action OnSuccess, Action<ReceiptValidationError> OnFail = null, bool log = true)
	{
		yield break;
	}

		public void PopulateConfigurationBuilder(ref ConfigurationBuilder builder, ProductCatalog catalog)
		{
		}
	}
}
