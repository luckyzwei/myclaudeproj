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
			this.gameObject = gameObject;
			position = gameObject != null ? gameObject.transform.position : Vector3.zero;
			rotation = gameObject != null ? gameObject.transform.rotation : Quaternion.identity;
			scale = gameObject != null ? gameObject.transform.localScale : Vector3.one;
			acitve = gameObject != null && gameObject.activeSelf;
			layers = new Dictionary<GameObject, int>();
			if (gameObject != null)
			{
				foreach (var t in gameObject.GetComponentsInChildren<Transform>(true))
				{
					layers[t.gameObject] = t.gameObject.layer;
				}
			}
		}

		public void Restore()
		{
			if (gameObject == null) return;
			gameObject.transform.position = position;
			gameObject.transform.rotation = rotation;
			gameObject.transform.localScale = scale;
			gameObject.SetActive(acitve);
			if (layers != null)
			{
				foreach (var kvp in layers)
				{
					if (kvp.Key != null)
						kvp.Key.layer = kvp.Value;
				}
			}
		}
	}

	private Camera cam;

	private int layer;

	public Vector3 defaultPositionOffset;

	public Vector3 defaultRotation;

	public Vector3 defaultScale;

	public void SetCameraSize(float size)
	{
		if (cam != null)
			cam.orthographicSize = size;
	}

	private SnapshotCamera()
	{
	}

	public static SnapshotCamera MakeSnapshotCamera(string layer, string name = "Snapshot Camera")
	{
		int layerIdx = LayerMask.NameToLayer(layer);
		if (layerIdx < 0) layerIdx = 5;
		return MakeSnapshotCamera(layerIdx, name);
	}

	public static SnapshotCamera MakeSnapshotCamera(int layer = 5, string name = "Snapshot Camera")
	{
		var go = new GameObject(name);
		var snapshot = go.AddComponent<SnapshotCamera>();
		snapshot.layer = layer;
		var cam = go.AddComponent<Camera>();
		cam.cullingMask = 1 << layer;
		cam.orthographic = true;
		cam.orthographicSize = 1f;
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = Color.clear;
		cam.nearClipPlane = 0.1f;
		cam.farClipPlane = 100f;
		cam.enabled = false;
		snapshot.cam = cam;
		snapshot.defaultScale = Vector3.one;
		snapshot.defaultRotation = Vector3.zero;
		snapshot.defaultPositionOffset = Vector3.zero;
		return snapshot;
	}

	private static string SanitizeFilename(string dirty)
	{
		if (string.IsNullOrEmpty(dirty)) return "snapshot";
		string clean = dirty;
		foreach (char c in Path.GetInvalidFileNameChars())
		{
			clean = clean.Replace(c, '_');
		}
		return clean;
	}

	public static FileInfo SavePNG(byte[] bytes, string filename = "", string directory = "")
	{
		if (bytes == null || bytes.Length == 0) return null;
		if (string.IsNullOrEmpty(filename)) filename = "snapshot";
		filename = SanitizeFilename(filename);
		if (string.IsNullOrEmpty(directory)) directory = Application.persistentDataPath;
		string path = Path.Combine(directory, filename + ".png");
		File.WriteAllBytes(path, bytes);
		return new FileInfo(path);
	}

	public static FileInfo SavePNG(Texture2D tex, string filename = "", string directory = "")
	{
		if (tex == null) return null;
		byte[] bytes = tex.EncodeToPNG();
		return SavePNG(bytes, filename, directory);
	}

	private void SetLayersRecursively(GameObject gameObject)
	{
		if (gameObject == null) return;
		gameObject.layer = layer;
		foreach (Transform child in gameObject.transform)
		{
			SetLayersRecursively(child.gameObject);
		}
	}

	private GameObjectStateSnapshot PrepareObject(GameObject gameObject, Vector3 positionOffset, Quaternion rotation, Vector3 scale)
	{
		var snapshot = new GameObjectStateSnapshot(gameObject);
		gameObject.transform.position = positionOffset;
		gameObject.transform.rotation = rotation;
		gameObject.transform.localScale = scale;
		gameObject.SetActive(true);
		SetLayersRecursively(gameObject);
		return snapshot;
	}

	private GameObject PreparePrefab(GameObject prefab, Vector3 positionOffset, Quaternion rotation, Vector3 scale)
	{
		if (prefab == null) return null;
		var instance = Instantiate(prefab, positionOffset, rotation);
		instance.transform.localScale = scale;
		SetLayersRecursively(instance);
		return instance;
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, int width = 128, int height = 128, Texture2D texture = null)
	{
		return TakeObjectSnapshot(gameObject, Color.clear, defaultPositionOffset, Quaternion.Euler(defaultRotation), defaultScale, width, height, texture);
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, int width = 128, int height = 128, Vector3 scale = default(Vector3), Texture2D texture = null)
	{
		if (scale == default(Vector3)) scale = defaultScale;
		return TakeObjectSnapshot(gameObject, Color.clear, defaultPositionOffset, Quaternion.Euler(defaultRotation), scale, width, height, texture);
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, Color backgroundColor, int width = 128, int height = 128)
	{
		return TakeObjectSnapshot(gameObject, backgroundColor, defaultPositionOffset, Quaternion.Euler(defaultRotation), defaultScale, width, height);
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, Vector3 positionOffset, Quaternion rotation, Vector3 scale, int width = 128, int height = 128)
	{
		return TakeObjectSnapshot(gameObject, Color.clear, positionOffset, rotation, scale, width, height);
	}

	public Texture2D TakeObjectSnapshot(GameObject gameObject, Color backgroundColor, Vector3 positionOffset, Quaternion rotation, Vector3 scale, int width = 128, int height = 128, Texture2D texture = null)
	{
		if (gameObject == null) return null;
		var snapshot = PrepareObject(gameObject, positionOffset, rotation, scale);
		cam.backgroundColor = backgroundColor;
		var result = TakeSnapshot(backgroundColor, width, height, texture);
		snapshot.Restore();
		return result;
	}

	public Texture2D TakePrefabSnapshot(GameObject prefab, int width = 128, int height = 128)
	{
		return TakePrefabSnapshot(prefab, Color.clear, defaultPositionOffset, Quaternion.Euler(defaultRotation), defaultScale, width, height);
	}

	public Texture2D TakePrefabSnapshot(GameObject prefab, Color backgroundColor, int width = 128, int height = 128)
	{
		return TakePrefabSnapshot(prefab, backgroundColor, defaultPositionOffset, Quaternion.Euler(defaultRotation), defaultScale, width, height);
	}

	public Texture2D TakePrefabSnapshot(GameObject prefab, Vector3 positionOffset, Quaternion rotation, Vector3 scale, int width = 128, int height = 128)
	{
		return TakePrefabSnapshot(prefab, Color.clear, positionOffset, rotation, scale, width, height);
	}

	public Texture2D TakePrefabSnapshot(GameObject prefab, Color backgroundColor, Vector3 positionOffset, Quaternion rotation, Vector3 scale, int width = 128, int height = 128)
	{
		if (prefab == null) return null;
		var instance = PreparePrefab(prefab, positionOffset, rotation, scale);
		cam.backgroundColor = backgroundColor;
		var result = TakeSnapshot(backgroundColor, width, height, null);
		if (instance != null)
			DestroyImmediate(instance);
		return result;
	}

	private Texture2D TakeSnapshot(Color backgroundColor, int width, int height, Texture2D texture)
	{
		if (cam == null) return null;
		var rt = new RenderTexture(width, height, 24);
		cam.targetTexture = rt;
		cam.backgroundColor = backgroundColor;
		cam.Render();
		RenderTexture.active = rt;
		if (texture == null)
			texture = new Texture2D(width, height, TextureFormat.RGBA32, false);
		texture.ReadPixels(new Rect(0, 0, width, height), 0, 0);
		texture.Apply();
		cam.targetTexture = null;
		RenderTexture.active = null;
		DestroyImmediate(rt);
		return texture;
	}
}
