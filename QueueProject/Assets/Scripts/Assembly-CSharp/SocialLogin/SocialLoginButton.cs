using Nakama;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SocialLogin
{
	public abstract class SocialLoginButton : MonoBehaviour
	{
		public UnityEvent<NakamaSocialLogin.ConnectionResult> ConnectionCallback;

		public UnityEvent<NakamaSocialLogin.ConnectionResult> DisconnectionCallback;

		[SerializeField]
		protected bool m_showAccountClash;

		[SerializeField]
		private Button m_button;

		[SerializeField]
		private GameObject m_connectVisual;

		[SerializeField]
		private GameObject m_disconnectVisual;

		[SerializeField]
		private string m_analyticsLocation;

		protected NakamaSocialLogin m_platform;

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void RefreshButton()
		{
		}

		private void ToggleVisuals(bool isAccountConnected)
		{
		}

		public void OnButtonPressed()
		{
		}

		private bool IsConnected()
		{
			return false;
		}

		protected void ConnectionResult(NakamaSocialLogin.ConnectionResult result)
		{
		}

		protected void DisconnectionResult(NakamaSocialLogin.ConnectionResult result)
		{
		}

		protected NakamaSocialLogin.HandleAccountClashDelegate GetClashDelegate()
		{
			return null;
		}

		private void ResolveAccountClash(NakamaSocialLogin.HandleAccountClashResultDelegate resultCallback)
		{
		}

		private void Connect()
		{
		}

		private void Disconnect()
		{
		}

		protected virtual void OnConnectionSuccess()
		{
		}

		protected virtual void OnConnectionFailure()
		{
		}

		protected virtual void OnDisconnectionSuccess()
		{
		}

		protected virtual void OnDisconnectionFailure()
		{
		}

		protected abstract NakamaSocialLogin CreateSocialLoginPlatform();

		protected abstract string GetConnectionId(IApiAccount account);
	}
}
