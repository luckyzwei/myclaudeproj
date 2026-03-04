namespace WebSocketSharp.Net
{
	internal class HttpHeaderInfo
	{
		private string _headerName;

		private HttpHeaderType _headerType;

		internal bool IsMultiValueInRequest => false;

		internal bool IsMultiValueInResponse => false;

		public string HeaderName => null;

		public HttpHeaderType HeaderType => default(HttpHeaderType);

		public bool IsRequest => false;

		public bool IsResponse => false;

		internal HttpHeaderInfo(string headerName, HttpHeaderType headerType)
	{
		_headerName = headerName;
	}

		public bool IsMultiValue(bool response)
		{
			return false;
		}

		public bool IsRestricted(bool response)
		{
			return false;
		}
	}
}
