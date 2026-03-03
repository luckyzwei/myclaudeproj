using System.IO;

namespace Newtonsoft.Json.Utilities
{
	internal class Base64Encoder
	{
		private const int Base64LineSize = 76;

		private const int LineSizeInBytes = 57;

		private readonly char[] _charsLine;

		private readonly TextWriter _writer;

		private byte[] _leftOverBytes;

		private int _leftOverBytesCount;

		public Base64Encoder(TextWriter writer)
		{
		}

		public void Encode(byte[] buffer, int index, int count)
		{
		}

		public void Flush()
		{
		}

		private void WriteChars(char[] chars, int index, int count)
		{
		}
	}
}
