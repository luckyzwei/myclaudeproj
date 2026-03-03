public class TpNotifyApplicationPausedCommand : TpCommand<TpNotifyApplicationPausedParams, bool>
{
	public TpNotifyApplicationPausedCommand(TpNotifyApplicationPausedParams tpNotifyApplicationPausedParams)
		: base((TpNotifyApplicationPausedParams)default(_00210))
	{
	}

	public override bool Execute()
	{
		return false;
	}
}
