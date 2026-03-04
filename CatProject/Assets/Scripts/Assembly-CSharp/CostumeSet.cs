using UnityEngine;

public class CostumeSet : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string keyIdx;

	[HideInInspector]
	[SerializeField]
	private string keyGrade;

	public int CostumeKey { get { return 0; } }

	public int CostumeGrade { get { return 0; } }
}
