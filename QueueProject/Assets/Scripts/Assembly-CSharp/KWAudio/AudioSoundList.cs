using UnityEngine;

namespace KWAudio
{
	[CreateAssetMenu(fileName = "AudioSoundList", menuName = "Kwalee/KWAudio/AudioSoundList", order = 1)]
	public class AudioSoundList : ScriptableObject
	{
		[Header("Global Sounds")]
		public AudioClipReference globalButtonPositive;

		public AudioClipReference globalButtonNeutral;

		public AudioClipReference globalSwoosh;

		public AudioClipReference globalSliderOn;

		public AudioClipReference globalSliderOff;

		public AudioClipReference globalTabClick;

		public AudioClipReference globalPopUpWindow;

		public AudioClipReference swipe;

		public AudioClipReference levelComplete;

		public AudioClipReference levelCompletePopUp;

		public AudioClipReference levelFail;

		public AudioClipReference monthNext;

		public AudioClipReference selectedDate;

		public AudioClipReference buttonClaim;

		public AudioClipReference levelResultScreen;

		public AudioClipReference coinTallyingUp;

		public AudioClipReference spinningWheel;

		public AudioClipReference piggyBankFill;

		public AudioClipReference playerProfile;

		public AudioClipReference boosterPopup;

		public AudioClipReference piggyBankShatter;

		public AudioClipReference featureUnlocked;

		public AudioClipReference infoPopupSFX;

		[Header("Queens")]
		public AudioClipReference HeartIn;

		public AudioClipReference shopOpen;

		public AudioClipReference boosterPurchasedPopup;

		public AudioClipReference gemsObtained;

		public AudioClipReference cellScaleUp;

		public AudioClipReference cellMovement;

		public AudioClipReference cellScaleDown;

		public AudioClipReference treasureReward;

		public AudioClipReference starPopUp;

		[Header("Music")]
		public AudioClipReference menuMusic;

		public AudioClipReference gameMusic;

		public AudioClipReference gameMusicHard;

		public AudioClipReference gameMusicVeryHard;

		[Header("Gems + Leaderboard")]
		public AudioClipReference GemIntro;

		public AudioClipReference GemReachTarget;

		public AudioClipReference weeklyLegendsLeaderboard;

		public AudioClipReference leaderboardPopupIAP;

		public AudioClipReference expertModePopUp;

		public AudioClipReference leaderbordFragmentSpawn;

		public AudioClipReference leaderbordFragmentReachesTarget;

		public AudioClipReference claimButton;

		public AudioClipReference gameOver;

		public AudioClipReference cellMovementSingle;

		public AudioClipReference qgLevelRise;

		public AudioClipReference giftBox;

		public AudioClipReference withCoinRewads;

		public AudioClipReference noCoinRewads;

		public AudioClipReference storeReward;

		public AudioClipReference queenPurchase;

		public AudioClipReference pageSelect;

		public AudioClipReference onboardBoardPage;

		public AudioClipReference tapSound;

		public AudioClipReference vipAppear;

		public AudioClipReference vipAppearSimple;

		public AudioClipReference vipButtonClaim;

		public AudioClipReference specialOfferPop;

		public AudioClipReference purplePopUp;

		public AudioClipReference collectJigsaw;

		public AudioClipReference skinUnlock;

		public AudioClipReference queenhintFx;

		public AudioClipReference qgButton;

		public AudioClipReference puzzlePiecesSpawn;

		public AudioClipReference puzzlePiecesReceived;

		public AudioClipReference barFill;

		public AudioClipReference puzzleComplete1;

		public AudioClipReference puzzleComplete2;

		public AudioClipReference puzzleComplete3;

		public AudioClipReference pecilIcon;

		public AudioClipReference giftSpinWheel;

		public AudioClipReference puzzleComplete;

		public AudioClipReference spinTransition;

		public AudioClipReference spookytheme;

		public AudioClipReference gameCountdown;

		public AudioClipReference peopleFinding;

		public AudioClipReference peopleNumberCount;

		public AudioClipReference startTournament;

		public AudioClipReference milestoneUnlock;

		public AudioClipReference dailyStreakUp;

		public AudioClipReference dailyStreakDown;

		public AudioClipReference dayChange;

		public AudioClipReference dayNumberChange;

		public AudioClipReference tournamentWin;

		public AudioClipReference tournamentQualified;

		public AudioClipReference tournamentEliminated;

		public AudioClipReference tournamentLose;

		public AudioClipReference flashTime;

		public AudioClipReference timeInfo;

		public AudioClipReference timeResult;

		public AudioClipReference newJigsawEventStart;

		public AudioClipReference newJigsawEventCompleted;

		public AudioClipReference valenttinesdayIAP;

		public AudioClipReference valenttinesdayPopup;

		public AudioClipReference pvpWin;

		public AudioClipReference pvpLoss;

		public AudioClipReference pvpFindingPlayers;

		public AudioClipReference newQueenPlaybackSound;

		public AudioClipReference playbackQueenEnding;

		public AudioClipReference trophyRewardedFly;

		[Header("Christmas Theme")]
		public AudioClipReference xmasDinner;

		public AudioClipReference xmasStick;

		public AudioClipReference xmasCarGift;

		public AudioClipReference xmasCookies;

		public AudioClipReference xmasSantaSleigh;

		public AudioClipReference xmasTree;

		[Header("Ocean Theme")]
		public AudioClipReference seaHorseJigsaw;

		public AudioClipReference jellyFishJigsaw;

		public AudioClipReference schoolofFishJigsaw;

		public AudioClipReference octopusJigsaw;

		public AudioClipReference pearlJigsaw;

		public AudioClipReference turtleJigsaw;

		public AudioClipReference whaleJigsaw;

		[Header("Streak Break")]
		public AudioClipReference streakBreak;

		public AudioClipReference countDownBroken;

		[Header("Jigsaw IAP")]
		public AudioClipReference jigsawIapButton;

		public AudioClipReference jigsawIapBarFill;

		public AudioClipReference jigsawIapMilestone;

		[Header("Valentines Theme")]
		public AudioClipReference coffee;

		public AudioClipReference fountain;

		public AudioClipReference garden;

		public AudioClipReference letter;

		[Header("Decorama")]
		public AudioClipReference decoramaFill;

		public AudioClipReference decoramaFillButton;

		public AudioClipReference decoramaObjectComplete;

		public AudioClipReference decoramaComplete;

		public AudioClipReference decoramaEmptyPaint;

		public AudioClipReference paintablePop;

		[Header("Leaderboard & leagues")]
		public AudioClipReference leaderboardScrolling;

		public AudioClipReference leaderboardComplete;

		public AudioClipReference leaguePromotion;

		public AudioClipReference leagueDemotion;

		public AudioClipReference leagueFinished;

		public AudioClipReference leagueContinue;

		[Header("Shop Sounds")]
		public AudioClipReference buttonShopBuy;

		public AudioClipReference shopRewardReceived;

		[Header("Core")]
		public AudioClipReference ButtonPositive;

		public AudioClipReference ButtonNegative;

		public AudioClipReference AutoButton;

		public AudioClipReference CoinWidgetTallyUp;

		public AudioClipReference CoinWidgetTallyDown;

		[Header("Music")]
		public AudioClipReference MusicMain;

		public AudioClipReference MusicMenu;
	}
}
