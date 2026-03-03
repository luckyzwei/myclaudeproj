using System;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public abstract class JsonContainerAttribute : Attribute
	{
		internal bool? _isReference;

		public string Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

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

		protected JsonContainerAttribute()
		{
		}

		protected JsonContainerAttribute(string id)
		{
		}
	}
}
