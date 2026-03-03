namespace Newtonsoft.Json.Utilities
{
	internal class StringBuffer
	{
		private char[] _buffer;

		private int _position;

		private static readonly char[] _emptyBuffer;

		public int Position
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public StringBuffer()
		{
		}

		public StringBuffer(int initalSize)
		{
		}

		public void Append(char value)
		{
		}

		public void Clear()
		{
		}

		private void EnsureSize(int appendLength)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(int start, int length)
		{
			return null;
		}

		public char[] GetInternalBuffer()
		{
			return null;
		}
	}
}
