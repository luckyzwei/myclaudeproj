using System;
using System.Collections.Generic;
using KPFCore;

namespace KWPlayerProfile
{
	public class PlayerProfilesRepository : IRepository
	{
		private readonly PlayerProfileConfig m_config;

		private IPlayerProfilesAdapter m_serverAdapter;

		private PlayerProfileCache m_profileCache;

		public PlayerProfilesRepository(IConfig defaultConfig)
		{
		}

		public void CreateServerAdapter<T>() where T : IPlayerProfilesAdapter, new()
		{
		}

		public PublicProfile GetPublicProfile(Action<PublicProfile> callback)
		{
			return null;
		}

		public PublicProfile GetPublicProfile(string playerId, Action<PublicProfile> callback)
		{
			return null;
		}

		public List<PublicProfile> GetPublicProfiles(Action<List<PublicProfile>> callback, params string[] playerIds)
		{
			return null;
		}

		public void UpdateDisplayName(string displayName, Action<PublicProfile> callback)
		{
		}

		public void UpdateAvatarUrl(string avatarUrl, Action<PublicProfile> callback)
		{
		}

		public void UpdateProfile(PublicProfile profile, Action<PublicProfile> callback)
		{
		}
	}
}
