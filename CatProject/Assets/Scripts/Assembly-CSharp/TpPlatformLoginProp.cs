using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppleAuth;
using Firebase.Auth;
using Google;

public class TpPlatformLoginProp
{
	public enum LoginPlatformType
	{
		None = 0,
		Google = 1,
		Facebook = 2,
		Apple = 3
	}

	private const string AppleUserIdKey = "AppleUserId";

	private const string LoginPlatformKey = "LoginPlatform";

	private const string GoogleTokenKey = "GoogleTokenKey";

	private const string AppleTokenKey = "AppleTokenKey";

	private const string webClientId = "226815887453-l7j1lr5la86j0hinriekegifvjh66pmb.apps.googleusercontent.com";

	private IAppleAuthManager _appleAuthManager;

	public static FirebaseUser fUser;

	private FirebaseAuth auth;

	private GoogleSignInConfiguration configuration;

	public static LoginState state;

	public string platformToken;

	private Queue<Action> _actionQueue;

	public bool IsLogin { get; private set; }

	public LoginPlatformType LoginPlatform { get; private set; }

	public void InitPlatformLogin()
	{
	}

	public void Update()
	{
	}

	public void Login(LoginPlatformType loginType, Action<FirebaseUser> firebaseUserCallback)
	{
	}

	private void SignInFirebase(LoginPlatformType loginType, Action<FirebaseUser> firebaseAuthCallback, params object[] args)
	{
	}

	private static void HandleSignInWithUser(Task<FirebaseUser> task, Action<FirebaseUser> firebaseUserCallback)
	{
	}

	public void Logout()
	{
	}

	private static string GenerateRandomString(int length)
	{
		return null;
	}

	private static string GenerateSHA256NonceFromRawNonce(string rawNonce)
	{
		return null;
	}

	public string GetToken()
	{
		return null;
	}
}
