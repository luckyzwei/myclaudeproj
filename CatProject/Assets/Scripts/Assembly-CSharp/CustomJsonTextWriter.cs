using System.IO;
using Newtonsoft.Json;

public class CustomJsonTextWriter : JsonTextWriter
{
	public int CurrentDepth { get; private set; }

	public CustomJsonTextWriter(TextWriter textWriter)
		: base(textWriter)
	{
	}

	public override void WriteStartObject()
	{
	}

	public override void WriteEndObject()
	{
	}
}
