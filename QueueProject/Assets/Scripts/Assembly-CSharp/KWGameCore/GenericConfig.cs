using UnityEngine;

namespace KWGameCore
{
	public abstract class GenericConfig<T> : ScriptableObject where T : GenericConfig<T>
	{
		private const string CONFIG_LOCATION_OLD = "Configs";

		private static T s_instance;

		public static T Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static void Load()
		{
		}

		private static void CreateConfig()
		{
		}

		private static void ValidateDirectory(string directory)
		{
		}
	}
}
