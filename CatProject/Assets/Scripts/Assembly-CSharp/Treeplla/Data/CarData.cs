using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CarData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Parkingidx => 0;

		public int Parkingzone => 0;

		public static void ValidateVersion()
		{
		}

		public static CarData GetRootAsCarData(ByteBuffer _bb)
		{
			return default(CarData);
		}

		public static CarData GetRootAsCarData(ByteBuffer _bb, CarData obj)
		{
			return default(CarData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public CarData __assign(int _i, ByteBuffer _bb)
		{
			return default(CarData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateParkingidx(int parkingidx)
		{
			return false;
		}

		public bool MutateParkingzone(int parkingzone)
		{
			return false;
		}

		public static Offset<CarData> CreateCarData(FlatBufferBuilder builder, int idx = 0, int parkingidx = 0, int parkingzone = -1)
		{
			return default(Offset<CarData>);
		}

		public static void StartCarData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddParkingidx(FlatBufferBuilder builder, int parkingidx)
		{
		}

		public static void AddParkingzone(FlatBufferBuilder builder, int parkingzone)
		{
		}

		public static Offset<CarData> EndCarData(FlatBufferBuilder builder)
		{
			return default(Offset<CarData>);
		}

		public CarDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(CarDataT _o)
		{
		}

		public static Offset<CarData> Pack(FlatBufferBuilder builder, CarDataT _o)
		{
			return default(Offset<CarData>);
		}
	}
}
