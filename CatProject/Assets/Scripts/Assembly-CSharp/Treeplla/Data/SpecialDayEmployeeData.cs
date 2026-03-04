using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SpecialDayEmployeeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Employee { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Specialdayemployee { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SpecialDayEmployeeData GetRootAsSpecialDayEmployeeData(ByteBuffer _bb)
		{
			return GetRootAsSpecialDayEmployeeData(_bb, new SpecialDayEmployeeData());
		}

		public static SpecialDayEmployeeData GetRootAsSpecialDayEmployeeData(ByteBuffer _bb, SpecialDayEmployeeData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SpecialDayEmployeeData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateEmployee(int employee)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, employee);
				return true;
			}
			return false;
		}

		public bool MutateSpecialdayemployee(int specialdayemployee)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, specialdayemployee);
				return true;
			}
			return false;
		}

		public static Offset<SpecialDayEmployeeData> CreateSpecialDayEmployeeData(FlatBufferBuilder builder, int employee = 0, int specialdayemployee = 0)
		{
			builder.StartTable(2);
			AddSpecialdayemployee(builder, specialdayemployee);
			AddEmployee(builder, employee);
			return EndSpecialDayEmployeeData(builder);
		}

		public static void StartSpecialDayEmployeeData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddEmployee(FlatBufferBuilder builder, int employee)
		{
			builder.AddInt(0, employee, 0);
		}

		public static void AddSpecialdayemployee(FlatBufferBuilder builder, int specialdayemployee)
		{
			builder.AddInt(1, specialdayemployee, 0);
		}

		public static Offset<SpecialDayEmployeeData> EndSpecialDayEmployeeData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SpecialDayEmployeeData>(o);
		}

		public SpecialDayEmployeeDataT UnPack()
		{
			var _o = new SpecialDayEmployeeDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SpecialDayEmployeeDataT _o)
		{
			_o.Employee = this.Employee;
			_o.Specialdayemployee = this.Specialdayemployee;
		}

		public static Offset<SpecialDayEmployeeData> Pack(FlatBufferBuilder builder, SpecialDayEmployeeDataT _o)
		{
			if (_o == null) return default(Offset<SpecialDayEmployeeData>);
			StartSpecialDayEmployeeData(builder);
			AddEmployee(builder, _o.Employee);
			AddSpecialdayemployee(builder, _o.Specialdayemployee);
			return EndSpecialDayEmployeeData(builder);
		}
	}
}
