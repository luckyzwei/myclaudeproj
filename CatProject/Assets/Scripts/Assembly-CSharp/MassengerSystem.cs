using System.Collections.Generic;
using Treeplla;

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
		ChatGroups = new Dictionary<int, int>();
		OpenTypeCache = new Dictionary<int, List<int>>();
		TutoChatIdx = new List<int>();
		chat_delaytime = 0.5f;

		// 유저 데이터에서 채팅 진행 상태 로드
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.PhoneData == null || userData.PhoneData.ChatDatas == null) return;
		foreach (var kvp in userData.PhoneData.ChatDatas)
		{
			var chatData = kvp.Value;
			if (chatData != null)
			{
				ChatGroups[kvp.Key] = chatData.CurChatOrder;
			}
		}
	}

	public void CheckNewChat(int group)
	{
		// 특정 그룹의 새 채팅 확인
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.PhoneData == null || userData.PhoneData.ChatDatas == null) return;
		if (!userData.PhoneData.ChatDatas.TryGetValue(group, out var chatData)) return;
		if (chatData == null) return;
		// 다음 대화가 있으면 새 채팅으로 표시
		chatData.isNew = true;
	}

	public void CheckNewChat(OpenType type)
	{
		// 특정 오픈 타입에 해당하는 그룹들의 채팅 확인
		int typeKey = (int)type;
		if (!OpenTypeCache.TryGetValue(typeKey, out var groupList)) return;
		if (groupList == null) return;
		for (int i = 0; i < groupList.Count; i++)
		{
			CheckNewChat(groupList[i]);
		}
	}

	public int GetEnablePassivityChatOrder(int group)
	{
		// 수동 타입 채팅의 현재 진행 가능한 순서 반환
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.PhoneData == null || userData.PhoneData.ChatDatas == null) return 0;
		if (!userData.PhoneData.ChatDatas.TryGetValue(group, out var chatData)) return 0;
		if (chatData == null) return 0;
		return chatData.CurChatOrder;
	}

	private void AddChat(int group, int order)
	{
		// 채팅 그룹에 새 대화 추가
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.PhoneData == null) return;
		if (userData.PhoneData.ChatDatas == null)
			userData.PhoneData.ChatDatas = new Dictionary<int, ChatData>();

		if (!userData.PhoneData.ChatDatas.TryGetValue(group, out var chatData))
		{
			chatData = new ChatData();
			chatData.Create();
			userData.PhoneData.ChatDatas[group] = chatData;
		}
		chatData.CurChatOrder = order;
		chatData.isNew = true;
		ChatGroups[group] = order;
	}

	public void CompleteChat(int group)
	{
		// 채팅 그룹 완료 처리
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.PhoneData == null || userData.PhoneData.ChatDatas == null) return;
		if (!userData.PhoneData.ChatDatas.TryGetValue(group, out var chatData)) return;
		if (chatData == null) return;
		if (chatData.CompleteChat == null)
			chatData.CompleteChat = new List<int>();
		if (!chatData.CompleteChat.Contains(chatData.CurChatOrder))
			chatData.CompleteChat.Add(chatData.CurChatOrder);
		chatData.isNew = false;

		// 같은 그룹 완료 시 다음 채팅 오픈 확인
		CheckNewChat(OpenType.CompleteChat_SameGroup);
	}

	public void SetNextChat(int group, int chat, int completechat = -1)
	{
		// 다음 채팅 설정
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.PhoneData == null || userData.PhoneData.ChatDatas == null) return;
		if (!userData.PhoneData.ChatDatas.TryGetValue(group, out var chatData)) return;
		if (chatData == null) return;

		if (completechat >= 0)
		{
			if (chatData.CompleteChat == null)
				chatData.CompleteChat = new List<int>();
			if (!chatData.CompleteChat.Contains(completechat))
				chatData.CompleteChat.Add(completechat);
		}

		chatData.CurChat = chat;
		chatData.isNew = true;
		ChatGroups[group] = chat;
	}
}
