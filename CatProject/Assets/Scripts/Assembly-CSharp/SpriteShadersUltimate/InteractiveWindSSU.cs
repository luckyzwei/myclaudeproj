using System.Collections.Generic;
using UnityEngine;

namespace SpriteShadersUltimate
{
	public class InteractiveWindSSU : InstancerSSU
	{
		[Tooltip("How much physical interaction bends the sprite.")]
		public float rotationFactor;

		[Tooltip("How fast physical interaction bending fades in.")]
		public float bendInSpeed;

		[Tooltip("How fast physical interaction bending fades out.")]
		public float bendOutSpeed;

		[Tooltip("If disabled the sprite will only bend during active movement.")]
		public bool stayBent;

		[Tooltip("The minimum speed of the interacting object to trigger bending.")]
		public float minBendSpeed;

		[Tooltip("Swaps the material with the default sprite material while inactive.")]
		public bool hyperPerformanceMode;

		[Tooltip("Adds a tiny little offset to the Z position on start.\nTo prevent random resorting of render order.")]
		public bool randomOffsetZ;

		[Tooltip("Define a material to switch to while inactive.")]
		public bool customMaterial;

		[Tooltip("The shader used for the default sprite material.")]
		public string inactiveShader;

		[Tooltip("The material used when inactive.")]
		public Material inactiveMaterial;

		[Tooltip("Slightly changes 'Wiggle Frequency', to desync the wiggle shaders of multiple sprites.")]
		public bool randomizeWiggle;

		[Tooltip("The editor-side script set's the layer to 'Ignore Raycast' to fix potential issues. Enable this to disable that and set the layer to a different one.")]
		public bool allowCustomLayer;

		private HashSet<Collider2D> collidersInside;

		private BoxCollider2D boxCollider;

		private float currentBending;

		private float currentRotationDirection;

		private bool isActive;

		private bool newDirection;

		private float lastPosition;

		private float lastBend;

		private float currentBendTarget;

		private bool bentInLastFrame;

		private SpriteRenderer sr;

		private static Material defaultMaterial;

		private int rotationId;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		public void UpdateShader()
		{
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		private void OnTriggerExit2D(Collider2D collision)
		{
		}

		public static void DefaultCollider(BoxCollider2D box)
		{
		}
	}
}
