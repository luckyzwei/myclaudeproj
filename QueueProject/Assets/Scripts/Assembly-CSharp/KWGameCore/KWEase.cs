using UnityEngine;

namespace KWGameCore
{
	public class KWEase
	{
		public enum Type
		{
			LINEAR = 0,
			IN_SINE = 1,
			OUT_SINE = 2,
			IN_OUT_SINE = 3,
			IN_BACK = 4,
			OUT_BACK = 5,
			IN_OUT_BACK = 6,
			IN_QUAD = 7,
			OUT_QUAD = 8,
			IN_OUT_QUAD = 9,
			IN_CUBIC = 10,
			OUT_CUBIC = 11,
			IN_OUT_CUBIC = 12,
			IN_QUART = 13,
			OUT_QUART = 14,
			IN_OUT_QUART = 15,
			IN_QUINT = 16,
			OUT_QUINT = 17,
			IN_OUT_QUINT = 18,
			IN_EXPO = 19,
			OUT_EXPO = 20,
			IN_OUT_EXPO = 21,
			IN_CIRC = 22,
			OUT_CIRC = 23,
			IN_OUT_CIRC = 24,
			IN_ELASTIC = 25,
			OUT_ELASTIC = 26,
			IN_OUT_ELASTIC = 27,
			IN_BOUNCE = 28,
			OUT_BOUNCE = 29,
			IN_OUT_BOUNCE = 30,
			NONE = 31
		}

		public delegate float EaseFunction(float value);

		private const float IN_BACK_C1 = 1.70158f;

		private const float IN_BACK_C3 = 2.70158f;

		private const float OUT_BACK_C1 = 1.70158f;

		private const float OUT_BACK_C3 = 2.70158f;

		private const float IN_OUT_BACK_C1 = 1.70158f;

		private const float IN_OUT_BACK_C2 = 2.5949094f;

		private const float OUT_BOUNCE_N1 = 7.5625f;

		private const float OUT_BOUNCE_D1 = 2.75f;

		public static EaseFunction GetEase(Type type)
		{
			return null;
		}

		public static EaseFunction GetEase(AnimationCurve curve)
		{
			return null;
		}

		public static float Linear(float x)
		{
			return 0f;
		}

		public static float EaseInSine(float x)
		{
			return 0f;
		}

		public static float EaseOutSine(float x)
		{
			return 0f;
		}

		public static float EaseInOutSine(float x)
		{
			return 0f;
		}

		public static float EaseInBack(float x)
		{
			return 0f;
		}

		public static float EaseOutBack(float x)
		{
			return 0f;
		}

		public static float EaseInOutBack(float x)
		{
			return 0f;
		}

		public static float EaseInQuad(float x)
		{
			return 0f;
		}

		public static float EaseOutQuad(float x)
		{
			return 0f;
		}

		public static float EaseInOutQuad(float x)
		{
			return 0f;
		}

		public static float EaseInCubic(float x)
		{
			return 0f;
		}

		public static float EaseOutCubic(float x)
		{
			return 0f;
		}

		public static float EaseInOutCubic(float x)
		{
			return 0f;
		}

		public static float EaseInQuart(float x)
		{
			return 0f;
		}

		public static float EaseOutQuart(float x)
		{
			return 0f;
		}

		public static float EaseInOutQuart(float x)
		{
			return 0f;
		}

		public static float EaseInQuint(float x)
		{
			return 0f;
		}

		public static float EaseOutQuint(float x)
		{
			return 0f;
		}

		public static float EaseInOutQuint(float x)
		{
			return 0f;
		}

		public static float EaseInExpo(float x)
		{
			return 0f;
		}

		public static float EaseOutExpo(float x)
		{
			return 0f;
		}

		public static float EaseInOutExpo(float x)
		{
			return 0f;
		}

		public static float EaseInCirc(float x)
		{
			return 0f;
		}

		public static float EaseOutCirc(float x)
		{
			return 0f;
		}

		public static float EaseInOutCirc(float x)
		{
			return 0f;
		}

		public static float EaseInElastic(float x)
		{
			return 0f;
		}

		public static float EaseOutElastic(float x)
		{
			return 0f;
		}

		public static float EaseInOutElastic(float x)
		{
			return 0f;
		}

		public static float EaseInBounce(float x)
		{
			return 0f;
		}

		public static float EaseOutBounce(float x)
		{
			return 0f;
		}

		public static float EaseInOutBounce(float x)
		{
			return 0f;
		}
	}
}
