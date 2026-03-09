namespace KWAds.Ads
{
	public abstract class ImpressionDataWrapperBase<T>
	{
		protected T m_impressionData;

		protected string m_adUniqueId;

		protected string m_adRequestUniqueId;

		protected bool m_loading;

		protected long m_loadStartTime;

		protected long m_loadedTime;

		protected long m_lastPauseTime;

		protected CoreCompetitorImpressionData m_competitorImpressionData;

		public string AdImpressionLocation { get; protected set; }

		public string AppAdPlacementFormat { get; protected set; }

		public virtual void StartLoad()
		{
		}

		public virtual T GetImpressionData()
		{
			return default(T);
		}

		public virtual void OnApplicationPause(bool isPaused)
		{
		}

		public virtual long? GetLoadDuration()
		{
			return null;
		}

		public virtual void SetAdLocation(string adLocation)
		{
		}

		public virtual void SetCompetitorImpressionData(CoreCompetitorImpressionData competitorData)
		{
		}

		public virtual string GetAdUniqueID()
		{
			return null;
		}

		public virtual string GetAdRequestUniqueID()
		{
			return null;
		}

		public virtual bool IsLoaded()
		{
			return false;
		}

		public abstract CoreCompetitorImpressionData GetCompetitorImpressionData();

		public abstract void AdLoaded(T impressionData);

		public abstract void AdPaid(T impressionData);

		public abstract double? GetRevenue();

		public abstract string GetJsonRepresentation();

		public abstract string GetAppAdPlacementFormat();

		public abstract void SetAppAdPlacementFormat(string appAdPlacementFormat);
	}
}
