using System;
using System.IO;
using System.Text;

namespace Newtonsoft.Json.Bson
{
	internal class BsonBinaryWriter
	{
		private static readonly Encoding Encoding;

		private readonly BinaryWriter _writer;

		private byte[] _largeByteBuffer;

		private int _maxChars;

		public DateTimeKind DateTimeKindHandling { get; set; }

		public BsonBinaryWriter(Stream stream)
		{
		}

		public void Flush()
		{
		}

		public void Close()
		{
		}

		public void WriteToken(BsonToken t)
		{
		}

		private void WriteTokenInternal(BsonToken t)
		{
		}

		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix)
		{
		}

		private int CalculateSize(int stringByteCount)
		{
			return 0;
		}

		private int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			return 0;
		}

		private int CalculateSize(BsonToken t)
		{
			return 0;
		}
	}
}
