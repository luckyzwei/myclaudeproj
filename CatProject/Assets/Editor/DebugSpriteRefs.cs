using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class DebugSpriteRefs
{
    [MenuItem("Tools/Debug Sprite Refs")]
    public static void Run()
    {
        // Load HUDTotal prefab WITHOUT instantiating (no Awake/Start)
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Arts/Prefabs/HUD/HUDTotal.prefab");
        if (prefab == null) { Debug.Log("[DebugSprite] HUDTotal.prefab not found"); return; }

        // Check SerializedObject of the prefab itself (before any scripts run)
        var prefabImages = prefab.GetComponentsInChildren<Image>(true);
        int prefabWithSprite = 0;
        for (int i = 0; i < prefabImages.Length; i++)
        {
            var so = new SerializedObject(prefabImages[i]);
            var sp = so.FindProperty("m_Sprite");
            if (sp != null && sp.objectReferenceValue != null) prefabWithSprite++;
        }
        Debug.Log($"[DebugSprite] Prefab (SerializedObject): {prefabImages.Length} Images, {prefabWithSprite} with sprite via SO");
        Debug.Log($"[DebugSprite] Prefab (direct): {prefabImages.Length} Images, {prefabImages.Length - System.Linq.Enumerable.Count(prefabImages, i => i.sprite == null)} with sprite");

        var images = prefab.GetComponentsInChildren<Image>(true);
        int total = images.Length;
        int withSprite = 0;
        int nullSprite = 0;

        for (int i = 0; i < Mathf.Min(images.Length, 10); i++)
        {
            var img = images[i];
            string spriteName = img.sprite != null ? img.sprite.name : "NULL";
            string texName = (img.sprite != null && img.sprite.texture != null) ? img.sprite.texture.name : "NULL";
            Debug.Log($"[DebugSprite] Image[{i}] '{img.gameObject.name}': sprite={spriteName}, tex={texName}");
        }

        for (int i = 0; i < images.Length; i++)
        {
            if (images[i].sprite != null) withSprite++;
            else nullSprite++;
        }
        Debug.Log($"[DebugSprite] Total Images: {total}, with sprite: {withSprite}, null: {nullSprite}");

        // Also check a known texture to see if it has sprite sub-assets
        string testTexPath = "Assets/Textures/Sprite/HUD_Frame_S0_R0.png";
        var subAssets = AssetDatabase.LoadAllAssetsAtPath(testTexPath);
        Debug.Log($"[DebugSprite] Sub-assets in {testTexPath}: {subAssets.Length}");
        foreach (var sub in subAssets)
        {
            Debug.Log($"  {sub.GetType().Name}: '{sub.name}' (instanceID={sub.GetInstanceID()})");
        }

        // Check what fileID Unity assigns to the sprite
        var tex = AssetDatabase.LoadAssetAtPath<Texture2D>(testTexPath);
        var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(testTexPath);
        Debug.Log($"[DebugSprite] Texture: {(tex != null ? tex.name : "NULL")}, Sprite: {(sprite != null ? sprite.name : "NULL")}");

        if (sprite != null)
        {
            AssetDatabase.TryGetGUIDAndLocalFileIdentifier(sprite, out string guid, out long localId);
            Debug.Log($"[DebugSprite] Sprite GUID={guid}, localFileID={localId}");
        }

        // Try manually loading sprite by GUID and assigning to an Image
        string testGuid = "11aea7e12be8f29f407a8da1b0fa8a50";
        string testPath = AssetDatabase.GUIDToAssetPath(testGuid);
        Debug.Log($"[DebugSprite] Test GUID->Path: {testPath}");
        var testSprite = AssetDatabase.LoadAssetAtPath<Sprite>(testPath);
        Debug.Log($"[DebugSprite] Direct load sprite: {(testSprite != null ? testSprite.name : "NULL")}");

        // Try with explicit sub-asset
        var allAtPath = AssetDatabase.LoadAllAssetsAtPath(testPath);
        foreach (var a in allAtPath)
        {
            if (a is Sprite s)
                Debug.Log($"[DebugSprite] Found Sprite in texture: '{s.name}' rect={s.rect}");
        }

        // Now check the FIRST Image in the prefab more carefully
        if (images.Length > 0)
        {
            var so = new SerializedObject(images[0]);
            var spriteProp = so.FindProperty("m_Sprite");
            if (spriteProp != null)
            {
                Debug.Log($"[DebugSprite] First Image SerializedProperty m_Sprite: objectRef={spriteProp.objectReferenceValue}, instanceID={spriteProp.objectReferenceInstanceIDValue}");
            }
        }
    }
}
