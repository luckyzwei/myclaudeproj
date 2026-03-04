public class TpCallComponentMethodCommand : TpBaseFindObjectsCommand<string>
{
	private readonly string componentName;

	private readonly string methodName;

	public TpCallComponentMethodCommand(TpCallComponentMethodParams cmdParams)
		: base(cmdParams)
	{
	}

	public override string Execute()
	{
		return null;
	}
}
