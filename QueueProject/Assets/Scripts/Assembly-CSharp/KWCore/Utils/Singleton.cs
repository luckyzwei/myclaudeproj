namespace KWCore.Utils
{
	public abstract class Singleton<T> where T : Singleton<T>, new()
	{
		protected static T s_instance;

		public static bool Exist => s_instance != null;

		public static T Instance
		{
			get
			{
				if (s_instance == null)
				{
					s_instance = new T();
					s_instance.Init();
				}
				return s_instance;
			}
		}

		protected abstract void Init();

		public void Touch()
		{
			// Access Instance to trigger lazy initialization
			var _ = Instance;
		}
	}
}
