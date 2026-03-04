namespace WebSocketSharp.Net
{
	internal class Chunk
	{
		private byte[] _data;

		private int _offset;

		public int ReadLeft => 0;

		public Chunk(byte[] data)
	{
		_data = data;
	}

		public int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}
	}
}
