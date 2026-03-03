using System.Collections.Generic;

public class TpKillGameObjectsCommand : TpBaseFindObjectsCommand<List<TpObject>>
{
	public TpKillGameObjectsCommand(TpKillGameObjectsParams cmdParams)
		: base((BaseGameFindObjectParams)null)
	{
	}

	public override List<TpObject> Execute()
	{
		return null;
	}
}
