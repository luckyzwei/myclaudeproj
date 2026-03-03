using System;
using System.Reflection;

namespace Newtonsoft.Json.Serialization
{
	internal class LateBoundMetadataTypeAttribute : IMetadataTypeAttribute
	{
		private static PropertyInfo _metadataClassTypeProperty;

		private readonly object _attribute;

		public Type MetadataClassType => null;

		public LateBoundMetadataTypeAttribute(object attribute)
		{
		}
	}
}
