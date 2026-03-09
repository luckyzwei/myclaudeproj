using Balancy.Models.LevelDataManager;
using KWCore.Utils;

public class LevelManager : MonoSingleton<LevelManager>
{
	protected override void Init()
	{
	}

	public Level GetCurrentLevel()
	{
		// Return current level from Balancy data manager
		var allLevels = GetAllLevels();
		if (allLevels == null || allLevels.Length == 0) return null;
		return allLevels[0];
	}

	public virtual Level GetLevel(int level)
	{
		var allLevels = GetAllLevels();
		if (allLevels == null || allLevels.Length == 0) return null;
		int idx = WrapIndex(level, allLevels.Length);
		return allLevels[idx];
	}

	protected virtual int WrapIndex(int desiredIndex, int loopLastX)
	{
		if (loopLastX <= 0) return 0;
		if (desiredIndex < 0) return 0;
		if (desiredIndex >= loopLastX)
			return desiredIndex % loopLastX;
		return desiredIndex;
	}

	public virtual Level[] GetAllLevels()
	{
		return null;
	}

	public virtual int GetNumLevels()
	{
		var allLevels = GetAllLevels();
		return allLevels != null ? allLevels.Length : 0;
	}
}
