using System;

public class TpInvalidCommand : TpCommand<TpCommandParams, string>
{
	private readonly Exception ex;

	public TpInvalidCommand(TpCommandParams cmdParams, Exception ex)
		: base((TpCommandParams)default(_00210))
	{
	}

	public override string Execute()
	{
		return null;
	}
}
