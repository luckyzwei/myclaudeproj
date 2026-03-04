using System.Collections.Generic;

public class TpGetPurchasePackagesCommand : TpCommand<TpGetPurchasePackagesParams, List<int>>
{
	public TpGetPurchasePackagesCommand(TpGetPurchasePackagesParams cmdHandler)
		: base(cmdHandler)
	{
	}

	public override List<int> Execute()
	{
		return null;
	}
}
