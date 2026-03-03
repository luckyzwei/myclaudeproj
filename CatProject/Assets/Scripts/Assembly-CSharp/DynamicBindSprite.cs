using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicBindSprite : MonoBehaviour
{
	[SerializeField]
	private List<SpriteRenderer> targetSp;

	[SerializeField]
	private List<Image> targetImg;

	[SerializeField]
	private Config.AtlasType atlasType;

	private void Awake()
	{
	}

	private Sprite GetSprite(string key)
	{
		return null;
	}
}
