using System;

public class TpInvalidCommand : TpCommand<TpCommandParams, string>
{
	private readonly Exception ex;

	public TpInvalidCommand(TpCommandParams cmdParams, Exception ex)
		: base(cmdParams)
	{
		this.ex = ex;
	}

	public override string Execute()
	{
		return null;
	}
}
