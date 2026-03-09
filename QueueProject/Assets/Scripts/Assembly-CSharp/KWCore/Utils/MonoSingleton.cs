namespace KWCore.Utils
{
	public abstract class MonoSingleton<T> : BaseBehaviour where T : MonoSingleton<T>
	{
		protected static T s_instance;

		private static bool s_isInitialized;

		private static ApplicationQuitting s_isQuitting;

		public static bool Exist => false;

		public static T Instance => null;

		public static bool isTemporaryInstance { get; private set; }

		protected virtual bool PerisistBetweenScenes => false;

		public static D GetTypedInstance<D>() where D : T
		{
			return null;
		}

		private void OnApplicationQuit()
		{
		}

		private void Awake()
		{
		}

		protected abstract void Init();

		public void Touch()
		{
		}
	}
}
