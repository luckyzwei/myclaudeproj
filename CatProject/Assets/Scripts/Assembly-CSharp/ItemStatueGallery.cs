using UnityEngine;
using UnityEngine.UI;

public class ItemStatueGallery : MonoBehaviour
{
	[SerializeField]
	private Image StatueImg;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private GameObject LightObj;

	private int StatueIdx;

	private void Awake()
	{
		if (InfoBtn != null)
			InfoBtn.onClick.AddListener(OnClickInfo);
	}

	public void Set(int statue_idx)
	{
		StatueIdx = statue_idx;
		if (LightObj != null)
			LightObj.SetActive(statue_idx > 0);
	}

	private void OnClickInfo()
	{
	}
}
