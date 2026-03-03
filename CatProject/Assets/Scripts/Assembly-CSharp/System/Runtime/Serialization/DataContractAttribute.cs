namespace System.Runtime.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public sealed class DataContractAttribute : Attribute
	{
		private string name;

		private string ns;

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

		public string Namespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsReference { get; set; }
	}
}
