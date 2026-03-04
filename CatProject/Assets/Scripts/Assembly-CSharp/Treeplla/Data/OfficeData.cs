using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OfficeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Office { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Company { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int ItemsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Isopend { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public long Opencompletetime { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Level { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Exp { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Companyendtime { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int EmployeesLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Maintenancetime { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public bool Inmaintenance { get { int o = __p.__offset(24); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Inrepair { get { int o = __p.__offset(26); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public long Lastrepairtime { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Manager { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Onnegotiation { get { int o = __p.__offset(32); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static OfficeData GetRootAsOfficeData(ByteBuffer _bb)
		{
			return GetRootAsOfficeData(_bb, new OfficeData());
		}

		public static OfficeData GetRootAsOfficeData(ByteBuffer _bb, OfficeData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public OfficeData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateOffice(int office)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, office);
				return true;
			}
			return false;
		}

		public bool MutateCompany(int company)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, company);
				return true;
			}
			return false;
		}

		public OfficeItemData? Items(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new OfficeItemData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateIsopend(bool isopend)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isopend ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateOpencompletetime(long opencompletetime)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, opencompletetime);
				return true;
			}
			return false;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public bool MutateExp(int exp)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, exp);
				return true;
			}
			return false;
		}

		public bool MutateCompanyendtime(long companyendtime)
		{
			int o = __p.__offset(18);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, companyendtime);
				return true;
			}
			return false;
		}

		public EmployeeData? Employees(int j)
		{
			int o = __p.__offset(20);
			return o != 0 ? (new EmployeeData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateMaintenancetime(long maintenancetime)
		{
			int o = __p.__offset(22);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, maintenancetime);
				return true;
			}
			return false;
		}

		public bool MutateInmaintenance(bool inmaintenance)
		{
			int o = __p.__offset(24);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(inmaintenance ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateInrepair(bool inrepair)
		{
			int o = __p.__offset(26);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(inrepair ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateLastrepairtime(long lastrepairtime)
		{
			int o = __p.__offset(28);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastrepairtime);
				return true;
			}
			return false;
		}

		public bool MutateManager(int manager)
		{
			int o = __p.__offset(30);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, manager);
				return true;
			}
			return false;
		}

		public bool MutateOnnegotiation(bool onnegotiation)
		{
			int o = __p.__offset(32);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(onnegotiation ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<OfficeData> CreateOfficeData(FlatBufferBuilder builder, int office = 0, int company = 0, VectorOffset itemsOffset = default(VectorOffset), bool isopend = false, long opencompletetime = 0L, int level = 0, int exp = 0, long companyendtime = 0L, VectorOffset employeesOffset = default(VectorOffset), long maintenancetime = 0L, bool inmaintenance = false, bool inrepair = false, long lastrepairtime = 0L, int manager = 0, bool onnegotiation = false)
		{
			builder.StartTable(15);
			AddOnnegotiation(builder, onnegotiation);
			AddManager(builder, manager);
			AddLastrepairtime(builder, lastrepairtime);
			AddInrepair(builder, inrepair);
			AddInmaintenance(builder, inmaintenance);
			AddMaintenancetime(builder, maintenancetime);
			AddEmployees(builder, employeesOffset);
			AddCompanyendtime(builder, companyendtime);
			AddExp(builder, exp);
			AddLevel(builder, level);
			AddOpencompletetime(builder, opencompletetime);
			AddIsopend(builder, isopend);
			AddItems(builder, itemsOffset);
			AddCompany(builder, company);
			AddOffice(builder, office);
			return EndOfficeData(builder);
		}

		public static void StartOfficeData(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		public static void AddOffice(FlatBufferBuilder builder, int office)
		{
			builder.AddInt(0, office, 0);
		}

		public static void AddCompany(FlatBufferBuilder builder, int company)
		{
			builder.AddInt(1, company, 0);
		}

		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(2, itemsOffset.Value, 0);
		}

		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<OfficeItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<OfficeItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OfficeItemData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddIsopend(FlatBufferBuilder builder, bool isopend)
		{
			builder.AddBool(3, isopend, false);
		}

		public static void AddOpencompletetime(FlatBufferBuilder builder, long opencompletetime)
		{
			builder.AddLong(4, opencompletetime, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(5, level, 0);
		}

		public static void AddExp(FlatBufferBuilder builder, int exp)
		{
			builder.AddInt(6, exp, 0);
		}

		public static void AddCompanyendtime(FlatBufferBuilder builder, long companyendtime)
		{
			builder.AddLong(7, companyendtime, 0);
		}

		public static void AddEmployees(FlatBufferBuilder builder, VectorOffset employeesOffset)
		{
			builder.AddOffset(8, employeesOffset.Value, 0);
		}

		public static VectorOffset CreateEmployeesVector(FlatBufferBuilder builder, Offset<EmployeeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateEmployeesVectorBlock(FlatBufferBuilder builder, Offset<EmployeeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateEmployeesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<EmployeeData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateEmployeesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartEmployeesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMaintenancetime(FlatBufferBuilder builder, long maintenancetime)
		{
			builder.AddLong(9, maintenancetime, 0);
		}

		public static void AddInmaintenance(FlatBufferBuilder builder, bool inmaintenance)
		{
			builder.AddBool(10, inmaintenance, false);
		}

		public static void AddInrepair(FlatBufferBuilder builder, bool inrepair)
		{
			builder.AddBool(11, inrepair, false);
		}

		public static void AddLastrepairtime(FlatBufferBuilder builder, long lastrepairtime)
		{
			builder.AddLong(12, lastrepairtime, 0);
		}

		public static void AddManager(FlatBufferBuilder builder, int manager)
		{
			builder.AddInt(13, manager, 0);
		}

		public static void AddOnnegotiation(FlatBufferBuilder builder, bool onnegotiation)
		{
			builder.AddBool(14, onnegotiation, false);
		}

		public static Offset<OfficeData> EndOfficeData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<OfficeData>(o);
		}

		public OfficeDataT UnPack()
		{
			var _o = new OfficeDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(OfficeDataT _o)
		{
			_o.Office = this.Office;
			_o.Company = this.Company;
			_o.Items = new List<OfficeItemDataT>();
			for (var _j = 0; _j < this.ItemsLength; ++_j)
				_o.Items.Add(this.Items(_j).HasValue ? this.Items(_j).Value.UnPack() : null);
			_o.Isopend = this.Isopend;
			_o.Opencompletetime = this.Opencompletetime;
			_o.Level = this.Level;
			_o.Exp = this.Exp;
			_o.Companyendtime = this.Companyendtime;
			_o.Employees = new List<EmployeeDataT>();
			for (var _j = 0; _j < this.EmployeesLength; ++_j)
				_o.Employees.Add(this.Employees(_j).HasValue ? this.Employees(_j).Value.UnPack() : null);
			_o.Maintenancetime = this.Maintenancetime;
			_o.Inmaintenance = this.Inmaintenance;
			_o.Inrepair = this.Inrepair;
			_o.Lastrepairtime = this.Lastrepairtime;
			_o.Manager = this.Manager;
			_o.Onnegotiation = this.Onnegotiation;
		}

		public static Offset<OfficeData> Pack(FlatBufferBuilder builder, OfficeDataT _o)
		{
			if (_o == null) return default(Offset<OfficeData>);
			var _items = default(VectorOffset);
			if (_o.Items != null)
			{
				var __items = new Offset<OfficeItemData>[_o.Items.Count];
				for (var _j = 0; _j < _o.Items.Count; ++_j)
					__items[_j] = OfficeItemData.Pack(builder, _o.Items[_j]);
				_items = CreateItemsVector(builder, __items);
			}
			var _employees = default(VectorOffset);
			if (_o.Employees != null)
			{
				var __employees = new Offset<EmployeeData>[_o.Employees.Count];
				for (var _j = 0; _j < _o.Employees.Count; ++_j)
					__employees[_j] = EmployeeData.Pack(builder, _o.Employees[_j]);
				_employees = CreateEmployeesVector(builder, __employees);
			}
			StartOfficeData(builder);
			AddOffice(builder, _o.Office);
			AddCompany(builder, _o.Company);
			AddItems(builder, _items);
			AddIsopend(builder, _o.Isopend);
			AddOpencompletetime(builder, _o.Opencompletetime);
			AddLevel(builder, _o.Level);
			AddExp(builder, _o.Exp);
			AddCompanyendtime(builder, _o.Companyendtime);
			AddEmployees(builder, _employees);
			AddMaintenancetime(builder, _o.Maintenancetime);
			AddInmaintenance(builder, _o.Inmaintenance);
			AddInrepair(builder, _o.Inrepair);
			AddLastrepairtime(builder, _o.Lastrepairtime);
			AddManager(builder, _o.Manager);
			AddOnnegotiation(builder, _o.Onnegotiation);
			return EndOfficeData(builder);
		}
	}
}
