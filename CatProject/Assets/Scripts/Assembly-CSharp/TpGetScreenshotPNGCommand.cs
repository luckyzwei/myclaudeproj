internal class TpGetScreenshotPNGCommand : TpBaseScreenshotCommand<TpGetPNGScreenshotParams, string>
{
	public TpGetScreenshotPNGCommand(ITpCommandHandler handler, TpGetPNGScreenshotParams cmdParams, string socketID)
		: base((ITpCommandHandler)null, default(TpGetPNGScreenshotParams), (string)null)
	{
	}

	public override string Execute()
	{
		return null;
	}
}
