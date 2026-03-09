using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KWServerShop/ProductContainer")]
public class ProductContainer : ScriptableObject
{
	public List<ProductData> productDatas;
}
