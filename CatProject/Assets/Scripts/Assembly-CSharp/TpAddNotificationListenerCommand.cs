public class TpAddNotificationListenerCommand : TpCommand<TpAddNotificationListenerParams, string>
{
	private TpCommandHandler tpCommandHandler;

	private string socketID;

	public TpAddNotificationListenerCommand(TpAddNotificationListenerParams cmdParams, string socketID, TpCommandHandler tpCommandHandler)
		: base((TpAddNotificationListenerParams)default(_00210))
	{
	}

	public override string Execute()
	{
		return null;
	}
}
