public class TpAddNotificationListenerCommand : TpCommand<TpAddNotificationListenerParams, string>
{
	private TpCommandHandler tpCommandHandler;

	private string socketID;

	public TpAddNotificationListenerCommand(TpAddNotificationListenerParams cmdParams, string socketID, TpCommandHandler tpCommandHandler)
		: base(cmdParams)
	{
		this.socketID = socketID;
		this.tpCommandHandler = tpCommandHandler;
	}

	public override string Execute()
	{
		return null;
	}
}
