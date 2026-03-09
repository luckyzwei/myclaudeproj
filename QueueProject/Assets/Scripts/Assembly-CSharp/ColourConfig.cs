using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColourConfig", menuName = "ScriptableObjects/ColourConfig", order = 1)]
public class ColourConfig : ScriptableObject
{
	public List<Color> colors;

	public List<Sprite> queenColors;

	public Sprite overlayTexture;
}
