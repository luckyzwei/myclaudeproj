using System;
using UnityEngine;

namespace SpriteShadersUltimate.Demo
{
	[Serializable]
	public class Demo_TriggerEvent
	{
		[Header("Delay:")]
		public float delay;

		[Header("Change Fader:")]
		public ShaderFaderSSU fader;

		public bool faderState;

		public bool negateState;

		[Header("Snap Player:")]
		public bool snapPlayer;

		public bool isRelative;

		public Vector3 snapPosition;

		[Header("Hurt Player:")]
		public bool hurtPlayer;

		public Vector2 velocity;

		public void Play(Transform source)
		{
		}
	}
}
