namespace Newtonsoft.Json.Bson
{
	internal class BsonValue : BsonToken
	{
		private object _value;

		private BsonType _type;

		public object Value => null;

		public override BsonType Type => default(BsonType);

		public BsonValue(object value, BsonType type)
		{
		}
	}
}
