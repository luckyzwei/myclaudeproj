using System;
using System.Runtime.InteropServices;

namespace Google.Impl
{
	internal class GoogleSignInImpl : BaseObject, ISignInImpl
	{
		private const string DllName = "native-googlesignin";

		internal GoogleSignInImpl(GoogleSignInConfiguration configuration)
			: base((IntPtr)0)
		{
		}

		public void EnableDebugLogging(bool flag)
		{
		}

		public Future<GoogleSignInUser> SignIn()
		{
			return null;
		}

		public Future<GoogleSignInUser> SignInSilently()
		{
			return null;
		}

		public void SignOut()
		{
		}

		public void Disconnect()
		{
		}

		[PreserveSig]
		private static extern IntPtr GoogleSignIn_Create(IntPtr data);

		[PreserveSig]
		private static extern void GoogleSignIn_EnableDebugLogging(HandleRef self, bool flag);

		[PreserveSig]
		private static extern bool GoogleSignIn_Configure(HandleRef self, bool useGameSignIn, string webClientId, bool requestAuthCode, bool forceTokenRefresh, bool requestEmail, bool requestIdToken, bool hidePopups, string[] additionalScopes, int scopeCount, string accountName);

		[PreserveSig]
		private static extern IntPtr GoogleSignIn_SignIn(HandleRef self);

		[PreserveSig]
		private static extern IntPtr GoogleSignIn_SignInSilently(HandleRef self);

		[PreserveSig]
		private static extern void GoogleSignIn_Signout(HandleRef self);

		[PreserveSig]
		private static extern void GoogleSignIn_Disconnect(HandleRef self);

		[PreserveSig]
		internal static extern void GoogleSignIn_DisposeFuture(HandleRef self);

		[PreserveSig]
		internal static extern bool GoogleSignIn_Pending(HandleRef self);

		[PreserveSig]
		internal static extern IntPtr GoogleSignIn_Result(HandleRef self);

		[PreserveSig]
		internal static extern int GoogleSignIn_Status(HandleRef self);

		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetServerAuthCode(HandleRef self, [In][Out] byte[] bytes, UIntPtr len);

		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetDisplayName(HandleRef self, [In][Out] byte[] bytes, UIntPtr len);

		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetEmail(HandleRef self, [In][Out] byte[] bytes, UIntPtr len);

		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetFamilyName(HandleRef self, [In][Out] byte[] bytes, UIntPtr len);

		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetGivenName(HandleRef self, [In][Out] byte[] bytes, UIntPtr len);

		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetIdToken(HandleRef self, [In][Out] byte[] bytes, UIntPtr len);

		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetImageUrl(HandleRef self, [In][Out] byte[] bytes, UIntPtr len);

		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetUserId(HandleRef self, [In][Out] byte[] bytes, UIntPtr len);

		private static IntPtr GetPlayerActivity()
		{
			return (IntPtr)0;
		}
	}
}
