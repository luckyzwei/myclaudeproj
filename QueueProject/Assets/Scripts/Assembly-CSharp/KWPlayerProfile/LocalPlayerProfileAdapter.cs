using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KWPlayerProfile
{
	public class LocalPlayerProfileAdapter : IPlayerProfilesAdapter
	{
		public Task GetPublicProfile(Action<PublicProfile> callback)
		{
			return null;
		}

		public Task GetPublicProfile(string playerId, Action<PublicProfile> callback)
		{
			return null;
		}

		public Task GetPublicProfiles(string[] playerIds, Action<List<PublicProfile>> callback)
		{
			return null;
		}

		public Task UpdatePublicProfile(PublicProfile profile, Action<PublicProfile> callback)
		{
			return null;
		}
	}
}
