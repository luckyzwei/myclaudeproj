internal class TpGetScreenshotPNGCommand : TpBaseScreenshotCommand<TpGetPNGScreenshotParams, string>
{
	public TpGetScreenshotPNGCommand(ITpCommandHandler handler, TpGetPNGScreenshotParams cmdParams, string socketID)
		: base((ITpCommandHandler)null, (TpGetPNGScreenshotParams)default(_00210), (string)null)
	{
	}

	public override string Execute()
	{
		return null;
	}
}
