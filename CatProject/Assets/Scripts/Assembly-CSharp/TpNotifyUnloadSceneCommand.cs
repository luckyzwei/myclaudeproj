public class TpNotifyUnloadSceneCommand : TpCommand<TpNotifyUnloadSceneParams, TpObject>
{
	public TpNotifyUnloadSceneCommand(TpNotifyUnloadSceneParams tpNotifyUnloadSceneParams)
		: base(tpNotifyUnloadSceneParams)
	{
	}

	public override TpObject Execute()
	{
		return null;
	}
}
