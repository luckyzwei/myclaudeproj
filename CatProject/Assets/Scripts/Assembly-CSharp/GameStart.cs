using Treeplla;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
	[SerializeField]
	private GameObject GameRootPrefab;

	private void Start()
	{
		Debug.Log("[GameStart] Start() begin");

		// Remove AudioListener from this scene to avoid duplicates
		var listener = GetComponent<AudioListener>();
		if (listener != null)
			Destroy(listener);

		// Create GameRoot
		var existing = FindObjectOfType<GameRoot>();
		if (existing == null)
		{
			if (GameRootPrefab != null)
			{
				var inst = Instantiate(GameRootPrefab);
				if (inst != null)
				{
					// Ensure it has GameRoot component
					if (inst.GetComponent<GameRoot>() == null)
						inst.AddComponent<GameRoot>();
					DontDestroyOnLoad(inst);
					Debug.Log("[GameStart] GameRoot instantiated from prefab");
				}
			}

			// Fallback: create from scratch if still no GameRoot
			if (FindObjectOfType<GameRoot>() == null)
			{
				var go = new GameObject("GameRoot");
				go.AddComponent<GameRoot>();
				DontDestroyOnLoad(go);
				Debug.Log("[GameStart] GameRoot created programmatically");
			}
		}
		GameRoot.Load();

		// Disable Main scene camera immediately so it doesn't render over InGameOffice
		var cam = GetComponentInParent<Camera>();
		if (cam == null)
		{
			// Find any camera in this scene
			foreach (var rootObj in gameObject.scene.GetRootGameObjects())
			{
				cam = rootObj.GetComponent<Camera>();
				if (cam != null) break;
				cam = rootObj.GetComponentInChildren<Camera>(true);
				if (cam != null) break;
			}
		}
		if (cam != null)
		{
			cam.enabled = false;
			Debug.Log("[GameStart] Disabled Main scene camera: " + cam.gameObject.name);
		}

		// Hide all Main scene root objects
		Scene mainScene = gameObject.scene;
		if (mainScene.IsValid())
		{
			var rootObjects = mainScene.GetRootGameObjects();
			Debug.Log("[GameStart] Hiding " + rootObjects.Length + " root objects in Main scene");
			for (int i = 0; i < rootObjects.Length; i++)
			{
				rootObjects[i].SetActive(false);
			}
		}

		Debug.Log("[GameStart] Start() complete");
	}
}
