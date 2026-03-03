using UnityEngine;

namespace SuperBlur
{
	[ExecuteInEditMode]
	public class SuperBlurBase : MonoBehaviour
	{
		protected static class Uniforms
		{
			public static readonly int _Radius;

			public static readonly int _BackgroundTexture;
		}

		public RenderMode renderMode;

		public BlurKernelSize kernelSize;

		[Range(0f, 1f)]
		public float interpolation;

		[Range(0f, 4f)]
		public int downsample;

		[Range(1f, 8f)]
		public int iterations;

		public bool gammaCorrection;

		public Material blurMaterial;

		public Material UIMaterial;

		protected void Blur(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
