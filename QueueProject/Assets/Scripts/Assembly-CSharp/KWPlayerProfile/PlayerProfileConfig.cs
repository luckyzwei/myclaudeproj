using KPFCore;
using UnityEngine;

namespace KWPlayerProfile
{
	[CreateAssetMenu(fileName = "LocalPlayerProfileConfig", menuName = "KPF/Configs/Create Local PlayerProfile Config")]
	public class PlayerProfileConfig : ScriptableObject, IConfig
	{
		public enum Service
		{
			BALANCY = 0,
			NAKAMA = 1,
			LOCAL = 2
		}

		public Service service;

		public int usernameMaxCharacters;

		public int cacheTimeOutInSeconds;
	}
}
