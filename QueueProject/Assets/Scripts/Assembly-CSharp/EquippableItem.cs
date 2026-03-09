using UnityEngine;

public class EquippableItem : MonoBehaviour
{
	[SerializeField]
	private string[] m_clientIDs;

	public string[] ClientIDs => null;

	public bool HasClientID(string clientID)
	{
		return false;
	}

	public void ItemEquipped(string clientID)
	{
	}
}
