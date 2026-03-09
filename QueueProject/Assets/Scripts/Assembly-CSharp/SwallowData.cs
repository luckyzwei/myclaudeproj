using System;

[Serializable]
public struct SwallowData
{
	public string notificationId;

	public bool swallowAll;

	public SwallowData(string notificationId, bool swallowAll)
	{
		this.notificationId = null;
		this.swallowAll = false;
	}
}
