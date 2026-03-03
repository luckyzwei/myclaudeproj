namespace Newtonsoft.Json.Bson
{
	internal class BsonRegex : BsonToken
	{
		public BsonString Pattern { get; set; }

		public BsonString Options { get; set; }

		public override BsonType Type => default(BsonType);

		public BsonRegex(string pattern, string options)
		{
		}
	}
}
