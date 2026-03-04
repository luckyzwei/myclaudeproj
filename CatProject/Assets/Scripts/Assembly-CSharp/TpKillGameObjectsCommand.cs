using System.Collections.Generic;

public class TpKillGameObjectsCommand : TpBaseFindObjectsCommand<List<TpObject>>
{
	public TpKillGameObjectsCommand(TpKillGameObjectsParams cmdParams)
		: base(cmdParams)
	{
	}

	public override List<TpObject> Execute()
	{
		return null;
	}
}
