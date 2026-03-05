using System.Collections.Generic;
using UnityEngine;

public class ImageColorSetting : MonoBehaviour
{
	public enum ImageType
	{
		Unknown = 0,
		SpriteRenderer = 1,
		Image = 2,
		Renderer = 3
	}

	[SerializeField]
	protected ImageType currentImageType;

	[SerializeField]
	protected bool SetEventMode;

	[HideInInspector]
	[SerializeField]
	private string keyColor;

	[HideInInspector]
	[SerializeField]
	private List<string> eventKeyColor;

	[HideInInspector]
	[SerializeField]
	private int eventCount;

	private void Start()
	{
		UpdateColor();
	}

	public void UpdateColor()
	{
		if (string.IsNullOrEmpty(keyColor)) return;
		Color color;
		if (ColorUtility.TryParseHtmlString(keyColor, out color))
			SetImageColor(color);
	}

	public void SetImageColor(Color color)
	{
		TrySetColorTo<UnityEngine.UI.Image>(color);
		TrySetColorTo<SpriteRenderer>(color);
		TrySetColorTo<Renderer>(color);
	}

	protected bool TrySetColorTo<T>(Color color)
	{
		var comp = GetComponent<T>();
		if (comp == null) return false;
		if (comp is UnityEngine.UI.Image img)
			img.color = color;
		else if (comp is SpriteRenderer sr)
			sr.color = color;
		else if (comp is Renderer rd)
		{
			if (rd.material != null)
				rd.material.color = color;
		}
		else
			return false;
		return true;
	}
}
