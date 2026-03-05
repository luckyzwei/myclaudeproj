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
		string spriteName = gameObject.name;
		var sprite = GetSprite(spriteName);
		if (sprite == null) return;
		if (targetSp != null)
		{
			for (int i = 0; i < targetSp.Count; i++)
			{
				if (targetSp[i] != null)
					targetSp[i].sprite = sprite;
			}
		}
		if (targetImg != null)
		{
			for (int i = 0; i < targetImg.Count; i++)
			{
				if (targetImg[i] != null)
					targetImg[i].sprite = sprite;
			}
		}
	}

	private Sprite GetSprite(string key)
	{
		// Load sprite from atlas based on atlasType and key
		return null;
	}
}
