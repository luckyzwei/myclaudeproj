public class AdLoadSchedulerResult
{
	public string AdUnitId { get; }

	public bool IsSuccess { get; }

	public MaxSdkBase.AdInfo AdInfo { get; }

	public MaxSdkBase.ErrorInfo ErrorInfo { get; }

	public AdType AdType { get; }

	private AdLoadSchedulerResult(string adUnitId, bool isSuccess, AdType adType, MaxSdkBase.AdInfo adInfo = null, MaxSdkBase.ErrorInfo errorInfo = null)
	{
	}

	public static AdLoadSchedulerResult Success(string adUnitId, AdType adType, MaxSdkBase.AdInfo adInfo)
	{
		return null;
	}

	public static AdLoadSchedulerResult Failure(string adUnitId, AdType adType, MaxSdkBase.ErrorInfo errorInfo)
	{
		return null;
	}
}
