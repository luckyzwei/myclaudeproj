using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemFactoryMaterial : MonoBehaviour
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Image LockIcon;

	[SerializeField]
	private Text NeedCount;

	[SerializeField]
	private Text ProductCountPerHour;

	[SerializeField]
	private List<GameObject> RunObjs;

	[SerializeField]
	private List<ItemFactoryMaterial> MatItems;

	private int ProductIdx;

	private bool isOpen;

	private List<int> RootItems;

	public void Set(int item, int needcount)
	{
	}

	public void SetMaterials(int product = -1)
	{
	}

	public void SetRun(int product = -1)
	{
	}

	public void SetRootProduct(int[] products)
	{
	}
}
