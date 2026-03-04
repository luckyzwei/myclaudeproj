public class TpReloadUserDataCommand : TpCommand<TpReloadUserDataParams, string>
{
	public TpReloadUserDataCommand(TpReloadUserDataParams cmdParams)
		: base(cmdParams)
	{
	}

	public override string Execute()
	{
		return null;
	}

	private void reloadSaveFileEc3()
	{
	}

	private void reloadMasterDot()
	{
	}
}
