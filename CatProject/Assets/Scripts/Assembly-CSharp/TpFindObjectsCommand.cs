using System.Collections.Generic;

internal class TpFindObjectsCommand : TpBaseFindObjectsCommand<List<TpObject>>
{
	public TpFindObjectsCommand(BaseGameFindObjectParams cmdParams)
		: base((BaseGameFindObjectParams)null)
	{
	}

	public override List<TpObject> Execute()
	{
		return null;
	}
}
