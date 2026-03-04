public class TpRemoveNotificationListenerCommand : TpCommand<TpRemoveNotificationListenerParams, string>
{
	public TpRemoveNotificationListenerCommand(TpRemoveNotificationListenerParams cmdParams, string socketID, TpCommandHandler tpCommandHandler)
		: base(cmdParams)
	{
	}

	public override string Execute()
	{
		return null;
	}
}
