using System;
using System.Collections.Generic;

public class ChatData : IReadOnlyData, ICloneable
{
	public int CurChat;

	public int CurChatOrder;

	public List<int> CompleteChat;

	public bool isNew;

	public int NextGroupOrder;

	public List<int> WaitChatOrder;

	public void Create()
	{
	}

	public virtual object Clone()
	{
		ChatData clone = (ChatData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
