using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class PlayerPopupSchema : OpenSchema
	{
		private const string EVENT_NAME = "player_popup";

		public PlayerPopupSchema()
		{
		}

		public PlayerPopupSchema(string popupType)
		{
		}

		public void SetCloseType(string closeType)
		{
		}

		public bool HasSetCloseType()
		{
			return false;
		}

		public void SetValue(int val)
		{
		}

		public void SetAppActionID(string id)
		{
		}

		public void SetPopupType(string popupType)
		{
		}

		protected override string GetUniqueKeyForJoin()
		{
			return null;
		}
	}
}
