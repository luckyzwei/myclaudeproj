namespace KWCore.Utils
{
	public abstract class MonoSingleton<T> : BaseBehaviour where T : MonoSingleton<T>
	{
		protected static T s_instance;

		private static bool s_isInitialized;

		private static ApplicationQuitting s_isQuitting;

		public static bool Exist => s_instance != null;

		public static T Instance
		{
			get
			{
				if (s_isQuitting != null && s_isQuitting.quitting)
					return null;
				if (s_instance == null)
				{
					s_instance = UnityEngine.Object.FindObjectOfType<T>();
					if (s_instance == null)
					{
						var go = new UnityEngine.GameObject(typeof(T).Name);
						s_instance = go.AddComponent<T>();
						isTemporaryInstance = true;
					}
				}
				return s_instance;
			}
		}

		public static bool isTemporaryInstance { get; private set; }

		protected virtual bool PerisistBetweenScenes => false;

		public static D GetTypedInstance<D>() where D : T
		{
			return Instance as D;
		}

		private void OnApplicationQuit()
		{
			if (s_isQuitting == null)
				s_isQuitting = new ApplicationQuitting();
			s_isQuitting.quitting = true;
		}

		private void Awake()
		{
			if (s_instance != null && s_instance != this)
			{
				Destroy(gameObject);
				return;
			}
			s_instance = this as T;
			s_isInitialized = true;
			isTemporaryInstance = false;
			if (PerisistBetweenScenes)
				DontDestroyOnLoad(gameObject);
			Init();
		}

		protected abstract void Init();

		public void Touch()
		{
			// Just ensures Instance is created
		}
	}
}
