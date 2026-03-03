using System;
using System.ComponentModel;

namespace Newtonsoft.Json.Linq
{
	public class JPropertyDescriptor : PropertyDescriptor
	{
		private readonly Type _propertyType;

		public override Type ComponentType => null;

		public override bool IsReadOnly => false;

		public override Type PropertyType => null;

		protected override int NameHashCode => 0;

		public JPropertyDescriptor(string name, Type propertyType)
			: base((string)null, (Attribute[])null)
		{
		}

		private static JObject CastInstance(object instance)
		{
			return null;
		}

		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override object GetValue(object component)
		{
			return null;
		}

		public override void ResetValue(object component)
		{
		}

		public override void SetValue(object component, object value)
		{
		}

		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}
}
