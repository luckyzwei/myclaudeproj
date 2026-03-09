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
				if (s_instance == null)
					Load();
				return s_instance;
			}
			set
			{
				s_instance = value;
			}
		}

		private static void Load()
		{
			// Try loading from Resources by type name
			string typeName = typeof(T).Name;
			s_instance = Resources.Load<T>(typeName);
			if (s_instance == null)
				s_instance = Resources.Load<T>(CONFIG_LOCATION_OLD + "/" + typeName);
		}

		private static void CreateConfig()
		{
		}

		private static void ValidateDirectory(string directory)
		{
		}
	}
}
