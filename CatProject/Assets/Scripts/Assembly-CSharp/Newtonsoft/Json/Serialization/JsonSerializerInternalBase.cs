using System;
using System.Collections.Generic;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	internal abstract class JsonSerializerInternalBase
	{
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
		{
			bool IEqualityComparer<object>.Equals(object x, object y)
			{
				return false;
			}

			int IEqualityComparer<object>.GetHashCode(object obj)
			{
				return 0;
			}
		}

		private ErrorContext _currentErrorContext;

		private BidirectionalDictionary<string, object> _mappings;

		internal JsonSerializer Serializer { get; private set; }

		internal BidirectionalDictionary<string, object> DefaultReferenceMappings => null;

		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
		}

		protected ErrorContext GetErrorContext(object currentObject, object member, Exception error)
		{
			return null;
		}

		protected void ClearErrorContext()
		{
		}

		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, Exception ex)
		{
			return false;
		}
	}
}
