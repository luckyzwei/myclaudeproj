namespace Newtonsoft.Json.Utilities
{
	internal class EnumValue<T> where T : struct
	{
		private string _name;

		private T _value;

		public string Name => null;

		public T Value => default(T);

		public EnumValue(string name, T value)
		{
		}
	}
}
