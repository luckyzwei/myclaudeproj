using System.Collections.Generic;

namespace KWCore.SaveData
{
	public class BucketGameplay : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_GAMEPLAY";

		[KeyBool]
		public const string MILESTONES_SENT = "milestones_sent";

		[KeyBool]
		public const string FTUE_GAMEPLAY_COMPLETED = "ftue_gameplay";

		[KeyInt]
		public const string NUM_QUEEN_EVENT_GEMS_COLLECTED = "num_queen_event_gems_collected";

		[KeyInt]
		public const string NUM_LAST_SEEN_GEMS = "num_last_seen_gems";

		[KeyString]
		public const string QUEEN_EVENT_REWARDS_CLAIMED = "queen_event_rewards_claimed";

		[KeyBool]
		public const string QUEEN_EVENT_INFO_SEEN = "queen_event_info_seen";

		[SubkeyInt]
		public const string DAILY_CHALLENGE_ATTEMPS = "daily_challenge_attempts";

		[KeyBool]
		public const string GEM_MIGRATION_COMPLETED = "gem_migration_completed";

		[KeyInt]
		public const string LAST_QUEENS_EVENT_START_DAY = "last_queens_event_start_day";

		[KeyInt]
		public const string LAST_QUEENS_START_POPUP_SEEN = "last_queens_event_start_popup_seen";

		[KeyInt]
		public const string GEMS_STARTING_THIS_EVENT = "gems_starting_this_event";

		[KeyBool]
		public const string FIRST_BOOT = "first_boot";

		[KeyString]
		public const string CONTROL_SCHEME_NAME = "control_scheme_name";

		[KeyInt]
		public const string LOSES_IN_ROW = "loses_in_row";

		[KeyInt]
		public const string SHOWN_TUTORIAL_AMOUNT = "shown_tutorial_amount";

		[KeyInt]
		public const string LAST_LEVEL_TUTORIAL_WAS_SHOWN = "last_level_tutorial_was_shown";

		[KeyInt]
		public const string JIGSAW_PIECES_TO_GIVE = "jigsaw_pieces_to_give";

		[KeyBool]
		public const string JIGSAW_FTUE = "jigsaw_ftue";

		[KeyString]
		public const string JIGSAW_EVENT_UNCLAIMED_REWARDS = "jigsaw_event_unclaimed_rewards";

		[KeyInt]
		public const string QUEENS_EVENT_REWARD_INDEX = "queens_event_reward_index";

		[KeyBool]
		public const string KILLED_DURING_AD = "killed_during_ad";

		[KeyInt]
		public const string CHECKOUT_VIP_TIMES = "checkout_vip_times";

		[KeyBool]
		public const string LAST_SEEN_DISCOUNTED = "last_seen_discounted";

		[KeyBool]
		public const string STARTING_PIECES_GIVEN = "starting_pieces_given";

		[KeyBool]
		public const string SEEN_JIGSAW_FTUE = "seen_jigsaw_ftue";

		[KeyBool]
		public const string SWIPE_TO_X_DISCOVERED = "swipe_to_x_discovered";

		[KeyBool]
		public const string HAS_COLLECTED_ALL_QUEENS_REWARDS = "collected_all_queen_rewards";

		[KeyString]
		public const string VISITED_COLLECTIONS = "visited_locations";

		[KeyInt]
		public const string FORCED_HOME_FEATURES = "forced_home_features";

		[KeyBool]
		public const string ACCESIBILITY_ON = "accesiblity_on";

		[KeyBool]
		public const string GRAND_PRIZE_MIGRATION_DONE = "grand_prize_mig";

		[KeyBool]
		public const string NAKAMA_SYNCED = "nakama_synced";

		[KeyBool]
		public const string SWIPE_TUTORIAL_DISPLAYED = "swipe_tutorial_displayed";

		[KeyInt]
		public const string LAST_LEVEL_PLAYER_SWIPED = "last_level_player_swiped";

		[KeyBool]
		public const string SWIPE_EVENT_SENT_OTHER_LEVELS = "swipe_event_sent_other_levels";

		[KeyString]
		public const string AVATARS_USED = "avatars_used";

		[KeyBool]
		public const string RV_DC_COMPLETED = "rv_dc_completed";

		[KeyInt]
		public const string RV_IAP_SUGGEST_DAY = "rv_iap_suggest_day";

		[KeyList(typeof(string))]
		public const string PROFILE_BG_ANALYTICS_SENT_FOR = "profile_bg_analytics_sent_for";

		[KeyBool]
		public const string SHOW_CONTROL_SCHEME_DEBUG = "show_control_scheme_debug";

		[KeyString]
		public const string DC_FREE_LEVEL = "dc_free_level";

		[KeyInt]
		public const string GAMEPLAY_FREE_LEVEL = "gameplay_free_level";

		[SubkeyBool]
		public const string FEATURE_UPDATE_SHOWN = "feature_update_shown";

		[KeyBool]
		public const string SEEN_SKIN_UNLOCK = "seen_skin_unlock";

		[KeyBool]
		public const string FREE_AUTO_X_USED = "free_auto_x_used";

		[KeyBool]
		public const string FREE_AUTO_X_MIGRATED = "free_auto_x_migrated";

		[KeyBool]
		public const string BALANCY_CARNIVAL_MIGRATED = "balancy_carnival_migrated";

		[KeyInt]
		public const string EXPERT_MODE_CURRENT_LEVEL = "expert_mode_current_level";

		private static BucketGameplay s_bucketgameplay;

		public static bool MilestonesSent
		{
			get { return GetBucket().GetBool(MILESTONES_SENT); }
			set { GetBucket().SetBool(MILESTONES_SENT, value); }
		}

		public static bool FtueGameplayCompleted
		{
			get { return GetBucket().GetBool(FTUE_GAMEPLAY_COMPLETED); }
			set { GetBucket().SetBool(FTUE_GAMEPLAY_COMPLETED, value); }
		}

		public static int NumQueenEventGemsCollected
		{
			get { return GetBucket().GetInt(NUM_QUEEN_EVENT_GEMS_COLLECTED); }
			set { GetBucket().SetInt(NUM_QUEEN_EVENT_GEMS_COLLECTED, value); }
		}

		public static int NumLastSeenGems
		{
			get { return GetBucket().GetInt(NUM_LAST_SEEN_GEMS); }
			set { GetBucket().SetInt(NUM_LAST_SEEN_GEMS, value); }
		}

		public static string QueenEventRewardsClaimed
		{
			get { return GetBucket().GetString(QUEEN_EVENT_REWARDS_CLAIMED); }
			set { GetBucket().SetString(QUEEN_EVENT_REWARDS_CLAIMED, value); }
		}

		public static bool QueenEventInfoSeen
		{
			get { return GetBucket().GetBool(QUEEN_EVENT_INFO_SEEN); }
			set { GetBucket().SetBool(QUEEN_EVENT_INFO_SEEN, value); }
		}

		public static bool GemMigrationCompleted
		{
			get { return GetBucket().GetBool(GEM_MIGRATION_COMPLETED); }
			set { GetBucket().SetBool(GEM_MIGRATION_COMPLETED, value); }
		}

		public static int LastQueensEventStartDay
		{
			get { return GetBucket().GetInt(LAST_QUEENS_EVENT_START_DAY); }
			set { GetBucket().SetInt(LAST_QUEENS_EVENT_START_DAY, value); }
		}

		public static int LastQueensStartPopupSeen
		{
			get { return GetBucket().GetInt(LAST_QUEENS_START_POPUP_SEEN); }
			set { GetBucket().SetInt(LAST_QUEENS_START_POPUP_SEEN, value); }
		}

		public static int GemsStartingThisEvent
		{
			get { return GetBucket().GetInt(GEMS_STARTING_THIS_EVENT); }
			set { GetBucket().SetInt(GEMS_STARTING_THIS_EVENT, value); }
		}

		public static bool FirstBoot
		{
			get { return GetBucket().GetBool(FIRST_BOOT); }
			set { GetBucket().SetBool(FIRST_BOOT, value); }
		}

		public static string ControlSchemeName
		{
			get { return GetBucket().GetString(CONTROL_SCHEME_NAME); }
			set { GetBucket().SetString(CONTROL_SCHEME_NAME, value); }
		}

		public static int LosesInRow
		{
			get { return GetBucket().GetInt(LOSES_IN_ROW); }
			set { GetBucket().SetInt(LOSES_IN_ROW, value); }
		}

		public static int ShownTutorialAmount
		{
			get { return GetBucket().GetInt(SHOWN_TUTORIAL_AMOUNT); }
			set { GetBucket().SetInt(SHOWN_TUTORIAL_AMOUNT, value); }
		}

		public static int LastLevelTutorialWasShown
		{
			get { return GetBucket().GetInt(LAST_LEVEL_TUTORIAL_WAS_SHOWN); }
			set { GetBucket().SetInt(LAST_LEVEL_TUTORIAL_WAS_SHOWN, value); }
		}

		public static int JigsawPiecesToGive
		{
			get { return GetBucket().GetInt(JIGSAW_PIECES_TO_GIVE); }
			set { GetBucket().SetInt(JIGSAW_PIECES_TO_GIVE, value); }
		}

		public static bool JigsawFtue
		{
			get { return GetBucket().GetBool(JIGSAW_FTUE); }
			set { GetBucket().SetBool(JIGSAW_FTUE, value); }
		}

		public static string JigsawEventUnclaimedRewards
		{
			get { return GetBucket().GetString(JIGSAW_EVENT_UNCLAIMED_REWARDS); }
			set { GetBucket().SetString(JIGSAW_EVENT_UNCLAIMED_REWARDS, value); }
		}

		public static int QueensEventRewardIndex
		{
			get { return GetBucket().GetInt(QUEENS_EVENT_REWARD_INDEX); }
			set { GetBucket().SetInt(QUEENS_EVENT_REWARD_INDEX, value); }
		}

		public static bool KilledDuringAd
		{
			get { return GetBucket().GetBool(KILLED_DURING_AD); }
			set { GetBucket().SetBool(KILLED_DURING_AD, value); }
		}

		public static int CheckoutVipTimes
		{
			get { return GetBucket().GetInt(CHECKOUT_VIP_TIMES); }
			set { GetBucket().SetInt(CHECKOUT_VIP_TIMES, value); }
		}

		public static bool LastSeenDiscounted
		{
			get { return GetBucket().GetBool(LAST_SEEN_DISCOUNTED); }
			set { GetBucket().SetBool(LAST_SEEN_DISCOUNTED, value); }
		}

		public static bool StartingPiecesGiven
		{
			get { return GetBucket().GetBool(STARTING_PIECES_GIVEN); }
			set { GetBucket().SetBool(STARTING_PIECES_GIVEN, value); }
		}

		public static bool SeenJigsawFtue
		{
			get { return GetBucket().GetBool(SEEN_JIGSAW_FTUE); }
			set { GetBucket().SetBool(SEEN_JIGSAW_FTUE, value); }
		}

		public static bool SwipeToXDiscovered
		{
			get { return GetBucket().GetBool(SWIPE_TO_X_DISCOVERED); }
			set { GetBucket().SetBool(SWIPE_TO_X_DISCOVERED, value); }
		}

		public static bool HasCollectedAllQueensRewards
		{
			get { return GetBucket().GetBool(HAS_COLLECTED_ALL_QUEENS_REWARDS); }
			set { GetBucket().SetBool(HAS_COLLECTED_ALL_QUEENS_REWARDS, value); }
		}

		public static string VisitedCollections
		{
			get { return GetBucket().GetString(VISITED_COLLECTIONS); }
			set { GetBucket().SetString(VISITED_COLLECTIONS, value); }
		}

		public static int ForcedHomeFeatures
		{
			get { return GetBucket().GetInt(FORCED_HOME_FEATURES); }
			set { GetBucket().SetInt(FORCED_HOME_FEATURES, value); }
		}

		public static bool AccesibilityOn
		{
			get { return GetBucket().GetBool(ACCESIBILITY_ON); }
			set { GetBucket().SetBool(ACCESIBILITY_ON, value); }
		}

		public static bool GrandPrizeMigrationDone
		{
			get { return GetBucket().GetBool(GRAND_PRIZE_MIGRATION_DONE); }
			set { GetBucket().SetBool(GRAND_PRIZE_MIGRATION_DONE, value); }
		}

		public static bool NakamaSynced
		{
			get { return GetBucket().GetBool(NAKAMA_SYNCED); }
			set { GetBucket().SetBool(NAKAMA_SYNCED, value); }
		}

		public static bool SwipeTutorialDisplayed
		{
			get { return GetBucket().GetBool(SWIPE_TUTORIAL_DISPLAYED); }
			set { GetBucket().SetBool(SWIPE_TUTORIAL_DISPLAYED, value); }
		}

		public static int LastLevelPlayerSwiped
		{
			get { return GetBucket().GetInt(LAST_LEVEL_PLAYER_SWIPED); }
			set { GetBucket().SetInt(LAST_LEVEL_PLAYER_SWIPED, value); }
		}

		public static bool SwipeEventSentOtherLevels
		{
			get { return GetBucket().GetBool(SWIPE_EVENT_SENT_OTHER_LEVELS); }
			set { GetBucket().SetBool(SWIPE_EVENT_SENT_OTHER_LEVELS, value); }
		}

		public static string AvatarsUsed
		{
			get { return GetBucket().GetString(AVATARS_USED); }
			set { GetBucket().SetString(AVATARS_USED, value); }
		}

		public static bool RvDcCompleted
		{
			get { return GetBucket().GetBool(RV_DC_COMPLETED); }
			set { GetBucket().SetBool(RV_DC_COMPLETED, value); }
		}

		public static int RvIapSuggestDay
		{
			get { return GetBucket().GetInt(RV_IAP_SUGGEST_DAY); }
			set { GetBucket().SetInt(RV_IAP_SUGGEST_DAY, value); }
		}

		public static List<string> ProfileBgAnalyticsSentFor
		{
			get { return GetBucket().GetList<string>(PROFILE_BG_ANALYTICS_SENT_FOR) ?? new List<string>(); }
			set { GetBucket().SetList(PROFILE_BG_ANALYTICS_SENT_FOR, value); }
		}

		public static bool ShowControlSchemeDebug
		{
			get { return GetBucket().GetBool(SHOW_CONTROL_SCHEME_DEBUG); }
			set { GetBucket().SetBool(SHOW_CONTROL_SCHEME_DEBUG, value); }
		}

		public static string DcFreeLevel
		{
			get { return GetBucket().GetString(DC_FREE_LEVEL); }
			set { GetBucket().SetString(DC_FREE_LEVEL, value); }
		}

		public static int GameplayFreeLevel
		{
			get { return GetBucket().GetInt(GAMEPLAY_FREE_LEVEL); }
			set { GetBucket().SetInt(GAMEPLAY_FREE_LEVEL, value); }
		}

		public static bool SeenSkinUnlock
		{
			get { return GetBucket().GetBool(SEEN_SKIN_UNLOCK); }
			set { GetBucket().SetBool(SEEN_SKIN_UNLOCK, value); }
		}

		public static bool FreeAutoXUsed
		{
			get { return GetBucket().GetBool(FREE_AUTO_X_USED); }
			set { GetBucket().SetBool(FREE_AUTO_X_USED, value); }
		}

		public static bool FreeAutoXMigrated
		{
			get { return GetBucket().GetBool(FREE_AUTO_X_MIGRATED); }
			set { GetBucket().SetBool(FREE_AUTO_X_MIGRATED, value); }
		}

		public static bool BalancyCarnivalMigrated
		{
			get { return GetBucket().GetBool(BALANCY_CARNIVAL_MIGRATED); }
			set { GetBucket().SetBool(BALANCY_CARNIVAL_MIGRATED, value); }
		}

		public static int ExpertModeCurrentLevel
		{
			get { return GetBucket().GetInt(EXPERT_MODE_CURRENT_LEVEL); }
			set { GetBucket().SetInt(EXPERT_MODE_CURRENT_LEVEL, value); }
		}

		public override string GetBucketKey()
		{
			return BUCKET_KEY;
		}

		public override bool IsStoredInCloud()
		{
			return true;
		}

		private static BucketGameplay GetBucket()
		{
			if (s_bucketgameplay == null)
			{
				s_bucketgameplay = new BucketGameplay();
				s_bucketgameplay.LoadFromDisk();
			}
			return s_bucketgameplay;
		}

		public static bool GetMilestonesSent(bool defaultValue = false)
		{
			return GetBucket().GetBool(MILESTONES_SENT, defaultValue);
		}

		public static void SetMilestonesSent(bool value)
		{
			GetBucket().SetBool(MILESTONES_SENT, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetFtueGameplayCompleted(bool defaultValue = false)
		{
			return GetBucket().GetBool(FTUE_GAMEPLAY_COMPLETED, defaultValue);
		}

		public static void SetFtueGameplayCompleted(bool value)
		{
			GetBucket().SetBool(FTUE_GAMEPLAY_COMPLETED, value);
			GetBucket().SaveToDisk();
		}

		public static int GetNumQueenEventGemsCollected(int defaultValue = 0)
		{
			return GetBucket().GetInt(NUM_QUEEN_EVENT_GEMS_COLLECTED, defaultValue);
		}

		public static void SetNumQueenEventGemsCollected(int value)
		{
			GetBucket().SetInt(NUM_QUEEN_EVENT_GEMS_COLLECTED, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetNumQueenEventGemsCollected(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(NUM_QUEEN_EVENT_GEMS_COLLECTED, increment);
		}

		public static int GetNumLastSeenGems(int defaultValue = 0)
		{
			return GetBucket().GetInt(NUM_LAST_SEEN_GEMS, defaultValue);
		}

		public static void SetNumLastSeenGems(int value)
		{
			GetBucket().SetInt(NUM_LAST_SEEN_GEMS, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetNumLastSeenGems(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(NUM_LAST_SEEN_GEMS, increment);
		}

		public static string GetQueenEventRewardsClaimed(string defaultValue = null)
		{
			return GetBucket().GetString(QUEEN_EVENT_REWARDS_CLAIMED, defaultValue);
		}

		public static void SetQueenEventRewardsClaimed(string value)
		{
			GetBucket().SetString(QUEEN_EVENT_REWARDS_CLAIMED, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetQueenEventInfoSeen(bool defaultValue = false)
		{
			return GetBucket().GetBool(QUEEN_EVENT_INFO_SEEN, defaultValue);
		}

		public static void SetQueenEventInfoSeen(bool value)
		{
			GetBucket().SetBool(QUEEN_EVENT_INFO_SEEN, value);
			GetBucket().SaveToDisk();
		}

		public static int GetDailyChallengeAttemps(string subkey, int defaultValue = 0)
		{
			return GetBucket().GetInt(DAILY_CHALLENGE_ATTEMPS, defaultValue, subkey);
		}

		public static void SetDailyChallengeAttemps(string subkey, int value)
		{
			GetBucket().SetInt(DAILY_CHALLENGE_ATTEMPS, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetDailyChallengeAttemps(string subkey, int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(DAILY_CHALLENGE_ATTEMPS, increment, subkey);
		}

		public static bool GetGemMigrationCompleted(bool defaultValue = false)
		{
			return GetBucket().GetBool(GEM_MIGRATION_COMPLETED, defaultValue);
		}

		public static void SetGemMigrationCompleted(bool value)
		{
			GetBucket().SetBool(GEM_MIGRATION_COMPLETED, value);
			GetBucket().SaveToDisk();
		}

		public static int GetLastQueensEventStartDay(int defaultValue = 0)
		{
			return GetBucket().GetInt(LAST_QUEENS_EVENT_START_DAY, defaultValue);
		}

		public static void SetLastQueensEventStartDay(int value)
		{
			GetBucket().SetInt(LAST_QUEENS_EVENT_START_DAY, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLastQueensEventStartDay(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(LAST_QUEENS_EVENT_START_DAY, increment);
		}

		public static int GetLastQueensStartPopupSeen(int defaultValue = 0)
		{
			return GetBucket().GetInt(LAST_QUEENS_START_POPUP_SEEN, defaultValue);
		}

		public static void SetLastQueensStartPopupSeen(int value)
		{
			GetBucket().SetInt(LAST_QUEENS_START_POPUP_SEEN, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLastQueensStartPopupSeen(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(LAST_QUEENS_START_POPUP_SEEN, increment);
		}

		public static int GetGemsStartingThisEvent(int defaultValue = 0)
		{
			return GetBucket().GetInt(GEMS_STARTING_THIS_EVENT, defaultValue);
		}

		public static void SetGemsStartingThisEvent(int value)
		{
			GetBucket().SetInt(GEMS_STARTING_THIS_EVENT, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetGemsStartingThisEvent(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(GEMS_STARTING_THIS_EVENT, increment);
		}

		public static bool GetFirstBoot(bool defaultValue = false)
		{
			return GetBucket().GetBool(FIRST_BOOT, defaultValue);
		}

		public static void SetFirstBoot(bool value)
		{
			GetBucket().SetBool(FIRST_BOOT, value);
			GetBucket().SaveToDisk();
		}

		public static string GetControlSchemeName(string defaultValue = null)
		{
			return GetBucket().GetString(CONTROL_SCHEME_NAME, defaultValue);
		}

		public static void SetControlSchemeName(string value)
		{
			GetBucket().SetString(CONTROL_SCHEME_NAME, value);
			GetBucket().SaveToDisk();
		}

		public static int GetLosesInRow(int defaultValue = 0)
		{
			return GetBucket().GetInt(LOSES_IN_ROW, defaultValue);
		}

		public static void SetLosesInRow(int value)
		{
			GetBucket().SetInt(LOSES_IN_ROW, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLosesInRow(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(LOSES_IN_ROW, increment);
		}

		public static int GetShownTutorialAmount(int defaultValue = 0)
		{
			return GetBucket().GetInt(SHOWN_TUTORIAL_AMOUNT, defaultValue);
		}

		public static void SetShownTutorialAmount(int value)
		{
			GetBucket().SetInt(SHOWN_TUTORIAL_AMOUNT, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetShownTutorialAmount(int increment = 1)
		{
			int val = GetBucket().IncrementAndSetInt(SHOWN_TUTORIAL_AMOUNT, increment);
			GetBucket().SaveToDisk();
			return val;
		}

		public static int GetLastLevelTutorialWasShown(int defaultValue = 0)
		{
			return GetBucket().GetInt(LAST_LEVEL_TUTORIAL_WAS_SHOWN, defaultValue);
		}

		public static void SetLastLevelTutorialWasShown(int value)
		{
			GetBucket().SetInt(LAST_LEVEL_TUTORIAL_WAS_SHOWN, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLastLevelTutorialWasShown(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(LAST_LEVEL_TUTORIAL_WAS_SHOWN, increment);
		}

		public static int GetJigsawPiecesToGive(int defaultValue = 0)
		{
			return GetBucket().GetInt(JIGSAW_PIECES_TO_GIVE, defaultValue);
		}

		public static void SetJigsawPiecesToGive(int value)
		{
			GetBucket().SetInt(JIGSAW_PIECES_TO_GIVE, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetJigsawPiecesToGive(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(JIGSAW_PIECES_TO_GIVE, increment);
		}

		public static bool GetJigsawFtue(bool defaultValue = false)
		{
			return GetBucket().GetBool(JIGSAW_FTUE, defaultValue);
		}

		public static void SetJigsawFtue(bool value)
		{
			GetBucket().SetBool(JIGSAW_FTUE, value);
			GetBucket().SaveToDisk();
		}

		public static string GetJigsawEventUnclaimedRewards(string defaultValue = null)
		{
			return GetBucket().GetString(JIGSAW_EVENT_UNCLAIMED_REWARDS, defaultValue);
		}

		public static void SetJigsawEventUnclaimedRewards(string value)
		{
			GetBucket().SetString(JIGSAW_EVENT_UNCLAIMED_REWARDS, value);
			GetBucket().SaveToDisk();
		}

		public static int GetQueensEventRewardIndex(int defaultValue = 0)
		{
			return GetBucket().GetInt(QUEENS_EVENT_REWARD_INDEX, defaultValue);
		}

		public static void SetQueensEventRewardIndex(int value)
		{
			GetBucket().SetInt(QUEENS_EVENT_REWARD_INDEX, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetQueensEventRewardIndex(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(QUEENS_EVENT_REWARD_INDEX, increment);
		}

		public static bool GetKilledDuringAd(bool defaultValue = false)
		{
			return GetBucket().GetBool(KILLED_DURING_AD, defaultValue);
		}

		public static void SetKilledDuringAd(bool value)
		{
			GetBucket().SetBool(KILLED_DURING_AD, value);
			GetBucket().SaveToDisk();
		}

		public static int GetCheckoutVipTimes(int defaultValue = 0)
		{
			return GetBucket().GetInt(CHECKOUT_VIP_TIMES, defaultValue);
		}

		public static void SetCheckoutVipTimes(int value)
		{
			GetBucket().SetInt(CHECKOUT_VIP_TIMES, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetCheckoutVipTimes(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(CHECKOUT_VIP_TIMES, increment);
		}

		public static bool GetLastSeenDiscounted(bool defaultValue = false)
		{
			return GetBucket().GetBool(LAST_SEEN_DISCOUNTED, defaultValue);
		}

		public static void SetLastSeenDiscounted(bool value)
		{
			GetBucket().SetBool(LAST_SEEN_DISCOUNTED, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetStartingPiecesGiven(bool defaultValue = false)
		{
			return GetBucket().GetBool(STARTING_PIECES_GIVEN, defaultValue);
		}

		public static void SetStartingPiecesGiven(bool value)
		{
			GetBucket().SetBool(STARTING_PIECES_GIVEN, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetSeenJigsawFtue(bool defaultValue = false)
		{
			return GetBucket().GetBool(SEEN_JIGSAW_FTUE, defaultValue);
		}

		public static void SetSeenJigsawFtue(bool value)
		{
			GetBucket().SetBool(SEEN_JIGSAW_FTUE, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetSwipeToXDiscovered(bool defaultValue = false)
		{
			return GetBucket().GetBool(SWIPE_TO_X_DISCOVERED, defaultValue);
		}

		public static void SetSwipeToXDiscovered(bool value)
		{
			GetBucket().SetBool(SWIPE_TO_X_DISCOVERED, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetHasCollectedAllQueensRewards(bool defaultValue = false)
		{
			return GetBucket().GetBool(HAS_COLLECTED_ALL_QUEENS_REWARDS, defaultValue);
		}

		public static void SetHasCollectedAllQueensRewards(bool value)
		{
			GetBucket().SetBool(HAS_COLLECTED_ALL_QUEENS_REWARDS, value);
			GetBucket().SaveToDisk();
		}

		public static string GetVisitedCollections(string defaultValue = null)
		{
			return GetBucket().GetString(VISITED_COLLECTIONS, defaultValue);
		}

		public static void SetVisitedCollections(string value)
		{
			GetBucket().SetString(VISITED_COLLECTIONS, value);
			GetBucket().SaveToDisk();
		}

		public static int GetForcedHomeFeatures(int defaultValue = 0)
		{
			return GetBucket().GetInt(FORCED_HOME_FEATURES, defaultValue);
		}

		public static void SetForcedHomeFeatures(int value)
		{
			GetBucket().SetInt(FORCED_HOME_FEATURES, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetForcedHomeFeatures(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(FORCED_HOME_FEATURES, increment);
		}

		public static bool GetAccesibilityOn(bool defaultValue = false)
		{
			return GetBucket().GetBool(ACCESIBILITY_ON, defaultValue);
		}

		public static void SetAccesibilityOn(bool value)
		{
			GetBucket().SetBool(ACCESIBILITY_ON, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetGrandPrizeMigrationDone(bool defaultValue = false)
		{
			return GetBucket().GetBool(GRAND_PRIZE_MIGRATION_DONE, defaultValue);
		}

		public static void SetGrandPrizeMigrationDone(bool value)
		{
			GetBucket().SetBool(GRAND_PRIZE_MIGRATION_DONE, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetNakamaSynced(bool defaultValue = false)
		{
			return GetBucket().GetBool(NAKAMA_SYNCED, defaultValue);
		}

		public static void SetNakamaSynced(bool value)
		{
			GetBucket().SetBool(NAKAMA_SYNCED, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetSwipeTutorialDisplayed(bool defaultValue = false)
		{
			return GetBucket().GetBool(SWIPE_TUTORIAL_DISPLAYED, defaultValue);
		}

		public static void SetSwipeTutorialDisplayed(bool value)
		{
			GetBucket().SetBool(SWIPE_TUTORIAL_DISPLAYED, value);
			GetBucket().SaveToDisk();
		}

		public static int GetLastLevelPlayerSwiped(int defaultValue = 0)
		{
			return GetBucket().GetInt(LAST_LEVEL_PLAYER_SWIPED, defaultValue);
		}

		public static void SetLastLevelPlayerSwiped(int value)
		{
			GetBucket().SetInt(LAST_LEVEL_PLAYER_SWIPED, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLastLevelPlayerSwiped(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(LAST_LEVEL_PLAYER_SWIPED, increment);
		}

		public static bool GetSwipeEventSentOtherLevels(bool defaultValue = false)
		{
			return GetBucket().GetBool(SWIPE_EVENT_SENT_OTHER_LEVELS, defaultValue);
		}

		public static void SetSwipeEventSentOtherLevels(bool value)
		{
			GetBucket().SetBool(SWIPE_EVENT_SENT_OTHER_LEVELS, value);
			GetBucket().SaveToDisk();
		}

		public static string GetAvatarsUsed(string defaultValue = null)
		{
			return GetBucket().GetString(AVATARS_USED, defaultValue);
		}

		public static void SetAvatarsUsed(string value)
		{
			GetBucket().SetString(AVATARS_USED, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetRvDcCompleted(bool defaultValue = false)
		{
			return GetBucket().GetBool(RV_DC_COMPLETED, defaultValue);
		}

		public static void SetRvDcCompleted(bool value)
		{
			GetBucket().SetBool(RV_DC_COMPLETED, value);
			GetBucket().SaveToDisk();
		}

		public static int GetRvIapSuggestDay(int defaultValue = 0)
		{
			return GetBucket().GetInt(RV_IAP_SUGGEST_DAY, defaultValue);
		}

		public static void SetRvIapSuggestDay(int value)
		{
			GetBucket().SetInt(RV_IAP_SUGGEST_DAY, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetRvIapSuggestDay(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(RV_IAP_SUGGEST_DAY, increment);
		}

		public static List<string> GetProfileBgAnalyticsSentFor()
		{
			return GetBucket().GetList<string>(PROFILE_BG_ANALYTICS_SENT_FOR) ?? new List<string>();
		}

		public static void SetProfileBgAnalyticsSentFor(List<string> value)
		{
			GetBucket().SetList(PROFILE_BG_ANALYTICS_SENT_FOR, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetShowControlSchemeDebug(bool defaultValue = false)
		{
			return GetBucket().GetBool(SHOW_CONTROL_SCHEME_DEBUG, defaultValue);
		}

		public static void SetShowControlSchemeDebug(bool value)
		{
			GetBucket().SetBool(SHOW_CONTROL_SCHEME_DEBUG, value);
			GetBucket().SaveToDisk();
		}

		public static string GetDcFreeLevel(string defaultValue = null)
		{
			return GetBucket().GetString(DC_FREE_LEVEL, defaultValue);
		}

		public static void SetDcFreeLevel(string value)
		{
			GetBucket().SetString(DC_FREE_LEVEL, value);
			GetBucket().SaveToDisk();
		}

		public static int GetGameplayFreeLevel(int defaultValue = 0)
		{
			return GetBucket().GetInt(GAMEPLAY_FREE_LEVEL, defaultValue);
		}

		public static void SetGameplayFreeLevel(int value)
		{
			GetBucket().SetInt(GAMEPLAY_FREE_LEVEL, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetGameplayFreeLevel(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(GAMEPLAY_FREE_LEVEL, increment);
		}

		public static bool GetFeatureUpdateShown(string subkey, bool defaultValue = false)
		{
			return GetBucket().GetBool(FEATURE_UPDATE_SHOWN, defaultValue, subkey);
		}

		public static void SetFeatureUpdateShown(string subkey, bool value)
		{
			GetBucket().SetBool(FEATURE_UPDATE_SHOWN, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static bool GetSeenSkinUnlock(bool defaultValue = false)
		{
			return GetBucket().GetBool(SEEN_SKIN_UNLOCK, defaultValue);
		}

		public static void SetSeenSkinUnlock(bool value)
		{
			GetBucket().SetBool(SEEN_SKIN_UNLOCK, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetFreeAutoXUsed(bool defaultValue = false)
		{
			return GetBucket().GetBool(FREE_AUTO_X_USED, defaultValue);
		}

		public static void SetFreeAutoXUsed(bool value)
		{
			GetBucket().SetBool(FREE_AUTO_X_USED, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetFreeAutoXMigrated(bool defaultValue = false)
		{
			return GetBucket().GetBool(FREE_AUTO_X_MIGRATED, defaultValue);
		}

		public static void SetFreeAutoXMigrated(bool value)
		{
			GetBucket().SetBool(FREE_AUTO_X_MIGRATED, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetBalancyCarnivalMigrated(bool defaultValue = false)
		{
			return GetBucket().GetBool(BALANCY_CARNIVAL_MIGRATED, defaultValue);
		}

		public static void SetBalancyCarnivalMigrated(bool value)
		{
			GetBucket().SetBool(BALANCY_CARNIVAL_MIGRATED, value);
			GetBucket().SaveToDisk();
		}

		public static int GetExpertModeCurrentLevel(int defaultValue = 0)
		{
			return GetBucket().GetInt(EXPERT_MODE_CURRENT_LEVEL, defaultValue);
		}

		public static void SetExpertModeCurrentLevel(int value)
		{
			GetBucket().SetInt(EXPERT_MODE_CURRENT_LEVEL, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetExpertModeCurrentLevel(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(EXPERT_MODE_CURRENT_LEVEL, increment);
		}
	}
}
