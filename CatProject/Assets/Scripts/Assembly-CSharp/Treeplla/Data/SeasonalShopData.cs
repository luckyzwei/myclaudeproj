using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalShopData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Seasoninfoidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Statueactive { get { int o = __p.__offset(6); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public long Statuebuytime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Statueslotcount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Piggyvalue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int PackagesLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int ExpirepackageLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Buildingslotactive { get { int o = __p.__offset(18); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int ViewpackageLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Premiumpassactive { get { int o = __p.__offset(22); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalShopData GetRootAsSeasonalShopData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalShopData(_bb, new SeasonalShopData());
		}

		public static SeasonalShopData GetRootAsSeasonalShopData(ByteBuffer _bb, SeasonalShopData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalShopData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSeasoninfoidx(int seasoninfoidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, seasoninfoidx);
				return true;
			}
			return false;
		}

		public bool MutateStatueactive(bool statueactive)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(statueactive ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateStatuebuytime(long statuebuytime)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, statuebuytime);
				return true;
			}
			return false;
		}

		public bool MutateStatueslotcount(int statueslotcount)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, statueslotcount);
				return true;
			}
			return false;
		}

		public bool MutatePiggyvalue(int piggyvalue)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, piggyvalue);
				return true;
			}
			return false;
		}

		public PackageData? Packages(int j)
		{
			int o = __p.__offset(14);
			return o != 0 ? (new PackageData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public int Expirepackage(int j)
		{
			int o = __p.__offset(16);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetExpirepackageBytes()
		{
			return __p.__vector_as_arraysegment(26);
		}

		public int[] GetExpirepackageArray()
		{
			return null;
		}

		public bool MutateExpirepackage(int j, int expirepackage)
		{
			return false;
		}

		public bool MutateBuildingslotactive(bool buildingslotactive)
		{
			int o = __p.__offset(18);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(buildingslotactive ? 1 : 0));
				return true;
			}
			return false;
		}

		public int Viewpackage(int j)
		{
			int o = __p.__offset(20);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetViewpackageBytes()
		{
			return __p.__vector_as_arraysegment(28);
		}

		public int[] GetViewpackageArray()
		{
			return null;
		}

		public bool MutateViewpackage(int j, int viewpackage)
		{
			return false;
		}

		public bool MutatePremiumpassactive(bool premiumpassactive)
		{
			int o = __p.__offset(22);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(premiumpassactive ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<SeasonalShopData> CreateSeasonalShopData(FlatBufferBuilder builder, int seasoninfoidx = 0, bool statueactive = false, long statuebuytime = 0L, int statueslotcount = 0, int piggyvalue = 0, VectorOffset packagesOffset = default(VectorOffset), VectorOffset expirepackageOffset = default(VectorOffset), bool buildingslotactive = false, VectorOffset viewpackageOffset = default(VectorOffset), bool premiumpassactive = false)
		{
			builder.StartTable(10);
			AddPremiumpassactive(builder, premiumpassactive);
			AddViewpackage(builder, viewpackageOffset);
			AddBuildingslotactive(builder, buildingslotactive);
			AddExpirepackage(builder, expirepackageOffset);
			AddPackages(builder, packagesOffset);
			AddPiggyvalue(builder, piggyvalue);
			AddStatueslotcount(builder, statueslotcount);
			AddStatuebuytime(builder, statuebuytime);
			AddStatueactive(builder, statueactive);
			AddSeasoninfoidx(builder, seasoninfoidx);
			return EndSeasonalShopData(builder);
		}

		public static void StartSeasonalShopData(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		public static void AddSeasoninfoidx(FlatBufferBuilder builder, int seasoninfoidx)
		{
			builder.AddInt(0, seasoninfoidx, 0);
		}

		public static void AddStatueactive(FlatBufferBuilder builder, bool statueactive)
		{
			builder.AddBool(1, statueactive, false);
		}

		public static void AddStatuebuytime(FlatBufferBuilder builder, long statuebuytime)
		{
			builder.AddLong(2, statuebuytime, 0);
		}

		public static void AddStatueslotcount(FlatBufferBuilder builder, int statueslotcount)
		{
			builder.AddInt(3, statueslotcount, 0);
		}

		public static void AddPiggyvalue(FlatBufferBuilder builder, int piggyvalue)
		{
			builder.AddInt(4, piggyvalue, 0);
		}

		public static void AddPackages(FlatBufferBuilder builder, VectorOffset packagesOffset)
		{
			builder.AddOffset(5, packagesOffset.Value, 0);
		}

		public static VectorOffset CreatePackagesVector(FlatBufferBuilder builder, Offset<PackageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreatePackagesVectorBlock(FlatBufferBuilder builder, Offset<PackageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreatePackagesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<PackageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreatePackagesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartPackagesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddExpirepackage(FlatBufferBuilder builder, VectorOffset expirepackageOffset)
		{
			builder.AddOffset(6, expirepackageOffset.Value, 0);
		}

		public static VectorOffset CreateExpirepackageVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateExpirepackageVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateExpirepackageVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateExpirepackageVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartExpirepackageVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddBuildingslotactive(FlatBufferBuilder builder, bool buildingslotactive)
		{
			builder.AddBool(7, buildingslotactive, false);
		}

		public static void AddViewpackage(FlatBufferBuilder builder, VectorOffset viewpackageOffset)
		{
			builder.AddOffset(8, viewpackageOffset.Value, 0);
		}

		public static VectorOffset CreateViewpackageVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateViewpackageVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateViewpackageVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateViewpackageVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartViewpackageVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddPremiumpassactive(FlatBufferBuilder builder, bool premiumpassactive)
		{
			builder.AddBool(9, premiumpassactive, false);
		}

		public static Offset<SeasonalShopData> EndSeasonalShopData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalShopData>(o);
		}

		public SeasonalShopDataT UnPack()
		{
			var _o = new SeasonalShopDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalShopDataT _o)
		{
			_o.Seasoninfoidx = this.Seasoninfoidx;
			_o.Statueactive = this.Statueactive;
			_o.Statuebuytime = this.Statuebuytime;
			_o.Statueslotcount = this.Statueslotcount;
			_o.Piggyvalue = this.Piggyvalue;
			_o.Packages = new List<PackageDataT>();
			for (var _j = 0; _j < this.PackagesLength; ++_j)
				_o.Packages.Add(this.Packages(_j).HasValue ? this.Packages(_j).Value.UnPack() : null);
			_o.Expirepackage = new List<int>();
			for (var _j = 0; _j < this.ExpirepackageLength; ++_j)
				_o.Expirepackage.Add(this.Expirepackage(_j));
			_o.Buildingslotactive = this.Buildingslotactive;
			_o.Viewpackage = new List<int>();
			for (var _j = 0; _j < this.ViewpackageLength; ++_j)
				_o.Viewpackage.Add(this.Viewpackage(_j));
			_o.Premiumpassactive = this.Premiumpassactive;
		}

		public static Offset<SeasonalShopData> Pack(FlatBufferBuilder builder, SeasonalShopDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalShopData>);
			var _packages = default(VectorOffset);
			if (_o.Packages != null)
			{
				var __packages = new Offset<PackageData>[_o.Packages.Count];
				for (var _j = 0; _j < _o.Packages.Count; ++_j)
					__packages[_j] = PackageData.Pack(builder, _o.Packages[_j]);
				_packages = CreatePackagesVector(builder, __packages);
			}
			var _expirepackage = default(VectorOffset);
			if (_o.Expirepackage != null)
			{
				var __expirepackage = _o.Expirepackage.ToArray();
				_expirepackage = CreateExpirepackageVector(builder, __expirepackage);
			}
			var _viewpackage = default(VectorOffset);
			if (_o.Viewpackage != null)
			{
				var __viewpackage = _o.Viewpackage.ToArray();
				_viewpackage = CreateViewpackageVector(builder, __viewpackage);
			}
			StartSeasonalShopData(builder);
			AddSeasoninfoidx(builder, _o.Seasoninfoidx);
			AddStatueactive(builder, _o.Statueactive);
			AddStatuebuytime(builder, _o.Statuebuytime);
			AddStatueslotcount(builder, _o.Statueslotcount);
			AddPiggyvalue(builder, _o.Piggyvalue);
			AddPackages(builder, _packages);
			AddExpirepackage(builder, _expirepackage);
			AddBuildingslotactive(builder, _o.Buildingslotactive);
			AddViewpackage(builder, _viewpackage);
			AddPremiumpassactive(builder, _o.Premiumpassactive);
			return EndSeasonalShopData(builder);
		}
	}
}
