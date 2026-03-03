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
	}

	private void UpdateLevel(int level)
	{
	}

	public void ShowPreview(bool value)
	{
	}

	public void OnClickOfficeItem()
	{
	}
}
