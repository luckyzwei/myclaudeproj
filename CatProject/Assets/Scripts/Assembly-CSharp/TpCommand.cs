using System;

public abstract class TpCommand<TParam, TResult> : ITpCommand where TParam : TpCommandParams
{
	private const int MAX_DEPTH_REPONSE_DATA_SERIALIZATION = 2;

	public TParam CommandParams { get; private set; }

	protected TpCommand(TParam commandParams)
	{
	}

	public string ExecuteAndSerialize<T>(Func<T> action)
	{
		return null;
	}

	public string ExecuteAndSerialize()
	{
		return null;
	}

	protected CommandResponse ExecuteHandleErrors<T>(Func<T> action)
	{
		return null;
	}

	public abstract TResult Execute();
}
