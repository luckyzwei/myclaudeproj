using System;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
		private bool _allowNullItems;

		public bool AllowNullItems
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public JsonArrayAttribute()
		{
		}

		public JsonArrayAttribute(bool allowNullItems)
		{
		}

		public JsonArrayAttribute(string id)
		{
		}
	}
}
