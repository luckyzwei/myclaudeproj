using Balancy.Models.SmartObjects;
using KWCore.Utils;

public class PlayerProfileManager : Singleton<PlayerProfileManager>
{
	private const string NOTIFICATION_WIDGET_ID = "PlayerProfile";

	private PublicProfile m_currentPlayer;

	protected override void Init()
	{
	}

	private void OnItemWasAdded(Item item, int count, int slotindex)
	{
	}
}
