using System;
using Balancy.Models;
using KWGameCore;
using UnityEngine;

public class ConfigParams : GenericConfig<ConfigParams>
{
	public enum DiscountVIPState
	{
		BALANCY = 0,
		ALWAYS_NO_DISCOUNT = 1,
		ALWAYS_DISCOUNT = 2
	}

	public enum LimitedOfferBehaviour
	{
		NORMAL = 0,
		ONLY_TRIAL = 1,
		ONLY_PURCHASE = 2
	}

	public enum OpponentResult
	{
		NO_CHANGE = 0,
		FORCE_OPPONENT_WIN = 1,
		FORCE_OPPONENT_LOSE_NO_MISTAKE = 2,
		FORCE_OPPONENT_LOSE_1_MISTAKE = 3,
		FORCE_OPPONENT_LOSE_2_MISTAKE = 4,
		FORCE_OPPONENT_LOSE_BY_HEARTS = 5
	}

	[Serializable]
	public class SpecialOffer
	{
		public SpecialOfferContainerData containerData;
	}

	[Serializable]
	public class TestParams
	{
		public bool unlockSpinWheel;

		public bool unlockDailyChallenge;

		public bool unlockPVPChallengeButton;

		[Space]
		public bool testDailyChallengesProgress;

		public int dailyChallengeStartProgress;

		public int dailyChallengeTargetProgress;

		public bool dontClearNewDailyChallenges;

		[Space]
		public bool overrideControlScheme;

		public ControlSchemes selectedControlScehemeIndex;

		[Space]
		public bool queensEventEnded;

		public int queensLastSeenGems;

		[Space]
		public bool testGemsProgress;

		public int testStartingGems;

		public int testTargetGems;

		[Space]
		public bool verbose;

		public bool jigsawPuzzles;

		[Space]
		public bool useOldColors;

		[Space]
		public DiscountVIPState discountVipState;

		[Space]
		public bool freeBoosters;

		[Space]
		public bool specialOffer;

		public int specialOfferIndex;

		public bool testDiscountedOffer;

		[Space]
		public bool pushMessagesShortTime;

		[Space]
		public bool showNoAdsTimeLeft;

		[Header("Limited Time Offers")]
		public bool forceActiveLimitedOffer;

		public string limitedOfferID;

		public LimitedOfferBehaviour limitedOfferBehaviour;

		[Space]
		public bool levelTimerShortWarningTimes;

		[Space]
		public bool show2026forDailyChallenges;

		[Space]
		public bool testDifferentBoardSizes;

		public float testDifferentBoardSizesTime;

		[Space]
		public bool forceReceiveChallenge;

		public OpponentResult forceChallengeResult;
	}

	[Serializable]
	public class LeaderboardParams
	{
		public float autoscrollStartDelay;

		public float playerCellIntroDelay;

		public float scrollDuration;

		public float endDelay;

		public float lerpScoreDuration;

		public float lerpScoreDelay;

		public float punchScale;

		public float punchScaleTime;
	}

	[Serializable]
	public class QueensEventParams
	{
		public float startDelay;

		public float endDelay;

		public float[] progressDurationsForSlots;

		public bool showCompletePopup;

		public float autoClosePopupTime;
	}

	[Serializable]
	public class LevelEndFlow
	{
		[Serializable]
		public struct Gradient
		{
			public Color color1;

			public Color color2;
		}

		public float delayAfterWin;

		public float delayAfterWinFtueLevel;

		public float delayBeforeGameOver;

		public float delayButtons;

		public float delayRvButton;

		public float rewardSectionComeInDelayAfterPlayerCellMvement;

		public float doubleRewardComeInDelayAfterPlayerCellMvement;

		public Color[] rewardColors;

		public Gradient[] rewardGradients;
	}

	[Serializable]
	public class Sound
	{
		public int clickSoundToPlay;

		public int XSoundToPlay;

		public int RemoveXSoundToPlay;

		public float TimeToResetPitch;

		public float hintDelay;

		public float musicFadeOutTime;

		public float musicFadeInTime;
	}

	[Serializable]
	public class JigsawGenerationSettings
	{
		[Header("Piece Appearance")]
		[Tooltip("Knob radius as a factor of min(cellWidth, cellHeight). Recommended: 0.1 to 0.35")]
		public float knobFactor;

		[Tooltip("Pixels per unit for generated sprites.")]
		public float pixelsPerUnit;

		[Tooltip("Add a small overlap to pieces to hide seams.")]
		public bool addPixelOverlap;

		[Tooltip("Scale factor for SpriteRenderer overlap (e.g., 1.005 for 0.5% bigger).")]
		public float spriteOverlapScaleFactor;

		[Tooltip("Pixel amount to increase UI Image size for overlap (applied to width and height).")]
		public float uiOverlapPixelAmount;

		[Tooltip("If true and puzzleUiParentArea is set, UI pieces will stretch to fill it, ignoring aspect ratio.")]
		public bool stretchUiToFillParent;

		[Header("Caching & Performance")]
		public bool forceRegenerateAtlas;

		public string atlasSaveDirectory;

		public int yieldAfterPiecesProcessed;

		[Header("Animation")]
		public float cellsStartDelay;

		public float cellAnimateTime;

		public float cellDelayBetween;

		public float cellAcceleration;

		public float rewardDelay;

		public AnimationCurve cellScaleUpCurve;

		public AnimationCurve fragmentScaleCurve;

		public float fragmentStartScale;

		public float fragmentFinalScale;

		public float fragmentMoveTime;

		public bool waitBetweenRows;

		public float scrollDuration;

		public float delayAfterScroll;

		public float delayBeforeScroll;

		public float cellOffsetY;

		public float sfxMinDelay;

		public float whiteHideDuration;
	}

	[Serializable]
	public class CrossSettings
	{
		public float changeColorToRedTime;
	}

	[Serializable]
	public class HintsSettings
	{
		public float applyButtonAppearDelay;

		public float applyButtonAppearTime;

		public float autoDoDelayTime;

		public float autoSpeedMultiplier;

		public string highlightFormat;

		public float delayBeforeMaskDisappear;

		public float maskFadeTime;

		public float maskExtraSize;
	}

	public class ColourSettings
	{
		public static bool useRandomColours;

		public static int randomSeed;
	}

	[Serializable]
	public class InputSettings
	{
		public Vector3 holdTimerOffset;

		public bool usePrediction;

		public float predictColliderSizeScale;
	}

	[Serializable]
	public class PushMessages
	{
		public int gemsNeededForNextReward;

		public TimeSpanSerializable minTimeGems;

		public TimeSpanSerializable maxTimeGems;

		[Space]
		public TimeSpanSerializable notPlayedMinTime;

		public TimeSpanSerializable notPlayedMaxTime;

		[Space]
		public int pieceNeededForNextJigsaw;

		public TimeSpanSerializable jigsawMinTime;

		public TimeSpanSerializable jigsawMaxTime;

		[Space]
		public TimeSpanSerializable newCollectionMinTime;

		public TimeSpanSerializable newCollectionMaxTime;

		[Space]
		public TimeSpanSerializable vipOfferMinTime;

		public TimeSpanSerializable vipOfferMaxTime;

		[Header("Royal Tournament Live")]
		public TimeSpanSerializable royalTournamentStartOffsetMinTime;

		public TimeSpanSerializable royalTournamentStartOffsetMaxTime;

		[Header("Streak Started")]
		[Tooltip("The min time in the day it'll be sent, IE 8 AM")]
		public TimeSpanSerializable streakStartedMinTime;

		[Tooltip("The min time in the day it'll be sent, IE 2 PM (14:00)")]
		public TimeSpanSerializable streakStartedMaxTime;

		[Header("Streak Lose Warning")]
		[Tooltip("The min time before streak expirest")]
		public TimeSpanSerializable streakLoseWarningMinTimeBefore;

		[Tooltip("The max time before streak expirest, should be smaller than min time")]
		public TimeSpanSerializable streakLoseWarningMaxTimeBefore;

		[Header("Queens Event")]
		public TimeSpanSerializable queensEventMinTime;

		public TimeSpanSerializable queensEventMaxTime;

		[Header("Queens Event Last Chance")]
		public TimeSpanSerializable queensEventLastChanceMinTime;

		public TimeSpanSerializable queensEventLastChanceMaxTime;

		[Header("1 Daily Challenge left to Trophy")]
		public TimeSpanSerializable oneDcLeftToTrophyMinTime;

		public TimeSpanSerializable oneDcLeftToTrophyMaxTime;
	}

	[Serializable]
	public class LevelIntroFlow
	{
		public float noThanksDelay;

		public float autoCloseDelay;

		public float hardLevelFadeTime;
	}

	[Serializable]
	public class ExtraTutorial
	{
		public Vector2Int startCellOffset;

		public bool rotateClockwise;

		public bool disableInputOnFirstAnimationLoop;

		[Header("Hand Movement")]
		public float tapDownDelay;

		public float handUnitMovementDuration;

		public float handSpeedIncreaseOnCorners;

		public float handMovementDelay;

		[Space]
		public float waitAfterFirstTouch;

		public float minTimePopupShow;

		[Space]
		public float heartFadeInDelay;

		public float heartFadeInTime;

		[Space]
		public float rulesFadeInDelay;

		public float rulesFadeInTime;

		[Space]
		public float bubbleFadeOutDelay;

		public float bubbleFadeOutTime;
	}

	[Serializable]
	public class DailyChallenges
	{
		public float fillBarTime;

		public float startDelay;

		public float flyingEffectDelay;
	}

	[Serializable]
	public class FakePVP
	{
		[Header("Connecting Screen")]
		public float connectingTextMinTime;

		public float connectingTextMaxTime;

		[Space]
		public float startingTextMinTime;

		public float startingTextMaxTime;

		[Space]
		public float searchingOpponentMinTime;

		public float searchingOpponentMaxTime;

		[Space]
		public float waitAfterSearchMinTime;

		public float waitAfterSearchMaxTime;

		[Space]
		public TimeSpanSerializable disconnectTime;

		[Space]
		public float botActionTimeIfPlayerFailed;
	}

	public TestParams test;

	[Space]
	public SpecialOffer specialOffer;

	[Space]
	public LeaderboardParams leaderboard;

	[Space]
	public QueensEventParams queensEvent;

	[Space]
	public LevelEndFlow levelEndFlow;

	[Space]
	public Sound sound;

	[Space]
	public JigsawGenerationSettings jigsawGenerationSettings;

	[Space]
	public CrossSettings cross;

	[Space]
	public HintsSettings hints;

	[Space]
	public InputSettings input;

	[Space]
	public PushMessages pushMessages;

	[Space]
	public ExtraTutorial extraTutorial;

	[Space]
	public DailyChallenges dailyChallenges;

	[Space]
	public LevelIntroFlow levelIntroFlow;

	[Space]
	public FakePVP fakePVP;

	[Header("Queen Booster FTUE")]
	public int queenIndex;

	[Header("Haptics")]
	public float hapticsDelay;

	public float hapticsDelayWhistle;

	[Header("Jigsaw Puzzles")]
	public float grandRewardPrizeDelay;

	public float jigsawViewerForcePopup;

	public float pitchIncreasePerPieceInPuzzleScreen;

	public float pitchIncreasePerPiece;

	[Space]
	public bool showCellOutline;

	public float cellOutlineSize;

	public float cellSize;

	public float cameraMargin;

	public float cameraOffsetY;

	[Header("Haptics")]
	public float queenAmplitude;

	public float queenFrequency;

	[Space]
	public int delayFramesForPosition;
}
