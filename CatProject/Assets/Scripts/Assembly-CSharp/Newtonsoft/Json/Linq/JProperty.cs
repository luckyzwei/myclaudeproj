using System.Collections.Generic;
using System.Diagnostics;

namespace Newtonsoft.Json.Linq
{
	public class JProperty : JContainer
	{
		private readonly List<JToken> _content;

		private readonly string _name;

		protected override IList<JToken> ChildrenTokens => null;

		public string Name
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public new JToken Value
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JTokenType Type
		{
			[DebuggerStepThrough]
			get
			{
				return default(JTokenType);
			}
		}

		public JProperty(JProperty other)
		{
		}

		internal override JToken GetItem(int index)
		{
			return null;
		}

		internal override void SetItem(int index, JToken item)
		{
		}

		internal override bool RemoveItem(JToken item)
		{
			return false;
		}

		internal override void RemoveItemAt(int index)
		{
		}

		internal override void InsertItem(int index, JToken item)
		{
		}

		internal override bool ContainsItem(JToken item)
		{
			return false;
		}

		internal override void ClearItems()
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

		internal JProperty(string name)
		{
		}

		public JProperty(string name, params object[] content)
		{
		}

		public JProperty(string name, object content)
		{
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}

		public new static JProperty Load(JsonReader reader)
		{
			return null;
		}
	}
}
