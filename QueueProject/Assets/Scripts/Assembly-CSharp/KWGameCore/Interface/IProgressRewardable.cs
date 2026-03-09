namespace KWGameCore.Interface
{
	public interface IProgressRewardable
	{
		bool HasUnlockedAllProgressRewardItems();

		InventoryItemData GetNextProgressRewardUnlock();

		void UnlockItemWithClientId(string clientID, bool equip);

		void SkipItemWithClientId(string clientID);

		int GetCurrentOrderedUnlockIndex();
	}
}
