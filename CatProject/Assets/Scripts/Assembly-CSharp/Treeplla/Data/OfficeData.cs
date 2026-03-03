using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OfficeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Office => 0;

		public int Company => 0;

		public int ItemsLength => 0;

		public bool Isopend => false;

		public long Opencompletetime => 0L;

		public int Level => 0;

		public int Exp => 0;

		public long Companyendtime => 0L;

		public int EmployeesLength => 0;

		public long Maintenancetime => 0L;

		public bool Inmaintenance => false;

		public bool Inrepair => false;

		public long Lastrepairtime => 0L;

		public int Manager => 0;

		public bool Onnegotiation => false;

		public static void ValidateVersion()
		{
		}

		public static OfficeData GetRootAsOfficeData(ByteBuffer _bb)
		{
			return default(OfficeData);
		}

		public static OfficeData GetRootAsOfficeData(ByteBuffer _bb, OfficeData obj)
		{
			return default(OfficeData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public OfficeData __assign(int _i, ByteBuffer _bb)
		{
			return default(OfficeData);
		}

		public bool MutateOffice(int office)
		{
			return false;
		}

		public bool MutateCompany(int company)
		{
			return false;
		}

		public OfficeItemData? Items(int j)
		{
			return null;
		}

		public bool MutateIsopend(bool isopend)
		{
			return false;
		}

		public bool MutateOpencompletetime(long opencompletetime)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateExp(int exp)
		{
			return false;
		}

		public bool MutateCompanyendtime(long companyendtime)
		{
			return false;
		}

		public EmployeeData? Employees(int j)
		{
			return null;
		}

		public bool MutateMaintenancetime(long maintenancetime)
		{
			return false;
		}

		public bool MutateInmaintenance(bool inmaintenance)
		{
			return false;
		}

		public bool MutateInrepair(bool inrepair)
		{
			return false;
		}

		public bool MutateLastrepairtime(long lastrepairtime)
		{
			return false;
		}

		public bool MutateManager(int manager)
		{
			return false;
		}

		public bool MutateOnnegotiation(bool onnegotiation)
		{
			return false;
		}

		public static Offset<OfficeData> CreateOfficeData(FlatBufferBuilder builder, int office = 0, int company = 0, VectorOffset itemsOffset = default(VectorOffset), bool isopend = false, long opencompletetime = 0L, int level = 0, int exp = 0, long companyendtime = 0L, VectorOffset employeesOffset = default(VectorOffset), long maintenancetime = 0L, bool inmaintenance = false, bool inrepair = false, long lastrepairtime = 0L, int manager = 0, bool onnegotiation = false)
		{
			return default(Offset<OfficeData>);
		}

		public static void StartOfficeData(FlatBufferBuilder builder)
		{
		}

		public static void AddOffice(FlatBufferBuilder builder, int office)
		{
		}

		public static void AddCompany(FlatBufferBuilder builder, int company)
		{
		}

		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
		}

		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<OfficeItemData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<OfficeItemData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OfficeItemData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddIsopend(FlatBufferBuilder builder, bool isopend)
		{
		}

		public static void AddOpencompletetime(FlatBufferBuilder builder, long opencompletetime)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddExp(FlatBufferBuilder builder, int exp)
		{
		}

		public static void AddCompanyendtime(FlatBufferBuilder builder, long companyendtime)
		{
		}

		public static void AddEmployees(FlatBufferBuilder builder, VectorOffset employeesOffset)
		{
		}

		public static VectorOffset CreateEmployeesVector(FlatBufferBuilder builder, Offset<EmployeeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEmployeesVectorBlock(FlatBufferBuilder builder, Offset<EmployeeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEmployeesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<EmployeeData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEmployeesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartEmployeesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddMaintenancetime(FlatBufferBuilder builder, long maintenancetime)
		{
		}

		public static void AddInmaintenance(FlatBufferBuilder builder, bool inmaintenance)
		{
		}

		public static void AddInrepair(FlatBufferBuilder builder, bool inrepair)
		{
		}

		public static void AddLastrepairtime(FlatBufferBuilder builder, long lastrepairtime)
		{
		}

		public static void AddManager(FlatBufferBuilder builder, int manager)
		{
		}

		public static void AddOnnegotiation(FlatBufferBuilder builder, bool onnegotiation)
		{
		}

		public static Offset<OfficeData> EndOfficeData(FlatBufferBuilder builder)
		{
			return default(Offset<OfficeData>);
		}

		public OfficeDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(OfficeDataT _o)
		{
		}

		public static Offset<OfficeData> Pack(FlatBufferBuilder builder, OfficeDataT _o)
		{
			return default(Offset<OfficeData>);
		}
	}
}
