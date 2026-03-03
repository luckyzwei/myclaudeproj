using UnityEngine;

public class ItemFactoryProcessLine : MonoBehaviour
{
	[SerializeField]
	private ItemFactoryMaterial MainMat;

	[SerializeField]
	private GameObject FocusObj;

	public int ProductIdx { get; private set; }

	public void Set(int idx)
	{
	}

	public void ShowFocusObj(bool bShow)
	{
	}
}
