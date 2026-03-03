using UnityEngine;

namespace SuperBlur
{
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Effects/Super Blur Fast", -1)]
	public class SuperBlurFast : SuperBlurBase
	{
		private Camera m_Camera;

		private RenderTexture rt;

		private void OnEnable()
		{
		}

		private void OnPreCull()
		{
		}

		private void OnPostRender()
		{
		}
	}
}
