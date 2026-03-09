using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Temporary diagnostic: logs what UI element the EventSystem hits on click.
/// Attach to any active GameObject in the scene.
/// </summary>
public class UIClickDiagnostic : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			// Check if pointer is over any UI
			bool overUI = EventSystem.current != null && EventSystem.current.IsPointerOverGameObject();

			// Raycast through all GraphicRaycasters to find what's hit
			var ped = new PointerEventData(EventSystem.current);
			ped.position = Input.mousePosition;
			var results = new List<RaycastResult>();
			EventSystem.current.RaycastAll(ped, results);

			string hitInfo = "";
			for (int i = 0; i < Mathf.Min(results.Count, 5); i++)
			{
				var r = results[i];
				string path = GetPath(r.gameObject.transform);
				hitInfo += $"\n  [{i}] {path} (depth={r.depth}, layer={r.gameObject.layer})";
			}

			if (results.Count == 0)
				hitInfo = "\n  (no UI hits)";

			Debug.Log($"[UIClickDiag] screen={Input.mousePosition}, overUI={overUI}, hits={results.Count}{hitInfo}");
		}
	}

	private string GetPath(Transform t)
	{
		string path = t.name;
		while (t.parent != null)
		{
			t = t.parent;
			path = t.name + "/" + path;
		}
		return path;
	}
}
