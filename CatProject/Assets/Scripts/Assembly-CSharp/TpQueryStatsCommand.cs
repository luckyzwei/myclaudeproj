public class TpQueryStatsCommand : TpCommand<TpQueryStatsParams, string>
{
	public TpQueryStatsCommand(TpQueryStatsParams commandParams)
		: base(commandParams)
	{
	}

	public override string Execute()
	{
		return null;
	}
}
