using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public class JConstructor : JContainer
	{
		private string _name;

		private IList<JToken> _values;

		protected override IList<JToken> ChildrenTokens => null;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JTokenType Type => default(JTokenType);

		public override JToken this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JConstructor()
		{
		}

		public JConstructor(JConstructor other)
		{
		}

		public JConstructor(string name, params object[] content)
		{
		}

		public JConstructor(string name, object content)
		{
		}

		public JConstructor(string name)
		{
		}

		internal override bool DeepEquals(JToken node)
		{
			return false;
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}

		public new static JConstructor Load(JsonReader reader)
		{
			return null;
		}
	}
}
