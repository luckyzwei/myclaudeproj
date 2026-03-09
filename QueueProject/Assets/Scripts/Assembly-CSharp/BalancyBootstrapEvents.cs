using System;
using System.Runtime.CompilerServices;
using Balancy;

public class BalancyBootstrapEvents
{
	public static event Action EverythingLoaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action DocumentsLoaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action ProfileWasReset
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action ProfileDataLoaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<BalancyInitStatus> LoadingInternalStatus
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void SendEverythingLoadedEvent()
	{
	}

	public static void SendDocumentsLoadedEvent()
	{
	}

	public static void SendProfileWasResetEvent()
	{
	}

	public static void SendProfileDataLoadedEvent()
	{
	}

	public static void SendLoadingInternalStatusEvent(BalancyInitStatus status)
	{
	}
}
