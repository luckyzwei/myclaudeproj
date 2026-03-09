using System;
using System.Collections.Generic;

public class AddressableDownloadData
{
	public enum Status
	{
		NOT_STARTED = 0,
		IN_PROGRESS = 1,
		FAILED = 2,
		FINISHED = 3
	}

	public Status status;

	public string id;

	public List<string> assetRequired;

	public Action finishedCallback;

	public Action<float> progressCallback;

	public Action failedCallback;
}
