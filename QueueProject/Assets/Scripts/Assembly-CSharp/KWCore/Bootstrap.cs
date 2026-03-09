using System.Collections.Generic;
using KWAds.Ads;
using KWAds.Interface;
using KWAnalytics.Analytics;
using KWAttribution.Attribution;
using KWAudio;
using KWAudio.Interface;
using KWCore.CoreRequests;
using KWCore.CrackedAppChecker;
using KWCore.Facebook;
using KWCore.Huq;
using KWCore.IDFA;
using KWCore.Input;
using KWCore.Interface;
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
using KWGameCore.Interface;
using KWGameCore.Progress;
using KWGameSettings;
using KWHaptics.Haptics;
using KWLocalisation.Localisation;
using KWRating.Rating;
using UnityEngine;

namespace KWCore
{
	public class Bootstrap : MonoBehaviour
	{
		[SerializeField]
		[Autohook]
		private CoreUIInterface m_coreUIInterface;

		[SerializeField]
		[Autohook]
		private CoreInputInterface m_inputInterface;

		[SerializeField]
		private List<ServerInterface> m_serverInterfaces;

		[SerializeField]
		[Autohook]
		private GameSettingsInterface m_gameSettingsInterface;

		[SerializeField]
		[Autohook]
		private MarketInterface m_marketInterface;

		[SerializeField]
		[Autohook]
		private SaveDataInterface m_saveDataInterface;

		[SerializeField]
		[Autohook]
		private BaseProvider m_legacyAnalyticsProvider;

		[SerializeField]
		[Autohook]
		private BaseProvider m_analyticsProvider;

		[SerializeField]
		[Autohook]
		private AdsInterface m_adsInterface;

		[SerializeField]
		[Autohook]
		private AudioInterface m_audioInterface;

		[SerializeField]
		[Autohook]
		private GameCoreInterface m_gameCoreInterface;

		[SerializeField]
		[Autohook]
		private LoadingInterface m_loadingInterface;

		[SerializeField]
		private GameObject[] m_sceneExecutionOrder;

		private static Bootstrap s_instance;

		private CoreRequestsHandler m_coreRequestsHandler;

		private SaveDataManager m_saveDataManager;

		private UseStatsManager m_useStatsManager;

		private AppDelegateLoudspeaker m_appDelegateLoudspeaker;

		private DeviceSettingsManager m_deviceSettingsManager;

		private CoreUI m_coreUI;

		private KWInputController m_inputController;

		private NetworkSettingsManager m_networkSettingsManager;

		private KWIDFAManager m_idfaManager;

		private KWTermsOfUsePopupManager m_termsOfUseManager;

		private KWSocialFollowPopupManager m_socialFollowManager;

		private HuqManager m_huqManager;

		private EventsQueue m_eventsQueue;

		private NTPServerTimeManager m_ntpServerTimeManager;

		private LoadingManager m_loadingManager;

		private MarketManager m_marketManager;

		private ServerInterface m_mainServer;

		private ServerManager m_serverManager;

		private GameSettingsManager m_gameSettingsManager;

		private CrackedAppCheckController m_crackedAppCheckController;

		private bool m_applicationPauseState;

		private AdsManager m_adsManager;

		private LegacyAnalyticsManager m_legacyAnalyticsManager;

		private AnalyticsManager m_analyticsManager;

		private EventValidator m_eventValidator;

		private TextManager m_textManager;

		private FacebookManager m_facebookManager;

		private FirebaseManager m_firebaseManager;

		private GDPRManager m_gdprManager;

		private RatingsManager m_ratingsManager;

		private AudioManager m_audioManager;

		private HapticsManager m_hapticsManager;

		private AttributionManager m_attributionManager;

		private ProgressManager m_progressManager;

		private BaseBank m_baseBank;

		private SubscriptionManager m_subscriptionManager;

		private SDKInitAnalyticsUtils m_sdkInitAnalyticsUtils;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		private void InitAfterLoading()
		{
		}

		private void InitTempLogCollector()
		{
		}

		private void InitDebugger()
		{
		}

		private void InitLoadingSystem()
		{
		}

		private void InitLocalisation()
		{
		}

		private void InitNTPTime()
		{
		}

		private void InitCore()
		{
		}

		private void InitGameCore()
		{
		}

		private BaseBank CreateBank()
		{
			return null;
		}

		private void InitAttribution()
		{
		}

		private void InitAds()
		{
		}

		private void InitGDPR()
		{
		}

		private void InitServerSystems()
		{
		}

		private void InitPortal()
		{
		}

		private void InitAnalytics()
		{
		}

		private void InitRating()
		{
		}

		private void InitAudio()
		{
		}

		private void InitHuq()
		{
		}

		private void InitCrackedAppChecker()
		{
		}

		private void InitHaptics()
		{
		}

		private void InitSceneExecutionOrder()
		{
		}

		private void InitCoreRequests()
		{
		}

		private void InitEventsQueue()
		{
		}

		private void InitSaveData()
		{
		}

		private void InitAppDelegateLoudspeaker()
		{
		}

		private void InitDeviceSettingsManager()
		{
		}

		private void InitCoreUI()
		{
		}

		private void InitInput()
		{
		}

		private void InitNetworkManager()
		{
		}

		private void InitIDFAManager()
		{
		}

		private void InitTermsOfUseManager()
		{
		}

		private void InitSocialFollowManager()
		{
		}

		private void InitDebugMenu()
		{
		}

		private void InitFacebook()
		{
		}

		private void InitFirebase()
		{
		}

		private void SetCrossLinks()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void ApplicationPause(bool pause)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void HandleRecievedMemoryWarning()
		{
		}
	}
}
