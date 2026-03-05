public class AdLoadSchedulerResult
{
	public string AdUnitId { get; }

	public bool IsSuccess { get; }

	public MaxSdkBase.AdInfo AdInfo { get; }

	public MaxSdkBase.ErrorInfo ErrorInfo { get; }

	public AdType AdType { get; }

	private AdLoadSchedulerResult(string adUnitId, bool isSuccess, AdType adType, MaxSdkBase.AdInfo adInfo = null, MaxSdkBase.ErrorInfo errorInfo = null)
	{
		AdUnitId = adUnitId;
		IsSuccess = isSuccess;
		AdType = adType;
		AdInfo = adInfo;
		ErrorInfo = errorInfo;
	}

	public static AdLoadSchedulerResult Success(string adUnitId, AdType adType, MaxSdkBase.AdInfo adInfo)
	{
		return new AdLoadSchedulerResult(adUnitId, true, adType, adInfo, null);
	}

	public static AdLoadSchedulerResult Failure(string adUnitId, AdType adType, MaxSdkBase.ErrorInfo errorInfo)
	{
		return new AdLoadSchedulerResult(adUnitId, false, adType, null, errorInfo);
	}
}
