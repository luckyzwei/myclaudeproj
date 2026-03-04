using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace WebSocketSharp.Net
{
	public class ClientSslConfiguration
	{
		private bool _checkCertRevocation;

		private LocalCertificateSelectionCallback _clientCertSelectionCallback;

		private X509CertificateCollection _clientCerts;

		private SslProtocols _enabledSslProtocols;

		private RemoteCertificateValidationCallback _serverCertValidationCallback;

		private string _targetHost;

		public bool CheckCertificateRevocation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public X509CertificateCollection ClientCertificates
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalCertificateSelectionCallback ClientCertificateSelectionCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SslProtocols EnabledSslProtocols
		{
			get
			{
				return default(SslProtocols);
			}
			set
			{
			}
		}

		public RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TargetHost
		{
		get { return _targetHost; }
		set { _targetHost = value; }
	}

		public ClientSslConfiguration(string targetHost)
	{
		_targetHost = targetHost;
	}

		public ClientSslConfiguration(ClientSslConfiguration configuration)
		{
		}

		private static X509Certificate defaultSelectClientCertificate(object sender, string targetHost, X509CertificateCollection clientCertificates, X509Certificate serverCertificate, string[] acceptableIssuers)
		{
			return null;
		}

		private static bool defaultValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return false;
		}
	}
}
