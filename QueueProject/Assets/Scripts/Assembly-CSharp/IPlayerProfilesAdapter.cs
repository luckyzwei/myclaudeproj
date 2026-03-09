using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IPlayerProfilesAdapter
{
	Task GetPublicProfile(Action<PublicProfile> callback);

	Task GetPublicProfile(string playerId, Action<PublicProfile> callback);

	Task GetPublicProfiles(string[] playerIds, Action<List<PublicProfile>> callback);

	Task UpdatePublicProfile(PublicProfile profile, Action<PublicProfile> callback);
}
