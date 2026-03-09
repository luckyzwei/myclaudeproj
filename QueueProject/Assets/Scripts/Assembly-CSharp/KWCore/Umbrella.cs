using System;
using System.Collections;
using System.Collections.Generic;
using KWAds.Ads;
using KWAnalytics.Analytics;
using KWAttribution.Attribution;
using KWAudio;
using KWCore.CoreRequests;
using KWCore.CrackedAppChecker;
using KWCore.IDFA;
using KWCore.Input;
using KWCore.Loading;
using KWCore.Network;
using KWCore.SaveData;
using KWCore.Stats;
using KWCore.UI;
using KWCore.Utils;
using KWFirebase;
using KWGDPR.GDPR;
using KWGameCore;
using KWGameCore.Bank;
using KWGameCore.Progress;
using KWGameSettings;
using KWHaptics.Haptics;
using KWLocalisation.Localisation;
using KWPushNotifications;
using KWPushNotifications.PushMessageManager;
using KWRating.Rating;
using UnityEngine;

namespace KWCore
{
	public class Umbrella
	{
		public class AdsAccess
		{
			private AdsManager m_adsManager;

			public AdsAccess(AdsManager adsManager)
			{
			}

			public bool CanShowInterstitialAd(string location)
			{
				return false;
			}

			public void ShowInterstitialAd(string location, Action interstitialFinished = null, bool skipCoolDown = false)
			{
			}

			public void ShowRewardAd(string location, Action<AdsManager.VideoResult> rewardAdFinished)
			{
			}

			public void SetBannerAdsEnabled(bool enabled)
			{
			}

			public bool GetBannerAdsEnabled()
			{
				return false;
			}

			public float GetBannersHeight()
			{
				return 0f;
			}

			public void SetBannerAdsVisible(bool visible)
			{
			}

			public void SetBannerAdsBackgroundVisible(bool visible)
			{
			}

			public void ShowNativeAd<T>(string location, T nativeObject, Action onAdShowCompleted = null)
			{
			}

			public void SetBannerSizeToRegular()
			{
			}

			public void SetBannerSizeToRectangular()
			{
			}

			public void SetBannerBackgroundColor(Color color)
			{
			}

			public void ShowAppOpenAd(string location, Action onFinished)
			{
			}

			public bool IsAdShowing()
			{
				return false;
			}

			public Hashtable GetProvidersWaterfallStatus()
			{
				return null;
			}
		}

		public class AnalyticsAccess
		{
			private LegacyAnalyticsManager m_legacyAnalyticsManager;

			private AnalyticsManager m_analyticsManager;

			private EventValidator m_eventValidator;

			public EventValidator EventValidator => null;

			public AnalyticsAccess(LegacyAnalyticsManager legacyAnalyticsManager, EventValidator validator, AnalyticsManager analyticsManager)
			{
			}

			public void FlushSession()
			{
			}

			public string GetInstanceID()
			{
				return null;
			}

			public string GetCurrentSessionID()
			{
				return null;
			}

			public void LogEvent(AnalyticEvent analyticEvent)
			{
			}

			public void LogEventImmediate(AnalyticEvent analyticEvent)
			{
			}

			public void AddEvent(ClosedSchema baseSchema)
			{
			}

			public void AddEvent(OpenSchema openSchema)
			{
			}

			public void AddDebugEvent(OpenSchema openSchema)
			{
			}

			public int AddEventWithKey(OpenSchema baseSchema)
			{
				return 0;
			}

			public int AddDebugEventWithKey(OpenSchema baseSchema)
			{
				return 0;
			}

			public T GetOrJoinEvent<T>() where T : OpenSchema, new()
			{
				return null;
			}

			public T GetOrJoinEventWithKey<T>(int key) where T : OpenSchema, new()
			{
				return null;
			}

			public void CloseEvent<T>() where T : OpenSchema
			{
			}

			public void CloseEventWithKey<T>(int key) where T : OpenSchema
			{
			}
		}

		public class AttributionAccess
		{
			private AttributionManager m_attributionManager;

			public AttributionAccess(AttributionManager attributionManager)
			{
			}

			public void SendLevelAchievedEvent(int level, float? score = null)
			{
			}

			public void SendEvent(string eventName, Dictionary<string, string> parameters = null, int value = 0)
			{
			}

			public void AttributeCrossPromoClick(CrossPromoAttributionInfoBase crossPromoInfo, Action<bool, string> clickAttributionCallback)
			{
			}

			public void AttributeCrossPromoImpression(CrossPromoAttributionInfoBase crossPromoInfo)
			{
			}
		}

		public class AudioAccess
		{
			private AudioManager m_audioManager;

			public AudioSoundList AudioSoundList => null;

			public bool SFXEnabled
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool MusicEnabled
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public AudioAccess(AudioManager audioManager)
			{
			}

			public void PlaySFX(AudioClipReference clipRef, ulong delay = 0uL, bool force = true, bool looping = false, Action callback = null, int channel = 2, float pitch = 1f)
			{
			}

			public void PlayMusic(AudioClipReference clipRef, ulong delay = 0uL, bool force = true, bool looping = false, Action callback = null, int channel = 1, float pitch = 1f)
			{
			}

			public void PlayOneShotSFX(AudioClipReference clip, float volume = 1f, int channel = 2, float pitch = 1f)
			{
			}

			public void SetChannelVolume(int channel, float volume)
			{
			}

			public void SetChannelVolumeInTime(int channel, float volume, float time)
			{
			}

			public void Stop(int channel)
			{
			}

			public AudioChannel GetChannel(int channel)
			{
				return null;
			}

			public float GetTrackLength(AudioClipReference clip)
			{
				return 0f;
			}

			public float GetPlaybackTime(int channel)
			{
				return 0f;
			}

			public void PlaySFXFromLastPlaybackTime(AudioClipReference clipRef, int channel = 0, ulong delay = 0uL, bool force = true, bool looping = false, Action callback = null, float pitch = 1f)
			{
			}
		}

		public class CoreAccess
		{
			private CoreRequestsHandler m_coreRequestsHandler;

			private SaveDataManager m_saveDataManager;

			private EventsQueue m_eventsQueue;

			private UseStatsManager m_useStatsManager;

			private DeviceSettingsManager m_deviceSettingsManager;

			private CoreUI m_coreUI;

			private KWInputController m_inputController;

			private NetworkSettingsManager m_networkSettingsManager;

			private KWIDFAManager m_idfaManager;

			private KWTermsOfUsePopupManager m_termsOfUsePopupManager;

			private ServerInterface m_server;

			private CrackedAppCheckController m_crackedAppCheckController;

			private CurrencyUtils m_currencyUtils;

			public EventsQueue EventsQueue => null;

			public CoreAccess(CoreRequestsHandler coreRequestsHandler, SaveDataManager saveDataManager, EventsQueue eventsQueue, UseStatsManager useStatsManager, DeviceSettingsManager deviceSettingsManager, CoreUI coreUI, NetworkSettingsManager networkSettingsManager, KWInputController inputController, KWIDFAManager idfaManager, KWTermsOfUsePopupManager termsOfUsePopupManager, ServerInterface server, CrackedAppCheckController crackedAppCheckController)
			{
			}

			public UseStatsManager GetUseStats()
			{
				return null;
			}

			public T GetBucket<T>() where T : BucketBase
			{
				return null;
			}

			public BucketBase GetBucketForKey(string key)
			{
				return null;
			}

			public void DoNotSave()
			{
			}

			public void SaveBucketData()
			{
			}

			public string DeviceGetLanguageCode()
			{
				return null;
			}

			public string DeviceGetRegion()
			{
				return null;
			}

			public float GetPhysicalDiagonalScreenSizeInInches()
			{
				return 0f;
			}

			public bool IsDeviceTablet()
			{
				return false;
			}

			public string GetAppStoreLocation()
			{
				return null;
			}

			public string GetPlayerID()
			{
				return null;
			}

			public bool HasPlayer()
			{
				return false;
			}

			public string GetBackendName()
			{
				return null;
			}

			public string GetBackendEnvironmentName()
			{
				return null;
			}

			public string GetGameSegmentName()
			{
				return null;
			}

			public string GetGameSegmentId()
			{
				return null;
			}

			public string GetGameSegmentedSessionId()
			{
				return null;
			}

			public string GetInstallID()
			{
				return null;
			}

			public string GetPreviousInstallVersion()
			{
				return null;
			}

			public void ShowPopUpInfo(Action closedCallback, string overrideBodyText = null)
			{
			}

			public void ShowNoAdsPopUp(Action onContinuePressed, Action onCancelPressed = null)
			{
			}

			public void ShowForceUpgradePopup()
			{
			}

			public Canvas GetCoreCanvas()
			{
				return null;
			}

			public Canvas GetGameplayCanvas()
			{
				return null;
			}

			public void SetGameplayCanvas(Canvas canvas)
			{
			}

			public bool IsSoftIDFAAvailable()
			{
				return false;
			}

			public bool IsIDFAAnswered()
			{
				return false;
			}

			public bool IsIDFARejected()
			{
				return false;
			}

			public bool AreTermsOfUseAccepted()
			{
				return false;
			}

			public bool CheckForConnectionToPlay(Action closedCallback = null)
			{
				return false;
			}

			public bool IsAirplaneMode()
			{
				return false;
			}

			public int GetAnyMouseButtonDown()
			{
				return 0;
			}

			public bool GetMouseButtonDown(int fingerIndex)
			{
				return false;
			}

			public Vector3 GetMousePosition(int fingerIndex)
			{
				return default(Vector3);
			}

			public int GetAnyMouseButtonUp()
			{
				return 0;
			}

			public bool GetMouseButtonUp(int fingerIndex)
			{
				return false;
			}

			public int GetAnyMouseButton()
			{
				return 0;
			}

			public bool GetMouseButton(int fingerIndex)
			{
				return false;
			}

			public void AddNewCoreServerRequest(CoreRequest request)
			{
			}

			public void FlushServerQueueAndCache()
			{
			}

			public string BeautifyJSONSubstring(string jsonData)
			{
				return null;
			}

			public bool IsCorrectBundleId()
			{
				return false;
			}

			public bool IsStoreBuild()
			{
				return false;
			}

			public float? ConvertToUSD(float localisedPrice, string currencyCode)
			{
				return null;
			}
		}

		public class FirebaseAccess
		{
			public class FirebaseMarketAccess
			{
				private readonly FirebaseMarketManager m_fireBaseMarketManager;

				public FirebaseMarketAccess(FirebaseMarketManager firebaseMarketManager)
				{
				}

				public ProductInfo GetProduct(string productId)
				{
					return null;
				}

				public void RestorePurchases(Action onSuccess = null)
				{
				}

				public List<ProductInfo> GetAllProducts()
				{
					return null;
				}

				public List<ProductInfo> GetPurchasedProducts()
				{
					return null;
				}

				public List<ProductInfo> GetPurchasedConsumables()
				{
					return null;
				}

				public bool IsStoreInitialised()
				{
					return false;
				}

				public void ToggleFakeMarket()
				{
				}

				public List<ProductInfo> GetProductsByCategory(string category)
				{
					return null;
				}
			}

			public class FirebaseServerAccess
			{
				private readonly FirebaseServerManager m_serverManager;

				public FirebaseServerAccess(FirebaseServerManager firebaseServerManager)
				{
				}

				public bool GetBool(string key, bool defaultValue = false)
				{
					return false;
				}

				public string GetString(string key, string defaultValue = null)
				{
					return null;
				}

				public double GetDouble(string key, double defaultValue = 0.0)
				{
					return 0.0;
				}

				public long GetLong(string key, long defaultValue = 0L)
				{
					return 0L;
				}

				public bool HasConnected()
				{
					return false;
				}

				public T Get<T>(string name, string subDirectory = "", bool keepInMemory = false) where T : FirebaseScriptableObject
				{
					return null;
				}

				public FirebaseScriptableObject Get(string key, Type type, string subDirectory = "", bool keepInMemory = false)
				{
					return null;
				}
			}

			public FirebaseServerAccess Server { get; private set; }

			public FirebaseMarketAccess Market { get; private set; }

			public FirebaseAccess(FirebaseServerManager serverManager)
			{
			}

			public void InitialiseFirebaseMarketAccess(FirebaseMarketManager marketManager)
			{
			}
		}

		public class GameCoreAccess
		{
			public class ProgressManagerAccess
			{
				private ProgressManager m_progressManager;

				public ProgressManagerAccess(ProgressManager progressManager)
				{
				}

				public int GetCurrentLevel()
				{
					return 0;
				}

				public int GetCurrentStage()
				{
					return 0;
				}

				public void StartStage(int stageNumber = -1, int levelNumber = -1, string levelId = null, bool hasStages = false)
				{
				}

				public bool CompleteStage(int levelSize = 1, int score = -1, int stageNumber = -1, string levelId = null)
				{
					return false;
				}

				public void FailStage(int score = -1, int stageNumber = -1, string levelId = null, bool hasStages = false)
				{
				}

				public void FailLevel(int levelNumber = -1)
				{
				}

				public void LevelContinued(int levelNumber = -1, string continueContext = null)
				{
				}

				public void StageContinued(int levelNumber = -1, int stageNumber = -1, string continueContext = null)
				{
				}

				public void QuitStage(int score = -1, int stageNumber = -1, string levelId = null)
				{
				}

				public void OverrideLevel(int level)
				{
				}

				public void OverrideStage(int stage)
				{
				}

				public void OverrideLastActiveLevel(int level)
				{
				}

				public int GetLastActiveLevel()
				{
					return 0;
				}

				public int GetLastActiveStage()
				{
					return 0;
				}

				public bool IsStageActive()
				{
					return false;
				}
			}

			public class BankAccess
			{
				private BaseBank m_baseBank;

				public BaseBank BaseBank => null;

				public BankAccess(BaseBank baseBank)
				{
				}
			}

			private ProgressManagerAccess m_progressManagerAccess;

			private BankAccess m_bankAccess;

			public ProgressManagerAccess ProgressManager => null;

			public BankAccess Bank => null;

			public GameCoreAccess(ProgressManager progressManager, BaseBank baseBank)
			{
			}
		}

		public class MarketAccess
		{
			private MarketManager m_marketManager;

			private SubscriptionManager m_subscriptionManager;

			public MarketAccess(MarketManager marketManager, SubscriptionManager subscriptionManager)
			{
			}

			public void BuyProduct(string productID, Action onSuccess = null, Action onFailed = null)
			{
			}

			public void BuyNoAds(MarketInterface.NoAdsType type, Action purchaseSuccess = null, Action purchaseFailed = null)
			{
			}

			public void RestorePurchases(Action onSuccess = null)
			{
			}

			public bool HasPurchasedNoAds()
			{
				return false;
			}

			public float GetPriceWithProductClientID(string productCode)
			{
				return 0f;
			}

			public string GetLocalisedPriceWithProductClientID(string productCode)
			{
				return null;
			}

			public bool GetSubscriptionsEnabled()
			{
				return false;
			}

			public bool GetSubscribed()
			{
				return false;
			}

			public string GetNoAdsPrice()
			{
				return null;
			}

			public bool CanShowBannerCloseButton()
			{
				return false;
			}

			public bool TryShowGameSubscriptionPopUp()
			{
				return false;
			}

			public bool ShowUserRequestedSubscriptionFullScreenPopUp()
			{
				return false;
			}

			public void OpenAppSubscription()
			{
			}
		}

		public class GameSettingsAccess
		{
			private GameSettingsManager m_gameSettingsManager;

			public GameSettingsAccess(GameSettingsManager gameSettingsManager)
			{
			}

			public GameSettings GetCoreSettings()
			{
				return null;
			}

			public bool HasRemoteSettings()
			{
				return false;
			}
		}

		public class GDPRAccess
		{
			private GDPRManager m_gdprManager;

			public GDPRAccess(GDPRManager gdprManager)
			{
			}

			public bool HasGivenConsent()
			{
				return false;
			}

			public string GetConsentCTString()
			{
				return null;
			}

			public bool HasAnsweredGDPR()
			{
				return false;
			}

			public bool DoesGDPRApply()
			{
				return false;
			}

			public string GetPrivacyButtonText()
			{
				return null;
			}

			public string GetAdPreferencesButtonText()
			{
				return null;
			}

			public bool EnableTermsAndConditionsButton()
			{
				return false;
			}

			public void OnPrivacyButtonClicked()
			{
			}

			public void OnAdPreferencesButtonClicked()
			{
			}

			public void OnTermsAndConditionsButtonClicked()
			{
			}

			public void ShowConsentForm()
			{
			}

			public void RevokeConsent(string consentID = null)
			{
			}
		}

		public class HapticsAccess
		{
			private HapticsManager m_hapticsManager;

			public HapticsAccess(HapticsManager hapticsManager)
			{
			}

			public void Trigger(HapticsManager.HapticType hapticType)
			{
			}

			public void TriggerForDuration(HapticsManager.HapticType hapticType, float totalDuration = 0f, float burstDuration = 0f, float delay = 0f, bool useRealTime = false, Action callback = null)
			{
			}

			public void StopContinousHaptics()
			{
			}

			public void StopBurstHaptics()
			{
			}

			public void StopAllHaptics()
			{
			}

			public void TriggerBurst(int hapticBurstAmount = 15, float timeBetweenHapticsBurst = 0.1f, HapticsManager.HapticType hapticType = HapticsManager.HapticType.MEDIUM, bool useRealTime = false, Action onComplete = null)
			{
			}

			public void TriggerBurst(int hapticBurstAmount, float timeBetweenHapticsBurst, HapticsManager.HapticType hapticType, HapticsManager.HapticIntensityDir intensityDir, bool useRealTime = false, Action onComplete = null)
			{
			}

			public void TriggerBurst(int hapticBurstAmount, float length, float timeBetweenHapticsBurst, HapticsManager.HapticType hapticType = HapticsManager.HapticType.MEDIUM, HapticsManager.HapticIntensityDir intensityDir = HapticsManager.HapticIntensityDir.Flat, bool useRealTime = false, Action onComplete = null)
			{
			}

			public bool GetSupported()
			{
				return false;
			}

			public bool GetEnabled()
			{
				return false;
			}

			public void SetEnabled(bool enabled)
			{
			}

			public void SetAutoTriggerOnUIClick(bool enabled)
			{
			}
		}

		public class LocalisationAccess
		{
			private TextManager textManager;

			public LocalisationAccess(TextManager textManager)
			{
				this.textManager = textManager;
			}

			public string GetLocalisedString(string key)
			{
				if (textManager == null) return key;
				return textManager.Get(key) ?? key;
			}

			public void SetCurrentLanguage(string deviceLanguage)
			{
				if (textManager != null)
					textManager.SetCurrentLanguage(deviceLanguage);
			}

			public string GetCurrentLanguage()
			{
				return textManager?.GetCurrentLanguage();
			}
		}

		public class PushNotificationsAccess
		{
			private readonly LocalPushNotificationsManager m_pushNotificationManager;

			public PushNotificationsAccess(LocalPushNotificationsManager pushNotificationManager)
			{
			}

			public void CreateLocalPushNotification(long inMilliseconds, string title, string messageBody, string messageId, string customData = "", bool isCancellable = false)
			{
			}

			public void TriggerLocalPushNotification(PushTriggerData data)
			{
			}

			public void RequestUserAuthorization()
			{
			}

			public void CancelScheduledLocalPushNotification(string messageId)
			{
			}

			public Dictionary<string, SavedNotificationData> GetScheduledPushes()
			{
				return null;
			}

			public int GetTodaysDeliveredPushCount()
			{
				return 0;
			}

			public string GetActivePushProviderSystemName()
			{
				return null;
			}
		}

		public class RatingAccess
		{
			private RatingsManager m_ratingsManager;

			public RatingAccess(RatingsManager ratingsManager)
			{
			}

			public void TryShowRatingPopUp()
			{
			}
		}

		private AdsAccess m_adsAccess;

		private AnalyticsAccess m_analyticsAccess;

		private AttributionAccess m_attributionAccess;

		private AudioAccess m_audioAccess;

		private LoadingManager m_loadingManager;

		private CoreAccess m_coreAccess;

		private static Umbrella s_instance;

		private FirebaseAccess m_firebaseAccess;

		private GameCoreAccess m_gameCoreAccess;

		private MarketAccess m_marketAccess;

		private GameSettingsAccess m_gameSettingsAccess;

		private GDPRAccess m_gdprAccess;

		private HapticsAccess m_hapticsAccess;

		private LocalisationAccess m_localisationAccess;

		private PushNotificationsAccess m_pushNotificationsAccess;

		private RatingAccess m_ratingAccess;

		public static AdsAccess Ads => null;

		public static AnalyticsAccess Analytics => null;

		public static AttributionAccess Attribution => null;

		public static AudioAccess Audio => null;

		public static LoadingManager Loading => null;

		public static CoreAccess Core => null;

		protected static Umbrella Instance
		{
			get
			{
				if (s_instance == null)
					s_instance = new Umbrella();
				return s_instance;
			}
		}

		public static FirebaseAccess Firebase => null;

		public static GameCoreAccess GameCore => null;

		public static MarketAccess Market => null;

		public static GameSettingsAccess GameSettings => null;

		public static GDPRAccess GDPR => null;

		public static HapticsAccess Haptics => null;

		public static LocalisationAccess Localisation => s_instance?.m_localisationAccess;

		public static PushNotificationsAccess PushNotifications => null;

		public static RatingAccess Rating => null;

		public static void InitialiseAdsUmbrella(AdsManager adsManager)
		{
		}

		public static void InitialiseAnalyticsUmbrella(LegacyAnalyticsManager legacyAnalyticsManager, EventValidator eventValidator, AnalyticsManager analyticsManager)
		{
		}

		public static void InitialiseAttributionUmbrella(AttributionManager attributionManager)
		{
		}

		public static void InitialiseAudioUmbrella(AudioManager audioManager)
		{
		}

		public static void InitialiseLoading(LoadingManager loadingManager)
		{
		}

		public static void InitialiseCoreUmbrella(CoreRequestsHandler coreRequestsHandler, SaveDataManager saveDataManager, EventsQueue eventsQueue, UseStatsManager useStatsManager, DeviceSettingsManager deviceSettingsManager, CoreUI coreUI, NetworkSettingsManager networkSettingsManager, KWInputController inputController, KWIDFAManager idfaManager, KWTermsOfUsePopupManager termsOfUsePopupManager, ServerInterface server, CrackedAppCheckController crackedAppCheckController)
		{
		}

		public static void InitialiseFirebaseServer(FirebaseServerManager firebaseServerManager)
		{
		}

		public static void InitialiseFirebaseMarket(FirebaseMarketManager marketManager)
		{
		}

		public static void InitialiseGameCoreUmbrella(ProgressManager progressManager, BaseBank baseBank)
		{
		}

		public static void InitialiseGameCoreMarket(MarketManager marketManager, SubscriptionManager subscriptionManager)
		{
		}

		public static void InitialiseGameSettingsUmbrella(GameSettingsManager gameSettingsManager)
		{
		}

		public static void InitialiseGDPRUmbrella(GDPRManager gdprManager)
		{
		}

		public static void InitialiseHapticsUmbrella(HapticsManager hapticsManager)
		{
		}

		public static void InitialiseLocalisationUmbrella(TextManager textManager)
		{
			Instance.m_localisationAccess = new LocalisationAccess(textManager);
		}

		public static void InitialisePushNotificationsUmbrella(LocalPushNotificationsManager pushNotificationManager)
		{
		}

		public static void InitialiseRatingUmbrella(RatingsManager ratingsManager)
		{
		}
	}
}
