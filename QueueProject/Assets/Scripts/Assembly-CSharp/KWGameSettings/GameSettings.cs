namespace KWGameSettings
{
	public interface GameSettings
	{
		Ads Ads { get; set; }

		AdMediatorIronsource AdSettingsIronSource { get; set; }

		AdsMediatorMAX AdsMediatorMAX { get; set; }

		AdsMediatorAlmada AdsMediatorAlmada { get; set; }

		Audio Audio { get; set; }

		Analytics Analytics { get; set; }

		AppsFlyer AppsFlyer { get; set; }

		Connectivity Connectivity { get; set; }

		GameCore GameCore { get; set; }

		Links Links { get; set; }

		UserConsentForms UserConsentForms { get; set; }

		PushNotifications PushNotifications { get; set; }

		Rating Rating { get; set; }

		Huq Huq { get; set; }

		XPromo XPromo { get; set; }

		FacebookSettings Facebook { get; set; }

		Subscription Subscription { get; set; }

		SocialFollow SocialFollow { get; set; }

		FirebaseSettings Firebase { get; set; }
	}
}
