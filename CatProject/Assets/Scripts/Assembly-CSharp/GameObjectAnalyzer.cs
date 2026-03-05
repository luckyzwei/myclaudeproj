using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Profiling;

public class GameObjectAnalyzer : MonoBehaviour
{
	[Serializable]
	public class ComponentInfo
	{
		public string ComponentName;

		public int InstanceCount;

		public List<string> GameObjectPaths;
	}

	[Serializable]
	public class MemorySnapshot
	{
		public long TotalReservedMemory;

		public long TotalAllocatedMemory;

		public Dictionary<string, long> DetailedMemory;
	}

	public static string GenerateSceneReport(GameObjectAnalyzerOrderBy componentStatGameObjectAnalyzerOrderBy = GameObjectAnalyzerOrderBy.InstanceCount)
	{
		var sb = new StringBuilder();
		var componentStats = new Dictionary<string, ComponentInfo>();
		var rootObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
		sb.AppendLine("=== Scene Report ===");
		for (int i = 0; i < rootObjects.Length; i++)
		{
			ProcessGameObject(rootObjects[i], 0, sb, componentStats);
		}
		sb.AppendLine("\n=== Component Statistics ===");
		foreach (var kvp in componentStats)
		{
			sb.AppendLine($"{kvp.Value.ComponentName}: {kvp.Value.InstanceCount} instances");
		}
		var mem = CaptureMemorySnapshot();
		if (mem != null)
		{
			sb.AppendLine($"\n=== Memory ===");
			sb.AppendLine($"Reserved: {FormatMemorySize(mem.TotalReservedMemory)}");
			sb.AppendLine($"Allocated: {FormatMemorySize(mem.TotalAllocatedMemory)}");
		}
		return sb.ToString();
	}

	private static void ProcessGameObject(GameObject go, int depth, StringBuilder sb, Dictionary<string, ComponentInfo> componentStats)
	{
		if (go == null) return;
		sb.Append(new string(' ', depth * 2));
		sb.AppendLine(go.name);
		var components = go.GetComponents<Component>();
		for (int i = 0; i < components.Length; i++)
		{
			if (components[i] == null) continue;
			string typeName = components[i].GetType().Name;
			if (!componentStats.TryGetValue(typeName, out var info))
			{
				info = new ComponentInfo
				{
					ComponentName = typeName,
					InstanceCount = 0,
					GameObjectPaths = new List<string>()
				};
				componentStats[typeName] = info;
			}
			info.InstanceCount++;
			info.GameObjectPaths.Add(GetGameObjectPath(go));
		}
		for (int i = 0; i < go.transform.childCount; i++)
		{
			ProcessGameObject(go.transform.GetChild(i).gameObject, depth + 1, sb, componentStats);
		}
	}

	private static string GetGameObjectPath(GameObject go)
	{
		if (go == null) return string.Empty;
		string path = go.name;
		var parent = go.transform.parent;
		while (parent != null)
		{
			path = parent.name + "/" + path;
			parent = parent.parent;
		}
		return path;
	}

	private static MemorySnapshot CaptureMemorySnapshot()
	{
		var snapshot = new MemorySnapshot
		{
			TotalReservedMemory = Profiler.GetTotalReservedMemoryLong(),
			TotalAllocatedMemory = Profiler.GetTotalAllocatedMemoryLong(),
			DetailedMemory = new Dictionary<string, long>()
		};
		return snapshot;
	}

	private static string FormatMemorySize(long bytes)
	{
		if (bytes >= 1073741824L)
			return $"{bytes / 1073741824.0:F2} GB";
		if (bytes >= 1048576L)
			return $"{bytes / 1048576.0:F2} MB";
		if (bytes >= 1024L)
			return $"{bytes / 1024.0:F2} KB";
		return $"{bytes} B";
	}

	public static List<T> FindComponentsOfType<T>() where T : Component
	{
		var results = new List<T>();
		var objects = Resources.FindObjectsOfTypeAll<T>();
		if (objects != null)
			results.AddRange(objects);
		return results;
	}

	public static string AnalyzeHighMemoryComponents()
	{
		var sb = new StringBuilder();
		sb.AppendLine("=== High Memory Components ===");
		var textures = Resources.FindObjectsOfTypeAll<Texture2D>();
		long totalTextureMemory = 0;
		for (int i = 0; i < textures.Length; i++)
		{
			if (textures[i] != null)
				totalTextureMemory += Profiler.GetRuntimeMemorySizeLong(textures[i]);
		}
		sb.AppendLine($"Textures: {textures.Length} ({FormatMemorySize(totalTextureMemory)})");
		var meshes = Resources.FindObjectsOfTypeAll<Mesh>();
		long totalMeshMemory = 0;
		for (int i = 0; i < meshes.Length; i++)
		{
			if (meshes[i] != null)
				totalMeshMemory += Profiler.GetRuntimeMemorySizeLong(meshes[i]);
		}
		sb.AppendLine($"Meshes: {meshes.Length} ({FormatMemorySize(totalMeshMemory)})");
		return sb.ToString();
	}
}
