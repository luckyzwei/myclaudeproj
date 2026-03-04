public class TpStopStatsCommand : TpCommand<TpStopStatsParams, string>
{
	public TpStopStatsCommand(TpStopStatsParams commandParams)
		: base(commandParams)
	{
	}

	public override string Execute()
	{
		return null;
	}
}
