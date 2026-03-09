using UnityEngine;

public class AnimatorStateAttribute : PropertyAttribute
{
	public readonly string animatorAssetOrField;

	public AnimatorStateAttribute()
	{
	}

	public AnimatorStateAttribute(string animatorAsset)
	{
	}
}
