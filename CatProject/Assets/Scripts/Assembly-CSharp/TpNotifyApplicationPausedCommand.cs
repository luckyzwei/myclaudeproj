public class TpNotifyApplicationPausedCommand : TpCommand<TpNotifyApplicationPausedParams, bool>
{
	public TpNotifyApplicationPausedCommand(TpNotifyApplicationPausedParams tpNotifyApplicationPausedParams)
		: base(tpNotifyApplicationPausedParams)
	{
	}

	public override bool Execute()
	{
		return false;
	}
}
