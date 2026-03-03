using System.Collections.Generic;
using UnityEngine;

namespace SpriteShadersUltimate.Demo
{
	public class Demo_Player : MonoBehaviour
	{
		public static Demo_Player instance;

		[Header("Sprites:")]
		public List<Sprite> idleSprites;

		public List<Sprite> runningSprites;

		public List<Sprite> hurtSprites;

		[Header("Other:")]
		public bool ignoreMaterials;

		private SpriteRenderer spriteRenderer;

		private Rigidbody2D rig;

		private float nextFrame;

		private int currentIndex;

		private List<Sprite> currentAnimation;

		private Material originalMaterial;

		private Material currentMaterial;

		private Vector3 snapPosition;

		private bool isShadow;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void GetHurt(Vector2 velocity)
		{
		}

		private void PlayAnimation(List<Sprite> animation)
		{
		}

		public void ApplyMaterial(Material material)
		{
		}

		public void SnapPosition(Vector3 newPosition)
		{
		}

		public void ResetPosition()
		{
		}

		public void ResetMaterial()
		{
		}
	}
}
