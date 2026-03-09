using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using KPFCore;
using UnityEngine;

public class ProfileBackgroundService : ServiceBase<ProfileBackgroundService>
{
	private ProfileBackgroundRepository m_profileBackgroundRepository;

	private List<ProfileBackgroundData> m_backgrounds;

	private List<int> m_backgroundIndice;

	private int m_isDistributedDay;

	private ProfileBackgroundConfig m_config;

	public static event Action OnProfileBackgroundsUpdated
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

	protected override void InitialiseLocal(IRepository dataRepository, IConfig config)
	{
	}

	public void GetProfileBackground(string backgroundUrl, Action<Sprite> callback)
	{
	}

	public List<ProfileBackgroundData> GetAll()
	{
		return null;
	}

	public ProfileBackgroundData GetRandom()
	{
		return null;
	}

	public ProfileBackgroundData GetProfileBackgroundDataByIndex(int index)
	{
		return null;
	}

	public ProfileBackgroundData GetProfileBackgroundDataByName(string name)
	{
		return null;
	}

	public ProfileBackgroundData GetDefaultProfileBackgroundData()
	{
		return null;
	}

	public int GetRandomIndex()
	{
		return 0;
	}

	private void RemoveUnreleasedOnesFromList()
	{
	}

	public void SetProfileBackgroundsForBots()
	{
	}

	private int GetBackgroundForRank(int rank, string name)
	{
		return 0;
	}

	public static void SendProfileBackgroundUpdatedEvent()
	{
	}
}
