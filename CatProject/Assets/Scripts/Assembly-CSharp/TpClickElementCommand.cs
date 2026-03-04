internal class TpClickElementCommand : TpCommandWithWait<TpClickElementParams, TpObject>
{
	public TpClickElementCommand(ITpCommandHandler handler, TpClickElementParams cmdParams, string socketID)
		: base(default(TpClickElementParams), (ITpCommandHandler)null, (string)null, false)
	{
	}

	public override TpObject Execute()
	{
		return null;
	}
}
