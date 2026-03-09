using System;
using System.Runtime.CompilerServices;
using Hiro;

public class NakamaEvents
{
	public static Action<NakamaSystemsInterface> NakamaConnected;

	public static Action<bool> NakamaConnectionStatusChanged;

	public static Action NakamaSessionRestored;

	public static event Action<long, string, long> StatValueChanged
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

	public static event Action<IEnergy> EnergyUpdated
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

	public static event Action SocialPlatformConnected
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

	public static event Action SocialPlatformDisconnected
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

	public static event Action<IEnergy, string> InfiniteEnergyStarted
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

	public static event Action<IEnergy, string> InfiniteEnergyEnded
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

	public static void SendNakamaConnected(NakamaSystemsInterface nakamaSystemsInterface)
	{
	}

	public static void SendNakamaNakamaConnectionStatusChanged(bool online)
	{
	}

	public static void SendNakamaSessionRestored()
	{
	}

	public static void SendStatValueChanged(long total, string statID = null, long awarded = 0L)
	{
	}

	public static void SendEnergyUpdated(IEnergy energy)
	{
	}

	public static void SendSocialPlatformConnected()
	{
	}

	public static void SendSocialPlatformDisconnected()
	{
	}

	public static void SendInfiniteEnergyStarted(IEnergy energy, string modifierOperator)
	{
	}

	public static void SendInfiniteEnergyEnded(IEnergy energy, string modifierOperator)
	{
	}
}
