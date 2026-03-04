public class TpStartStatsCommand : TpCommand<TpStartStatsParams, string>
{
	public TpStartStatsCommand(TpStartStatsParams commandParams)
		: base(commandParams)
	{
	}

	public override string Execute()
	{
		return null;
	}
}
