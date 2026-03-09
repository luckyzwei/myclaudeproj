using Balancy.Models.LevelDataManager;
using KWCore.Utils;

public class LevelManager : MonoSingleton<LevelManager>
{
	protected override void Init()
	{
	}

	public Level GetCurrentLevel()
	{
		return null;
	}

	public virtual Level GetLevel(int level)
	{
		return null;
	}

	protected virtual int WrapIndex(int desiredIndex, int loopLastX)
	{
		return 0;
	}

	public virtual Level[] GetAllLevels()
	{
		return null;
	}

	public virtual int GetNumLevels()
	{
		return 0;
	}
}
