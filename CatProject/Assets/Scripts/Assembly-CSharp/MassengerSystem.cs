using System.Collections.Generic;

public class MassengerSystem
{
	public enum OpenType
	{
		None = -1,
		CompanyContract = 1,
		CompleteChat_SameGroup = 2,
		MoveStage = 3,
		CompanyMaxLevel = 4,
		BuyCar = 5,
		CompleteChat_AllCheck = 6
	}

	public enum ChatType
	{
		Automatically = 1,
		Passivity = 2
	}

	public enum MessageType
	{
		None = -1,
		Select = 1,
		Reward = 2,
		GetReward = 3,
		UnlockCompany = 4,
		UnlockCompany_Car = 5
	}

	private Dictionary<int, int> ChatGroups;

	private Dictionary<int, List<int>> OpenTypeCache;

	public List<int> TutoChatIdx;

	public float chat_delaytime { get; private set; }

	public void Init()
	{
	}

	public void CheckNewChat(int group)
	{
	}

	public void CheckNewChat(OpenType type)
	{
	}

	public int GetEnablePassivityChatOrder(int group)
	{
		return 0;
	}

	private void AddChat(int group, int order)
	{
	}

	public void CompleteChat(int group)
	{
	}

	public void SetNextChat(int group, int chat, int completechat = -1)
	{
	}
}
