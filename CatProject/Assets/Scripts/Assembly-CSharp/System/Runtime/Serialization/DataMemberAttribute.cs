namespace System.Runtime.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class DataMemberAttribute : Attribute
	{
		private bool is_required;

		private bool emit_default;

		private string name;

		private int order;

		public bool EmitDefaultValue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsRequired
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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
	}
}
