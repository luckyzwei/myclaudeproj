using UnityEngine;
using UnityEngine.UI;

public class ItemRichPoint : MonoBehaviour
{
	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text Point;

	public void SetHouse(int idx)
	{
		if (Name != null) Name.text = idx.ToString();
		if (Point != null) Point.text = "0";
	}

	public void SetCar(int idx)
	{
		if (Name != null) Name.text = idx.ToString();
		if (Point != null) Point.text = "0";
	}
}
