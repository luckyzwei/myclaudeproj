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
		ProductIdx = item;
		if (NeedCount != null) NeedCount.text = needcount.ToString();
	}

	public void SetMaterials(int product = -1)
	{
		if (MatItems == null) return;
		for (int i = 0; i < MatItems.Count; i++)
		{
			if (MatItems[i] != null)
				MatItems[i].gameObject.SetActive(false);
		}
	}

	public void SetRun(int product = -1)
	{
		if (RunObjs == null) return;
		for (int i = 0; i < RunObjs.Count; i++)
		{
			if (RunObjs[i] != null)
				RunObjs[i].SetActive(false);
		}
	}

	public void SetRootProduct(int[] products)
	{
		RootItems = new List<int>();
		if (products != null)
		{
			for (int i = 0; i < products.Length; i++)
				RootItems.Add(products[i]);
		}
	}
}
