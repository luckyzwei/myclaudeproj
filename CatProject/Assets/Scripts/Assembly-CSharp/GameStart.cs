using Treeplla;
using UnityEngine;

public class GameStart : MonoBehaviour
{
	[SerializeField]
	private GameObject GameRootPrefab;

	private void Start()
	{
		// Remove AudioListener from this scene to avoid duplicates
		var listener = GetComponent<AudioListener>();
		if (listener != null)
			Destroy(listener);

		if (GameRootPrefab != null)
		{
			Instantiate(GameRootPrefab);
		}
		else
		{
			// Prefab not assigned - create GameRoot programmatically
			var existing = FindObjectOfType<GameRoot>();
			if (existing == null)
			{
				var go = new GameObject("GameRoot");
				go.AddComponent<GameRoot>();
				DontDestroyOnLoad(go);
			}
		}
		GameRoot.Load();

		// Hide Main scene objects (Camera, Logo) so the InGameOffice scene is visible
		var mainCam = GetComponentInParent<Transform>().root;
		foreach (var go in gameObject.scene.GetRootGameObjects())
		{
			if (go != gameObject)
				go.SetActive(false);
		}
		// Hide self too (Start object has no purpose after init)
		gameObject.SetActive(false);
	}
}
