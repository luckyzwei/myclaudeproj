using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx;
using UniRx.Async;
using UniRx.Async.CompilerServices;

public class AdLoadScheduler
{
	private class AdLoadRequest
	{
		public string AdUnitId { get; }

		public AdType AdType { get; }

		public Subject<AdLoadSchedulerResult> Subject { get; }

		public AdLoadRequest(string adUnitId, AdType adType)
		{
			AdUnitId = adUnitId;
			AdType = adType;
			Subject = new Subject<AdLoadSchedulerResult>();
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadAdAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<AdLoadSchedulerResult> _003C_003Et__builder;

		public AdType adType;

		public string unitID;

		public AdLoadScheduler _003C_003E4__this;

		private UniTask<AdLoadSchedulerResult>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadNextAd_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public AdLoadScheduler _003C_003E4__this;

		private AdLoadRequest _003Crequest_003E5__2;

		private UniTask<AdLoadSchedulerResult>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private readonly ReactiveCollection<AdLoadRequest> scheduler;

	private AdLoadRequest currentRequest;

	public AdLoadScheduler()
	{
	}

	public IObservable<AdLoadSchedulerResult> Schedule(string adUnitId, AdType adType)
	{
		var existing = GetExistingRequest(adUnitId, adType);
		if (existing != null)
			return existing.Subject;

		var request = new AdLoadRequest(adUnitId, adType);
		scheduler?.Add(request);
		return request.Subject;
	}

	public IObservable<AdLoadSchedulerResult> ScheduleNow(string adUnitId, AdType adType)
	{
		var existing = GetExistingRequest(adUnitId, adType);
		if (existing != null)
			return existing.Subject;

		var request = new AdLoadRequest(adUnitId, adType);
		// Insert at front for priority loading
		scheduler?.Insert(0, request);
		return request.Subject;
	}

	private bool TryGetCurrentRequestObservable(string adUnitId, AdType adType, out IObservable<AdLoadSchedulerResult> observable)
	{
		observable = null;
		if (currentRequest != null && currentRequest.AdUnitId == adUnitId && currentRequest.AdType == adType)
		{
			observable = currentRequest.Subject;
			return true;
		}
		return false;
	}

	private AdLoadRequest GetExistingRequest(string adUnitId, AdType adType)
	{
		if (currentRequest != null && currentRequest.AdUnitId == adUnitId && currentRequest.AdType == adType)
			return currentRequest;

		if (scheduler == null) return null;
		for (int i = 0; i < scheduler.Count; i++)
		{
			if (scheduler[i] != null && scheduler[i].AdUnitId == adUnitId && scheduler[i].AdType == adType)
				return scheduler[i];
		}
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoadNextAd_003Ed__8))]
	private UniTask LoadNextAd()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CLoadAdAsync_003Ed__9))]
	private UniTask<AdLoadSchedulerResult> LoadAdAsync(string unitID, AdType adType)
	{
		return default(UniTask<AdLoadSchedulerResult>);
	}

	private (IObservable<AdLoadSchedulerResult>, IObservable<AdLoadSchedulerResult>) GetAdObservables(string unitID, AdType adType)
	{
		var loaded = GetRewardedAdLoadedObservable(unitID, adType);
		var failed = GetRewardedAdFailedObservable(unitID, adType);
		return (loaded, failed);
	}

	private IObservable<AdLoadSchedulerResult> GetRewardedAdLoadedObservable(string unitID, AdType adType)
	{
		return Observable.Empty<AdLoadSchedulerResult>();
	}

	private IObservable<AdLoadSchedulerResult> GetRewardedAdFailedObservable(string unitID, AdType adType)
	{
		return Observable.Empty<AdLoadSchedulerResult>();
	}

	private IObservable<AdLoadSchedulerResult> GetInterstitialAdLoadedObservable(string unitID, AdType adType)
	{
		return Observable.Empty<AdLoadSchedulerResult>();
	}

	private IObservable<AdLoadSchedulerResult> GetInterstitialAdFailedObservable(string unitID, AdType adType)
	{
		return Observable.Empty<AdLoadSchedulerResult>();
	}

	private void LogAdLoadResult(AdLoadSchedulerResult schedulerResult)
	{
		if (schedulerResult == null) return;
		string status = schedulerResult.IsSuccess ? "Success" : "Failed";
		UnityEngine.Debug.Log($"[AdLoadScheduler] {schedulerResult.AdType} {status}: {schedulerResult.AdUnitId}");
	}
}
