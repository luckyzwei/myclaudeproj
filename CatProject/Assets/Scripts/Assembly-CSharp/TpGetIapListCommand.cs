using System.Collections.Generic;

public class TpGetIapListCommand : TpCommand<TpGetIapListParams, List<string>>
{
	public TpGetIapListCommand(TpGetIapListParams cmdParams)
		: base(cmdParams)
	{
	}

	public override List<string> Execute()
	{
		return null;
	}
}
