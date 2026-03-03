using UnityEngine;

namespace SuperBlur
{
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Effects/Super Blur", -1)]
	public class SuperBlur : SuperBlurBase
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
