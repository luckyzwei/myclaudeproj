using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SnapshotCamera : MonoBehaviour
{
	private struct GameObjectStateSnapshot
	{
		private GameObject gameObject;

		private Vector3 position;

		private Quaternion rotation;

		private Vector3 scale;

		private bool acitve;

		private Dictionary<GameObject, int> layers;

		public GameObjectStateSnapshot(GameObject gameObject)
		{
			this.gameObject = null;
			position = default(Vector3);
			rotation = default(Quaternion);
			scale = default(Vector3);
			acitve = false;
			layers = null;
		}

		public void Restore()
		{
		}
	}

	private Camera cam;

	private int layer;

	public Vector3 defaultPositionOffset;

	public Vector3 defaultRotation;

	public Vector3 defaultScale;

	public void SetCameraSize(float size)
	{
	}

	private SnapshotCamera()
	{
	}

	public static SnapshotCamera MakeSnapshotCamera(string layer, string name = "Snapshot Camera")
	{
		return null;
	}

	public static SnapshotCamera MakeSnapshotCamera(int layer = 5, string name = "Snapshot Camera")
	{
		return null;
	}

	private static string SanitizeFilename(string dirty)
	{
		return null;
	}

	public static FileInfo SavePNG(byte[] bytes, string filename = "", string directory = "")
	{
		return null;
	}

	public static FileInfo SavePNG(Texture2D tex, string filename = "", string directory = "")
	{
		return null;
	}

	private void SetLayersRecursively(GameObject gameObject)
	{
	}

	private GameObjectStateSnapshot PrepareObject(GameObject gameObject, Vector3 positionOffset, Quaternion rotation, Vector3 scale)
	{
		return default(GameObjectStateSnapshot);
	}

	private GameObject PreparePrefab(GameObject prefab, Vector3 positionOffset, Quaternion rotation, Vector3 scale)
	{
		return null;
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, int width = 128, int height = 128, Texture2D texture = null)
	{
		return null;
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, int width = 128, int height = 128, Vector3 scale = default(Vector3), Texture2D texture = null)
	{
		return null;
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, Color backgroundColor, int width = 128, int height = 128)
	{
		return null;
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, Vector3 positionOffset, Quaternion rotation, Vector3 scale, int width = 128, int height = 128)
	{
		return null;
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, Color backgroundColor, Vector3 positionOffset, Quaternion rotation, Vector3 scale, int width = 128, int height = 128, Texture2D texture = null)
	{
		return null;
	}

	public Texture2D TakePrefabSnapshot(GameObject prefab, int width = 128, int height = 128)
	{
		return null;
	}

	public Texture2D TakePrefabSnapshot(GameObject prefab, Color backgroundColor, int width = 128, int height = 128)
	{
		return null;
	}

	public Texture2D TakePrefabSnapshot(GameObject prefab, Vector3 positionOffset, Quaternion rotation, Vector3 scale, int width = 128, int height = 128)
	{
		return null;
	}

	public Texture2D TakePrefabSnapshot(GameObject prefab, Color backgroundColor, Vector3 positionOffset, Quaternion rotation, Vector3 scale, int width = 128, int height = 128)
	{
		return null;
	}

	private Texture2D TakeSnapshot(Color backgroundColor, int width, int height, Texture2D texture)
	{
		return null;
	}
}
