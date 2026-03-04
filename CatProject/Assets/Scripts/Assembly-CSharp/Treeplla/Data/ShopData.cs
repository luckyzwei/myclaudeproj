using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ShopData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int FreeitemtimesLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Piggyvalue { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int PackagesLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int ExpirepackageLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Piggylevel { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int PiggyrewardLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Noadssaleend { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Playerlvpasssaleend { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int ShopsalepackagetimesLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int CyclelimitedshopgoodsLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int EndlessofferdataLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static ShopData GetRootAsShopData(ByteBuffer _bb)
		{
			return GetRootAsShopData(_bb, new ShopData());
		}

		public static ShopData GetRootAsShopData(ByteBuffer _bb, ShopData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public ShopData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public KeyValueLong? Freeitemtimes(int j)
		{
			int o = __p.__offset(4);
			return o != 0 ? (new KeyValueLong()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutatePiggyvalue(int piggyvalue)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, piggyvalue);
				return true;
			}
			return false;
		}

		public PackageData? Packages(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new PackageData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public int Expirepackage(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetExpirepackageBytes()
		{
			return __p.__vector_as_arraysegment(30);
		}

		public int[] GetExpirepackageArray()
		{
			return null;
		}

		public bool MutateExpirepackage(int j, int expirepackage)
		{
			return false;
		}

		public bool MutatePiggylevel(int piggylevel)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, piggylevel);
				return true;
			}
			return false;
		}

		public int Piggyreward(int j)
		{
			int o = __p.__offset(14);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetPiggyrewardBytes()
		{
			return __p.__vector_as_arraysegment(32);
		}

		public int[] GetPiggyrewardArray()
		{
			return null;
		}

		public bool MutatePiggyreward(int j, int piggyreward)
		{
			return false;
		}

		public bool MutateNoadssaleend(long noadssaleend)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, noadssaleend);
				return true;
			}
			return false;
		}

		public bool MutatePlayerlvpasssaleend(long playerlvpasssaleend)
		{
			int o = __p.__offset(18);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, playerlvpasssaleend);
				return true;
			}
			return false;
		}

		public KeyValueLong? Shopsalepackagetimes(int j)
		{
			int o = __p.__offset(20);
			return o != 0 ? (new KeyValueLong()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public CycleLimitedShopGoods? Cyclelimitedshopgoods(int j)
		{
			int o = __p.__offset(22);
			return o != 0 ? (new CycleLimitedShopGoods()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public EndlessOfferData? Endlessofferdata(int j)
		{
			int o = __p.__offset(24);
			return o != 0 ? (new EndlessOfferData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<ShopData> CreateShopData(FlatBufferBuilder builder, VectorOffset freeitemtimesOffset = default(VectorOffset), int piggyvalue = 0, VectorOffset packagesOffset = default(VectorOffset), VectorOffset expirepackageOffset = default(VectorOffset), int piggylevel = 1, VectorOffset piggyrewardOffset = default(VectorOffset), long noadssaleend = 0L, long playerlvpasssaleend = 0L, VectorOffset shopsalepackagetimesOffset = default(VectorOffset), VectorOffset cyclelimitedshopgoodsOffset = default(VectorOffset), VectorOffset endlessofferdataOffset = default(VectorOffset))
		{
			builder.StartTable(11);
			AddEndlessofferdata(builder, endlessofferdataOffset);
			AddCyclelimitedshopgoods(builder, cyclelimitedshopgoodsOffset);
			AddShopsalepackagetimes(builder, shopsalepackagetimesOffset);
			AddPlayerlvpasssaleend(builder, playerlvpasssaleend);
			AddNoadssaleend(builder, noadssaleend);
			AddPiggyreward(builder, piggyrewardOffset);
			AddPiggylevel(builder, piggylevel);
			AddExpirepackage(builder, expirepackageOffset);
			AddPackages(builder, packagesOffset);
			AddPiggyvalue(builder, piggyvalue);
			AddFreeitemtimes(builder, freeitemtimesOffset);
			return EndShopData(builder);
		}

		public static void StartShopData(FlatBufferBuilder builder)
		{
			builder.StartTable(18);
		}

		public static void AddFreeitemtimes(FlatBufferBuilder builder, VectorOffset freeitemtimesOffset)
		{
			builder.AddOffset(0, freeitemtimesOffset.Value, 0);
		}

		public static VectorOffset CreateFreeitemtimesVector(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateFreeitemtimesVectorBlock(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateFreeitemtimesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValueLong>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateFreeitemtimesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartFreeitemtimesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddPiggyvalue(FlatBufferBuilder builder, int piggyvalue)
		{
			builder.AddInt(1, piggyvalue, 0);
		}

		public static void AddPackages(FlatBufferBuilder builder, VectorOffset packagesOffset)
		{
			builder.AddOffset(2, packagesOffset.Value, 0);
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
			builder.AddOffset(3, expirepackageOffset.Value, 0);
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

		public static void AddPiggylevel(FlatBufferBuilder builder, int piggylevel)
		{
			builder.AddInt(4, piggylevel, 0);
		}

		public static void AddPiggyreward(FlatBufferBuilder builder, VectorOffset piggyrewardOffset)
		{
			builder.AddOffset(5, piggyrewardOffset.Value, 0);
		}

		public static VectorOffset CreatePiggyrewardVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreatePiggyrewardVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePiggyrewardVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePiggyrewardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartPiggyrewardVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddNoadssaleend(FlatBufferBuilder builder, long noadssaleend)
		{
			builder.AddLong(6, noadssaleend, 0);
		}

		public static void AddPlayerlvpasssaleend(FlatBufferBuilder builder, long playerlvpasssaleend)
		{
			builder.AddLong(7, playerlvpasssaleend, 0);
		}

		public static void AddShopsalepackagetimes(FlatBufferBuilder builder, VectorOffset shopsalepackagetimesOffset)
		{
			builder.AddOffset(8, shopsalepackagetimesOffset.Value, 0);
		}

		public static VectorOffset CreateShopsalepackagetimesVector(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateShopsalepackagetimesVectorBlock(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateShopsalepackagetimesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValueLong>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateShopsalepackagetimesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartShopsalepackagetimesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddCyclelimitedshopgoods(FlatBufferBuilder builder, VectorOffset cyclelimitedshopgoodsOffset)
		{
			builder.AddOffset(9, cyclelimitedshopgoodsOffset.Value, 0);
		}

		public static VectorOffset CreateCyclelimitedshopgoodsVector(FlatBufferBuilder builder, Offset<CycleLimitedShopGoods>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCyclelimitedshopgoodsVectorBlock(FlatBufferBuilder builder, Offset<CycleLimitedShopGoods>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCyclelimitedshopgoodsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CycleLimitedShopGoods>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCyclelimitedshopgoodsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCyclelimitedshopgoodsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddEndlessofferdata(FlatBufferBuilder builder, VectorOffset endlessofferdataOffset)
		{
			builder.AddOffset(10, endlessofferdataOffset.Value, 0);
		}

		public static VectorOffset CreateEndlessofferdataVector(FlatBufferBuilder builder, Offset<EndlessOfferData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateEndlessofferdataVectorBlock(FlatBufferBuilder builder, Offset<EndlessOfferData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateEndlessofferdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<EndlessOfferData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateEndlessofferdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartEndlessofferdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<ShopData> EndShopData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<ShopData>(o);
		}

		public ShopDataT UnPack()
		{
			var _o = new ShopDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(ShopDataT _o)
		{
			_o.Freeitemtimes = new List<KeyValueLongT>();
			for (var _j = 0; _j < this.FreeitemtimesLength; ++_j)
				_o.Freeitemtimes.Add(this.Freeitemtimes(_j).HasValue ? this.Freeitemtimes(_j).Value.UnPack() : null);
			_o.Piggyvalue = this.Piggyvalue;
			_o.Packages = new List<PackageDataT>();
			for (var _j = 0; _j < this.PackagesLength; ++_j)
				_o.Packages.Add(this.Packages(_j).HasValue ? this.Packages(_j).Value.UnPack() : null);
			_o.Expirepackage = new List<int>();
			for (var _j = 0; _j < this.ExpirepackageLength; ++_j)
				_o.Expirepackage.Add(this.Expirepackage(_j));
			_o.Piggylevel = this.Piggylevel;
			_o.Piggyreward = new List<int>();
			for (var _j = 0; _j < this.PiggyrewardLength; ++_j)
				_o.Piggyreward.Add(this.Piggyreward(_j));
			_o.Noadssaleend = this.Noadssaleend;
			_o.Playerlvpasssaleend = this.Playerlvpasssaleend;
			_o.Shopsalepackagetimes = new List<KeyValueLongT>();
			for (var _j = 0; _j < this.ShopsalepackagetimesLength; ++_j)
				_o.Shopsalepackagetimes.Add(this.Shopsalepackagetimes(_j).HasValue ? this.Shopsalepackagetimes(_j).Value.UnPack() : null);
			_o.Cyclelimitedshopgoods = new List<CycleLimitedShopGoodsT>();
			for (var _j = 0; _j < this.CyclelimitedshopgoodsLength; ++_j)
				_o.Cyclelimitedshopgoods.Add(this.Cyclelimitedshopgoods(_j).HasValue ? this.Cyclelimitedshopgoods(_j).Value.UnPack() : null);
			_o.Endlessofferdata = new List<EndlessOfferDataT>();
			for (var _j = 0; _j < this.EndlessofferdataLength; ++_j)
				_o.Endlessofferdata.Add(this.Endlessofferdata(_j).HasValue ? this.Endlessofferdata(_j).Value.UnPack() : null);
		}

		public static Offset<ShopData> Pack(FlatBufferBuilder builder, ShopDataT _o)
		{
			if (_o == null) return default(Offset<ShopData>);
			var _freeitemtimes = default(VectorOffset);
			if (_o.Freeitemtimes != null)
			{
				var __freeitemtimes = new Offset<KeyValueLong>[_o.Freeitemtimes.Count];
				for (var _j = 0; _j < _o.Freeitemtimes.Count; ++_j)
					__freeitemtimes[_j] = KeyValueLong.Pack(builder, _o.Freeitemtimes[_j]);
				_freeitemtimes = CreateFreeitemtimesVector(builder, __freeitemtimes);
			}
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
			var _piggyreward = default(VectorOffset);
			if (_o.Piggyreward != null)
			{
				var __piggyreward = _o.Piggyreward.ToArray();
				_piggyreward = CreatePiggyrewardVector(builder, __piggyreward);
			}
			var _shopsalepackagetimes = default(VectorOffset);
			if (_o.Shopsalepackagetimes != null)
			{
				var __shopsalepackagetimes = new Offset<KeyValueLong>[_o.Shopsalepackagetimes.Count];
				for (var _j = 0; _j < _o.Shopsalepackagetimes.Count; ++_j)
					__shopsalepackagetimes[_j] = KeyValueLong.Pack(builder, _o.Shopsalepackagetimes[_j]);
				_shopsalepackagetimes = CreateShopsalepackagetimesVector(builder, __shopsalepackagetimes);
			}
			var _cyclelimitedshopgoods = default(VectorOffset);
			if (_o.Cyclelimitedshopgoods != null)
			{
				var __cyclelimitedshopgoods = new Offset<CycleLimitedShopGoods>[_o.Cyclelimitedshopgoods.Count];
				for (var _j = 0; _j < _o.Cyclelimitedshopgoods.Count; ++_j)
					__cyclelimitedshopgoods[_j] = CycleLimitedShopGoods.Pack(builder, _o.Cyclelimitedshopgoods[_j]);
				_cyclelimitedshopgoods = CreateCyclelimitedshopgoodsVector(builder, __cyclelimitedshopgoods);
			}
			var _endlessofferdata = default(VectorOffset);
			if (_o.Endlessofferdata != null)
			{
				var __endlessofferdata = new Offset<EndlessOfferData>[_o.Endlessofferdata.Count];
				for (var _j = 0; _j < _o.Endlessofferdata.Count; ++_j)
					__endlessofferdata[_j] = EndlessOfferData.Pack(builder, _o.Endlessofferdata[_j]);
				_endlessofferdata = CreateEndlessofferdataVector(builder, __endlessofferdata);
			}
			StartShopData(builder);
			AddFreeitemtimes(builder, _freeitemtimes);
			AddPiggyvalue(builder, _o.Piggyvalue);
			AddPackages(builder, _packages);
			AddExpirepackage(builder, _expirepackage);
			AddPiggylevel(builder, _o.Piggylevel);
			AddPiggyreward(builder, _piggyreward);
			AddNoadssaleend(builder, _o.Noadssaleend);
			AddPlayerlvpasssaleend(builder, _o.Playerlvpasssaleend);
			AddShopsalepackagetimes(builder, _shopsalepackagetimes);
			AddCyclelimitedshopgoods(builder, _cyclelimitedshopgoods);
			AddEndlessofferdata(builder, _endlessofferdata);
			return EndShopData(builder);
		}
	}
}
