using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor
	{
		public class JPropertKeyedCollection : KeyedCollection<string, JToken>
		{
			public new IDictionary<string, JToken> Dictionary => null;

			public JPropertKeyedCollection(IEqualityComparer<string> comparer)
			{
			}

			protected override string GetKeyForItem(JToken item)
			{
				return null;
			}

			protected override void InsertItem(int index, JToken item)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__49 : IEnumerator<KeyValuePair<string, JToken>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, JToken> _003C_003E2__current;

			public JObject _003C_003E4__this;

			private IEnumerator<JToken> _003C_003E7__wrap1;

			KeyValuePair<string, JToken> IEnumerator<KeyValuePair<string, JToken>>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, JToken>);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__49(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private JPropertKeyedCollection _properties;

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

		public JToken this[string propertyName]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		ICollection<string> IDictionary<string, JToken>.Keys => null;

		ICollection<JToken> IDictionary<string, JToken>.Values => null;

		bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly => false;

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public JObject()
		{
		}

		public JObject(JObject other)
		{
		}

		public JObject(params object[] content)
		{
		}

		public JObject(object content)
		{
		}

		internal override bool DeepEquals(JToken node)
		{
			return false;
		}

		internal override void InsertItem(int index, JToken item)
		{
		}

		internal override void ValidateToken(JToken o, JToken existing)
		{
		}

		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		public JProperty Property(string name)
		{
			return null;
		}

		public JEnumerable<JToken> PropertyValues()
		{
			return default(JEnumerable<JToken>);
		}

		public new static JObject Load(JsonReader reader)
		{
			return null;
		}

		public new static JObject Parse(string json)
		{
			return null;
		}

		public new static JObject FromObject(object o)
		{
			return null;
		}

		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		public void Add(string propertyName, JToken value)
		{
		}

		bool IDictionary<string, JToken>.ContainsKey(string key)
		{
			return false;
		}

		public bool Remove(string propertyName)
		{
			return false;
		}

		public bool TryGetValue(string propertyName, out JToken value)
		{
			value = null;
			return false;
		}

		void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item)
		{
		}

		void ICollection<KeyValuePair<string, JToken>>.Clear()
		{
		}

		bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item)
		{
			return false;
		}

		void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
		}

		bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item)
		{
			return false;
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__49))]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return null;
		}

		private static Type GetTokenPropertyType(JToken token)
		{
			return null;
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			return null;
		}

		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return null;
		}

		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return null;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return null;
		}

		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}
	}
}
