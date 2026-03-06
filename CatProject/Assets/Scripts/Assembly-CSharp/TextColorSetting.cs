using UnityEngine;

public class TextColorSetting : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string keyColor;

	private void Start()
	{
		// Start initialization
	}

	public string GetTextColorKey()
	{
		return keyColor;
	}

	public void SetTextColorKey(string key)
	{
		keyColor = key;
	}

	[ExecuteInEditMode]
	public void SetTextColor(Color color)
	{
		var text = GetComponent<UnityEngine.UI.Text>();
		if (text != null)
			text.color = color;
	}
}
