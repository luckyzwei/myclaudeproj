using UnityEngine;
using UnityEditor;
using System.IO;

/// <summary>
/// Force reimport all sprite textures so Unity generates sprite sub-assets.
/// Run via: Unity -batchmode -executeMethod ForceReimportSprites.Run
/// Or menu: Tools > Force Reimport Sprites
/// </summary>
public class ForceReimportSprites
{
    [MenuItem("Tools/Force Reimport Sprites")]
    public static void Run()
    {
        string[] textureFolders = new[]
        {
            "Assets/Textures/Sprite",
            "Assets/Textures/UI",
            "Assets/Textures",
        };

        int count = 0;
        int total = 0;

        foreach (var folder in textureFolders)
        {
            if (!Directory.Exists(folder)) continue;
            string[] files = Directory.GetFiles(folder, "*.png", SearchOption.AllDirectories);
            total += files.Length;

            foreach (var file in files)
            {
                string assetPath = file.Replace('\\', '/');
                var importer = AssetImporter.GetAtPath(assetPath) as TextureImporter;
                if (importer != null && importer.textureType == TextureImporterType.Sprite)
                {
                    // Force reimport to generate sprite sub-assets
                    AssetDatabase.ImportAsset(assetPath, ImportAssetOptions.ForceUpdate);
                    count++;
                    if (count % 500 == 0)
                        Debug.Log($"[ReimportSprites] {count}/{total} textures reimported...");
                }
            }
        }

        AssetDatabase.Refresh();
        Debug.Log($"[ReimportSprites] Done! Reimported {count} sprite textures out of {total} total.");
    }
}
