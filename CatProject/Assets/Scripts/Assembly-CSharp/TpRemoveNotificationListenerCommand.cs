public class TpRemoveNotificationListenerCommand : TpCommand<TpRemoveNotificationListenerParams, string>
{
	public TpRemoveNotificationListenerCommand(TpRemoveNotificationListenerParams cmdParams, string socketID, TpCommandHandler tpCommandHandler)
		: base((TpRemoveNotificationListenerParams)default(_00210))
	{
	}

	public override string Execute()
	{
		return null;
	}
}
