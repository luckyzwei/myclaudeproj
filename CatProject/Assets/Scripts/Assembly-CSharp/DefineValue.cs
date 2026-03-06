using UnityEngine;

public class DefineValue : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string keyDefine;

	private void Start()
	{
		RefreshText();
	}

	public void RefreshText()
	{
	}

	public void SetText(string txt)
	{
		keyDefine = txt;
	}
}
