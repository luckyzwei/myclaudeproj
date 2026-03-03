using System.Collections.Generic;

public class TpGetPurchasePackagesCommand : TpCommand<TpGetPurchasePackagesParams, List<int>>
{
	public TpGetPurchasePackagesCommand(TpGetPurchasePackagesParams cmdHandler)
		: base((TpGetPurchasePackagesParams)default(_00210))
	{
	}

	public override List<int> Execute()
	{
		return null;
	}
}
