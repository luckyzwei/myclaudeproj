namespace KPFCore
{
	public abstract class ServiceBase<T> : IService where T : class
	{
		private bool m_initialised;

		public static T Instance { get; private set; }

		public void Initialise(IRepository dataRepository, IConfig config = null)
		{
		}

		protected abstract void InitialiseLocal(IRepository dataRepository, IConfig config = null);
	}
}
