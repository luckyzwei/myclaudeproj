using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SpecialDayEmployeeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Employee => 0;

		public int Specialdayemployee => 0;

		public static void ValidateVersion()
		{
		}

		public static SpecialDayEmployeeData GetRootAsSpecialDayEmployeeData(ByteBuffer _bb)
		{
			return default(SpecialDayEmployeeData);
		}

		public static SpecialDayEmployeeData GetRootAsSpecialDayEmployeeData(ByteBuffer _bb, SpecialDayEmployeeData obj)
		{
			return default(SpecialDayEmployeeData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SpecialDayEmployeeData __assign(int _i, ByteBuffer _bb)
		{
			return default(SpecialDayEmployeeData);
		}

		public bool MutateEmployee(int employee)
		{
			return false;
		}

		public bool MutateSpecialdayemployee(int specialdayemployee)
		{
			return false;
		}

		public static Offset<SpecialDayEmployeeData> CreateSpecialDayEmployeeData(FlatBufferBuilder builder, int employee = 0, int specialdayemployee = 0)
		{
			return default(Offset<SpecialDayEmployeeData>);
		}

		public static void StartSpecialDayEmployeeData(FlatBufferBuilder builder)
		{
		}

		public static void AddEmployee(FlatBufferBuilder builder, int employee)
		{
		}

		public static void AddSpecialdayemployee(FlatBufferBuilder builder, int specialdayemployee)
		{
		}

		public static Offset<SpecialDayEmployeeData> EndSpecialDayEmployeeData(FlatBufferBuilder builder)
		{
			return default(Offset<SpecialDayEmployeeData>);
		}

		public SpecialDayEmployeeDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SpecialDayEmployeeDataT _o)
		{
		}

		public static Offset<SpecialDayEmployeeData> Pack(FlatBufferBuilder builder, SpecialDayEmployeeDataT _o)
		{
			return default(Offset<SpecialDayEmployeeData>);
		}
	}
}
