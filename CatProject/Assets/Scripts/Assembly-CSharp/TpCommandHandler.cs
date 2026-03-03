using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UniRx;

public class TpCommandHandler : ITpCommandHandler
{
	private static readonly JsonSerializerSettings jsonSerializerSettings;

	private Dictionary<string, Func<TpCommandParams, string, ITpCommand>> commands;

	public Subject<TpCommandHandlerSendMessageArgs> SendMessageStream { get; set; }

	public void Send(string socketID, string data)
	{
	}

	public void OnMessage(string socketID, string data)
	{
	}

	private void initCommands()
	{
	}

	private Func<string> createCommand(TpCommandParams cmdParams, string socketID)
	{
		return null;
	}

	private Type getCommandType(string commandName)
	{
		return null;
	}
}
