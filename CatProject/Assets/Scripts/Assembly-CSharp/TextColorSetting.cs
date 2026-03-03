using UnityEngine;

public class TextColorSetting : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string keyColor;

	private void Start()
	{
	}

	public string GetTextColorKey()
	{
		return null;
	}

	public void SetTextColorKey(string key)
	{
	}

	[ExecuteInEditMode]
	public void SetTextColor(Color color)
	{
	}
}
