using UniRx;

public interface ITpCommandHandler
{
	Subject<TpCommandHandlerSendMessageArgs> SendMessageStream { get; set; }

	void Send(string socketID, string data);

	void OnMessage(string socketID, string data);
}
