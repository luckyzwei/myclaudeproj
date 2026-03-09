using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Crosstales.Common.Util
{
	public abstract class NetworkHelper
	{
		protected const string FILE_PREFIX = "file://";

		protected const string CONTENT_PREFIX = "content://";

		public static bool isInternetAvailable => false;

		public static bool OpenURL(string url)
		{
			return false;
		}

		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return false;
		}

		public static string GetURLFromFile(string path)
		{
			return null;
		}

		public static string ValidateURL(string url, bool removeProtocol = false, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		public static bool isURL(string url)
		{
			return false;
		}

		public static bool isIPv4(string ip)
		{
			return false;
		}

		public static string GetIP(string host)
		{
			return null;
		}

		[Obsolete("Please use 'GetURLFromFile' instead.")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Obsolete("Please use 'ValidateURL' instead.")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Obsolete("Please use 'isURL' instead.")]
		public static bool isValidURL(string url)
		{
			return false;
		}

		private static void openURL(string url)
		{
		}
	}
}
