public class TpGetHardwareSpecCommand : TpCommand<TpGetHardwareSpecParams, TpHardwareSpec>
{
	public TpGetHardwareSpecCommand(TpGetHardwareSpecParams commandParams)
		: base(commandParams)
	{
	}

	public override TpHardwareSpec Execute()
	{
		return null;
	}
}
