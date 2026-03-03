public class TpIsInteractableCommand : TpCommand<TpIsInteractableParams, bool>
{
	public TpIsInteractableCommand(TpIsInteractableParams cmdParams)
		: base((TpIsInteractableParams)default(_00210))
	{
	}

	public override bool Execute()
	{
		return false;
	}
}
