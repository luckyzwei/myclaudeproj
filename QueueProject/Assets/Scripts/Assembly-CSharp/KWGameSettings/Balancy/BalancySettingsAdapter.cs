namespace KWGameSettings.Balancy
{
	public class BalancySettingsAdapter : GameSettings
	{
		public Ads Ads { get; set; }

		public AdMediatorIronsource AdSettingsIronSource { get; set; }

		public AdsMediatorMAX AdsMediatorMAX { get; set; }

		public AdsMediatorAlmada AdsMediatorAlmada { get; set; }

		public Audio Audio { get; set; }

		public Analytics Analytics { get; set; }

		public AppsFlyer AppsFlyer { get; set; }

		public Connectivity Connectivity { get; set; }

		public GameCore GameCore { get; set; }

		public Links Links { get; set; }

		public UserConsentForms UserConsentForms { get; set; }

		public PushNotifications PushNotifications { get; set; }

		public Rating Rating { get; set; }

		public Huq Huq { get; set; }

		public XPromo XPromo { get; set; }

		public FacebookSettings Facebook { get; set; }

		public Subscription Subscription { get; set; }

		public SocialFollow SocialFollow { get; set; }

		public FirebaseSettings Firebase { get; set; }
	}
}
