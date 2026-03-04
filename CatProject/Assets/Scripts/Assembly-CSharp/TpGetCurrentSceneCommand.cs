public class TpGetCurrentSceneCommand : TpCommand<TpGetCurrentSceneParams, TpObject>
{
	public TpGetCurrentSceneCommand(TpGetCurrentSceneParams cmdParams)
		: base(cmdParams)
	{
	}

	public override TpObject Execute()
	{
		return null;
	}
}
