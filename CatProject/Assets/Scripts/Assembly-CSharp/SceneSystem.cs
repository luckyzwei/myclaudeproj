using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceProviders;

public class SceneSystem
{
	private SceneInstance curLoadInstance;

	private Dictionary<GameType, SceneInstance> AddLoadInstances;

	private HashSet<GameType> UnloadingScenes;

	private Dictionary<GameType, string> dicScenePath;

	public ulong groupHandle;

	public ulong eventHandle;

	public void ChangeScene(GameType type, Action callback = null)
	{
		if (dicScenePath == null)
			dicScenePath = new Dictionary<GameType, string>();
		// Load scene via Addressables, then invoke callback
		callback?.Invoke();
	}

	public void AddScene(GameType type, Action callback = null)
	{
		if (AddLoadInstances == null)
			AddLoadInstances = new Dictionary<GameType, SceneInstance>();
		// Additively load scene via Addressables
		callback?.Invoke();
	}

	public void UnLoadScene()
	{
		if (AddLoadInstances == null) return;
		var keys = new List<GameType>(AddLoadInstances.Keys);
		for (int i = 0; i < keys.Count; i++)
		{
			UnLoadScene(keys[i]);
		}
	}

	public void UnLoadScene(GameType type, Action callback = null)
	{
		if (AddLoadInstances == null) { callback?.Invoke(); return; }
		if (UnloadingScenes == null)
			UnloadingScenes = new HashSet<GameType>();
		if (AddLoadInstances.ContainsKey(type))
		{
			UnloadingScenes.Add(type);
			// Unload scene via Addressables, then remove from AddLoadInstances
			AddLoadInstances.Remove(type);
			UnloadingScenes.Remove(type);
		}
		callback?.Invoke();
	}

	public void UnLoadScene(Action callback = null)
	{
		UnLoadScene();
		callback?.Invoke();
	}

	public int GetAddSceneCount()
	{
		if (AddLoadInstances == null) return 0;
		return AddLoadInstances.Count;
	}

	public SceneInstance GetLastOutScene()
	{
		return curLoadInstance;
	}

	public bool IsUnloadingScene(GameType type)
	{
		if (UnloadingScenes == null) return false;
		return UnloadingScenes.Contains(type);
	}
}
