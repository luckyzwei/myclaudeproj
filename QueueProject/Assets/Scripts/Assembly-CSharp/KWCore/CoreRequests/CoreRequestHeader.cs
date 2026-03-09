using System;

namespace KWCore.CoreRequests
{
	[Serializable]
	public class CoreRequestHeader
	{
		public string requestHeaderType;

		public string requestValue;

		[NonSerialized]
		private string customHeader;

		public CoreRequestHeader(RequestHeader type, string value, string customHeader = "")
		{
		}

		private string GetRequestHeader(RequestHeader type)
		{
			return null;
		}
	}
}
