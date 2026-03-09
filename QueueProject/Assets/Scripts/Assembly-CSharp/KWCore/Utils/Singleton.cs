namespace KWCore.Utils
{
	public abstract class Singleton<T> where T : Singleton<T>, new()
	{
		protected static T s_instance;

		public static bool Exist => false;

		public static T Instance => null;

		protected abstract void Init();

		public void Touch()
		{
		}
	}
}
