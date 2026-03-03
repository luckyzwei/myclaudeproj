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
	}

	public void UpdateColor()
	{
	}

	public void SetImageColor(Color color)
	{
	}

	protected bool TrySetColorTo<T>(Color color)
	{
		return false;
	}
}
