public class TpIsInteractableCommand : TpCommand<TpIsInteractableParams, bool>
{
	public TpIsInteractableCommand(TpIsInteractableParams cmdParams)
		: base(cmdParams)
	{
	}

	public override bool Execute()
	{
		return false;
	}
}
