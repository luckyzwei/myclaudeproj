using UnityEngine;

[CreateAssetMenu(fileName = "HiroConnectionSettings", menuName = "Kwalee/KWNakama/HiroConnectionSettings")]
public class HiroConnectionScriptable : ScriptableObject
{
	public string scheme;

	public int port;

	public string serverKey;

	public string host;
}
