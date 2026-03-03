using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		private IList<JToken> _values;

		protected override IList<JToken> ChildrenTokens => null;

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

		public JToken this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool ICollection<JToken>.IsReadOnly => false;

		public JArray()
		{
		}

		public JArray(JArray other)
		{
		}

		public JArray(params object[] content)
		{
		}

		public JArray(object content)
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

		public new static JArray Load(JsonReader reader)
		{
			return null;
		}

		public new static JArray Parse(string json)
		{
			return null;
		}

		public new static JArray FromObject(object o)
		{
			return null;
		}

		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		public int System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIndexOf(JToken item)
		{
			return 0;
		}

		public void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EInsert(int index, JToken item)
		{
		}

		public void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemoveAt(int index)
		{
		}

		public void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(JToken item)
		{
		}

		public void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EClear()
		{
		}

		public bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContains(JToken item)
		{
			return false;
		}

		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
		}

		public bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemove(JToken item)
		{
			return false;
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}
	}
}
