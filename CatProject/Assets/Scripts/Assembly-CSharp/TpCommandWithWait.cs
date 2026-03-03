using System;

public abstract class TpCommandWithWait<TParam, TResult> : TpCommand<TParam, TResult> where TParam : TpCommandParams
{
	private readonly bool _wait;

	private readonly ITpCommandHandler _handler;

	private readonly string _socketID;

	protected TpCommandWithWait(TParam commandParams, ITpCommandHandler handler, string socketID, bool wait)
		: base((TParam)null)
	{
	}

	protected virtual void onFinish(Exception err)
	{
	}
}
