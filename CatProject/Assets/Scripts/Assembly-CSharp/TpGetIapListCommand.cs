using System.Collections.Generic;

public class TpGetIapListCommand : TpCommand<TpGetIapListParams, List<string>>
{
	public TpGetIapListCommand(TpGetIapListParams cmdParams)
		: base((TpGetIapListParams)default(_00210))
	{
	}

	public override List<string> Execute()
	{
		return null;
	}
}
