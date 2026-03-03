using System;

namespace Newtonsoft.Json.Schema
{
	public class ValidationEventArgs : EventArgs
	{
		private readonly JsonSchemaException _ex;

		public JsonSchemaException Exception => null;

		public string Message => null;

		internal ValidationEventArgs(JsonSchemaException ex)
		{
		}
	}
}
