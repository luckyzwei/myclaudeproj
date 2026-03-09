using System;
using System.Collections.Generic;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public abstract class OpenSchema : BaseSchema
	{
		private static Dictionary<string, string> s_jointKeys;

		public void SetAsNewInstance()
		{
		}

		protected virtual bool RequiresJoinKey()
		{
			return false;
		}

		protected override void ApplySpecialParams()
		{
		}

		protected abstract string GetUniqueKeyForJoin();
	}
}
