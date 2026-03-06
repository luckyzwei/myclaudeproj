using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[AddComponentMenu("Util/Disable2DRaycast")]
public class Disable2DRaycast : MonoBehaviour
{
	[SerializeField]
	private List<Image> list_FindImg;

	[SerializeField]
	private List<Text> list_FindText;

	private void Start()
	{
		SetRaycastDisable();
	}

	public void SetRaycastDisable()
	{
		if (list_FindImg != null)
			for (int i = 0; i < list_FindImg.Count; i++)
				if (list_FindImg[i] != null) list_FindImg[i].raycastTarget = false;
		if (list_FindText != null)
			for (int i = 0; i < list_FindText.Count; i++)
				if (list_FindText[i] != null) list_FindText[i].raycastTarget = false;
	}

	public void UndoRaycast()
	{
		if (list_FindImg != null)
			for (int i = 0; i < list_FindImg.Count; i++)
				if (list_FindImg[i] != null) list_FindImg[i].raycastTarget = true;
		if (list_FindText != null)
			for (int i = 0; i < list_FindText.Count; i++)
				if (list_FindText[i] != null) list_FindText[i].raycastTarget = true;
	}

	public void RemoveComponent()
	{
		UndoRaycast();
		Destroy(this);
	}
}
