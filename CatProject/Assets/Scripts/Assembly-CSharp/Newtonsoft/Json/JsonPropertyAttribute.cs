using System;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class JsonPropertyAttribute : Attribute
	{
		internal NullValueHandling? _nullValueHandling;

		internal DefaultValueHandling? _defaultValueHandling;

		internal ReferenceLoopHandling? _referenceLoopHandling;

		internal ObjectCreationHandling? _objectCreationHandling;

		internal TypeNameHandling? _typeNameHandling;

		internal bool? _isReference;

		internal int? _order;

		public NullValueHandling NullValueHandling
		{
			get
			{
				return default(NullValueHandling);
			}
			set
			{
			}
		}

		public DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return default(DefaultValueHandling);
			}
			set
			{
			}
		}

		public ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return default(ReferenceLoopHandling);
			}
			set
			{
			}
		}

		public ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return default(ObjectCreationHandling);
			}
			set
			{
			}
		}

		public TypeNameHandling TypeNameHandling
		{
			get
			{
				return default(TypeNameHandling);
			}
			set
			{
			}
		}

		public bool IsReference
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Order
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string PropertyName { get; set; }

		public Required Required { get; set; }

		public JsonPropertyAttribute()
		{
		}

		public JsonPropertyAttribute(string propertyName)
		{
		}
	}
}
