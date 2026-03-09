using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using KPFCore;

namespace KWPlayerProfile
{
	public class PlayerProfileService : ServiceBase<PlayerProfileService>
	{
		private const string DEFAULT_NAME_KEY = "PlayerProfile.DefaultPlayerName";

		private PlayerProfilesRepository m_playerProfilesRepository;

		private PlayerProfileConfig m_config;

		public static event Action<PublicProfile> OnProfileUpdated
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

		public static event Action<List<PublicProfile>> OnProfilesUpdated
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

		protected override void InitialiseLocal(IRepository dataRepository, IConfig config = null)
		{
		}

		public PublicProfile GetPublicProfile()
		{
			return null;
		}

		public PublicProfile GetPublicProfile(string playerId)
		{
			return null;
		}

		public void UpdateDisplayName(string name)
		{
		}

		public void UpdateAvatarUrl(string avatarUrl)
		{
		}

		public string GetName()
		{
			return null;
		}

		public List<PublicProfile> GetPublicProfiles(params string[] playerIds)
		{
			return null;
		}

		public bool IsPlayer(string playerId)
		{
			return false;
		}

		public int GetUsernameMaxLength()
		{
			return 0;
		}

		public void UpdateProfile(PublicProfile profile)
		{
		}
	}
}
