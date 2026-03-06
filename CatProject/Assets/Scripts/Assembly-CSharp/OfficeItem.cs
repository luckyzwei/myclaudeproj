using System.Collections.Generic;
using UnityEngine;

public class OfficeItem : MonoBehaviour
{
	[SerializeField]
	private List<SpriteRenderer> LevelObjs;

	[SerializeField]
	private List<GameObject> PreviewObjs;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject EmptyObj;

	private List<string> objSprFormats;

	private bool isShowEmptyObj;

	public int OfficeIdx { get; private set; }

	public int ItemType { get; private set; }

	public int ItemIdx { get; private set; }

	public virtual void Init(int office, int type, int idx)
	{
		OfficeIdx = office;
		ItemType = type;
		ItemIdx = idx;
		if (LockObj != null) LockObj.SetActive(false);
		if (EmptyObj != null) EmptyObj.SetActive(false);
	}

	private void UpdateLevel(int level)
	{
		if (LevelObjs == null) return;
		for (int i = 0; i < LevelObjs.Count; i++)
		{
			if (LevelObjs[i] != null)
				LevelObjs[i].gameObject.SetActive(i < level);
		}
	}

	public void ShowPreview(bool value)
	{
		if (PreviewObjs == null) return;
		for (int i = 0; i < PreviewObjs.Count; i++)
		{
			if (PreviewObjs[i] != null)
				PreviewObjs[i].SetActive(value);
		}
	}

	public void OnClickOfficeItem()
	{
		// Handle click
	}
}
