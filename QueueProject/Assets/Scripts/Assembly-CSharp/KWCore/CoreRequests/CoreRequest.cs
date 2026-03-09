using System;
using System.Collections;
using System.Collections.Generic;

namespace KWCore.CoreRequests
{
	[Serializable]
	public class CoreRequest
	{
		public readonly RequestMethod method;

		public readonly string endpoint;

		public readonly string postData;

		public readonly List<CoreRequestHeader> requestHeaders;

		public readonly bool shouldCacheRequests;

		public readonly Hashtable authPayload;

		[NonSerialized]
		public readonly Action<string> successCallback;

		[NonSerialized]
		public readonly Action<long, string> errorCallback;

		public string uri { get; private set; }

		public CoreRequest(RequestMethod method, string endpoint, string uri, string postData, Hashtable authPayload, List<CoreRequestHeader> requestHeaders, Action<string> successCallback = null, Action<long, string> errorCallback = null, bool shouldCacheRequests = false)
		{
		}

		public void SetUri(string uri)
		{
		}

		public string GetAuthURLPrefix()
		{
			return null;
		}
	}
}
