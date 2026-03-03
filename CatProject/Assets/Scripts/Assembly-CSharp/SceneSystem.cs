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
	}

	public void AddScene(GameType type, Action callback = null)
	{
	}

	public void UnLoadScene()
	{
	}

	public void UnLoadScene(GameType type, Action callback = null)
	{
	}

	public void UnLoadScene(Action callback = null)
	{
	}

	public int GetAddSceneCount()
	{
		return 0;
	}

	public SceneInstance GetLastOutScene()
	{
		return default(SceneInstance);
	}

	public bool IsUnloadingScene(GameType type)
	{
		return false;
	}
}
