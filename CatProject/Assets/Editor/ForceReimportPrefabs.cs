using UnityEngine;
using UnityEditor;
using System.IO;

public class ForceReimportPrefabs
{
    [MenuItem("Tools/Force Reimport All Prefabs")]
    public static void Run()
    {
        string[] folders = { "Assets/Arts/Prefabs" };
        int count = 0;

        foreach (var folder in folders)
        {
            if (!Directory.Exists(folder)) continue;
            var files = Directory.GetFiles(folder, "*.prefab", SearchOption.AllDirectories);
            Debug.Log($"[ReimportPrefabs] Found {files.Length} prefabs in {folder}");

            foreach (var file in files)
            {
                string path = file.Replace('\\', '/');
                AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
                count++;
                if (count % 200 == 0)
                    Debug.Log($"[ReimportPrefabs] {count} prefabs reimported...");
            }
        }

        // Also reimport scene files
        var scenes = Directory.GetFiles("Assets/Scenes", "*.unity", SearchOption.AllDirectories);
        foreach (var scene in scenes)
        {
            AssetDatabase.ImportAsset(scene.Replace('\\', '/'), ImportAssetOptions.ForceUpdate);
        }

        AssetDatabase.Refresh();
        Debug.Log($"[ReimportPrefabs] Done! Reimported {count} prefabs + {scenes.Length} scenes.");
    }
}
