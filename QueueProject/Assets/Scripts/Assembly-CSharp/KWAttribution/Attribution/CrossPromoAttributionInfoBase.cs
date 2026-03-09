using System.Collections.Generic;

namespace KWAttribution.Attribution
{
	public abstract class CrossPromoAttributionInfoBase
	{
		public string AppId { get; protected set; }

		public string Campaign { get; protected set; }

		public Dictionary<string, string> Params { get; protected set; }

		protected CrossPromoAttributionInfoBase(string appId, string campaign)
		{
		}
	}
}
