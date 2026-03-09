using UnityEngine;

namespace KWGameplay
{
	public static class CameraExt
	{
		private static Plane[] camPlanes;

		private static Vector3 camPos;

		private static Vector3 camForward;

		private static float fov;

		private static float screenW;

		private static float screenH;

		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return false;
		}

		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return false;
		}
	}
}
