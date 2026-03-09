using UnityEngine;

namespace KWGameSettings
{
	public abstract class GameSettingsInterface : MonoBehaviour
	{
		public abstract IGameSettings GetGameSettingsServer();

		public virtual bool HasSettings()
		{
			return false;
		}
	}
}
