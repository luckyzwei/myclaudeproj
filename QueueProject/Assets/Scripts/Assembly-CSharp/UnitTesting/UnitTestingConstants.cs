namespace UnitTesting
{
	public abstract class UnitTestingConstants
	{
		public static class UXMLPaths
		{
			public const string GROUPS_PAGE_UXML_PATH = "UXML/UnitTestGroupsPage";

			public const string UNIT_TEST_UXML_PATH = "UXML/UnitTestCasesPage";

			public const string UNIT_TEST_LIST_ITEM_PATH = "UXML/UnitTestCaseItem";

			public const string UNIT_TEST_LIST_ITEM_HEADER_PATH = "UXML/UnitTestTitlesSectionItem";

			public const string UNIT_TEST_FOOTER_COMPONENT = "UXML/UnitTestFooterComponent";

			public const string PROGRESS_POPUP_UXML_PATH = "UXML/PlayTestProgressPopupUI";

			public const string BOOT_SELECT_POPUP_UXML_PATH = "UXML/BootSelectionPopup";

			public const string RESULT_PAGE_UXML_PATH = "UXML/UnitTestResultPage";
		}

		public static class HeaderComponentUI
		{
			public const string HEADER_COMPONENT_TITLE_TEXT = "HeaderTitle";

			public const string HEADER_COMPONENT_BACK_BUTTON = "HeaderBackButton";
		}

		public static class UnitTestTitleSectionUI
		{
			public const string TEST_SECTION_TITLE_TEXT = "TestCasesTitleLabel";

			public const string TEST_SECTION_TOTAL_TEST_COUNT = "TotalTestsCountLabel";

			public const string TEST_SECTION_COMPLETED_TEST_COUNT = "CompletedTestsCountLabel";
		}

		public static class UnitTestGroupScreenUI
		{
			public const string PAGE_ROOT_CONTAINER = "UnitTestGroupsPage";

			public const string HEADER_INSTANCE = "HeaderInstance";

			public const string FOOTER_INSTANCE = "FooterInstance";

			public const string GROUP_TEST_LIST_VIEW = "TestCasesListView";
		}

		public static class UnitTestCasesScreenUI
		{
			public const string PAGE_ROOT_CONTAINER = "UnitTestCasesPage";

			public const string HEADER_INSTANCE = "HeaderInstance";

			public const string FOOTER_INSTANCE = "FooterInstance";

			public const string GROUP_TEST_LIST_VIEW = "TestCasesListView";
		}

		public static class UnitTestCasesResultUI
		{
			public const string PAGE_CARD_CONTAINER = "TopContainer";

			public const string PAGE_CARD_BACK_ICON = "DisclosureArrowElement";

			public const string LIST_ITEM_CONTAINER = "ListItemContainer";

			public const string HEADER_INSTANCE = "HeaderInstance";

			public const string FOOTER_INSTANCE = "FooterInstance";

			public const string GROUP_TEST_TEXT_NAME = "ResultGroupName";

			public const string TEST_RESULT_NAME = "ResultOutputLabel";
		}

		public static class UnitTestCaseListItemUI
		{
			public const string STATUS_ICON_OUTER = "StatusIconElement";

			public const string STATUS_ICON = "BackIcon";

			public const string MAIN_TITLE_TEXT = "TitleLabel";

			public const string SUB_TITLE_TEXT = "StatusLabel";

			public const string TEXT_PASSED_CLASS_SELECTOR = "status-text-passed";

			public const string TEXT_FAILED_CLASS_SELECTOR = "status-text-failed";

			public const string TEXT_RUNNING_CLASS_SELECTOR = "status-text-running";

			public const string TEXT_PENDING_CLASS_SELECTOR = "status-text-pending";

			public const string ICON_PASSED_CLASS_SELECTOR = "status-icon-passed";

			public const string ICON_FAILED_CLASS_SELECTOR = "status-icon-failed";

			public const string ICON_RUNNING_CLASS_SELECTOR = "status-icon-running";

			public const string ICON_PENDING_CLASS_SELECTOR = "status-icon-pending";

			public const string ICON_NONE_CLASS_SELECTOR = "status-icon-none";

			public const string BORDER_PASSED_CLASS_SELECTOR = "status-border-passed";

			public const string BORDER_FAILED_CLASS_SELECTOR = "status-border-failed";

			public const string BORDER_RUNNING_CLASS_SELECTOR = "status-border-running";

			public const string BORDER_PENDING_CLASS_SELECTOR = "status-border-pending";

			public const string BORDER_NONE_CLASS_SELECTOR = "status-border-none";
		}

		public static class UnitTestFooterComponentUI
		{
			public const string FOOTER_PROGRESS_STATUS_LABEL = "ProgressStatusLabel";

			public const string FOOTER_PROGRESS_VALUE_LABEL = "ProgressValueLabel";

			public const string FOOTER_UI_PROGRESS_BAR = "MainProgressBar";

			public const string FOOTER_UI_BUTTON = "FooterRunButton";

			public const string FOOTER_UI_RESET_BUTTON = "FooterResetButton";
		}

		public static class PlayModeTestProgressPopupUI
		{
			public const string LIST_PROGRESS_IMG_PATH = "Arts/Progress";

			public const string CARD = "progress-popup-card";

			public const string SPINNER = "progress-popup-spinner";

			public const string STEP = "progress-popup-step";
		}
	}
}
