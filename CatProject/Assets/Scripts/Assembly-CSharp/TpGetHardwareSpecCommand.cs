public class TpGetHardwareSpecCommand : TpCommand<TpGetHardwareSpecParams, TpHardwareSpec>
{
	public TpGetHardwareSpecCommand(TpGetHardwareSpecParams commandParams)
		: base((TpGetHardwareSpecParams)default(_00210))
	{
	}

	public override TpHardwareSpec Execute()
	{
		return null;
	}
}
