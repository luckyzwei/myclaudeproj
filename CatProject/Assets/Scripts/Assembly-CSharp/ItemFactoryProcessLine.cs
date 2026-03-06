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
		// Update display
	}

	public void ShowFocusObj(bool bShow)
	{
		// TODO
	}
}
