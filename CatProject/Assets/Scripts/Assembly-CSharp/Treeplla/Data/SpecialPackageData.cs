using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SpecialPackageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Expire { get { int o = __p.__offset(6); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int ParamLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Purchase { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public long Limitttime { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int PackageofferdataLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SpecialPackageData GetRootAsSpecialPackageData(ByteBuffer _bb)
		{
			return GetRootAsSpecialPackageData(_bb, new SpecialPackageData());
		}

		public static SpecialPackageData GetRootAsSpecialPackageData(ByteBuffer _bb, SpecialPackageData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SpecialPackageData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIdx(int idx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, idx);
				return true;
			}
			return false;
		}

		public bool MutateExpire(bool expire)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(expire ? 1 : 0));
				return true;
			}
			return false;
		}

		public int Param(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetParamBytes()
		{
			return __p.__vector_as_arraysegment(16);
		}

		public int[] GetParamArray()
		{
			return null;
		}

		public bool MutateParam(int j, int param)
		{
			return false;
		}

		public bool MutatePurchase(bool purchase)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(purchase ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateLimitttime(long limitttime)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, limitttime);
				return true;
			}
			return false;
		}

		public PackageOfferData? Packageofferdata(int j)
		{
			int o = __p.__offset(14);
			return o != 0 ? (new PackageOfferData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<SpecialPackageData> CreateSpecialPackageData(FlatBufferBuilder builder, int idx = 0, bool expire = false, VectorOffset paramOffset = default(VectorOffset), bool purchase = false, long limitttime = 0L, VectorOffset packageofferdataOffset = default(VectorOffset))
		{
			builder.StartTable(6);
			AddPackageofferdata(builder, packageofferdataOffset);
			AddLimitttime(builder, limitttime);
			AddPurchase(builder, purchase);
			AddParam(builder, paramOffset);
			AddExpire(builder, expire);
			AddIdx(builder, idx);
			return EndSpecialPackageData(builder);
		}

		public static void StartSpecialPackageData(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddExpire(FlatBufferBuilder builder, bool expire)
		{
			builder.AddBool(1, expire, false);
		}

		public static void AddParam(FlatBufferBuilder builder, VectorOffset paramOffset)
		{
			builder.AddOffset(2, paramOffset.Value, 0);
		}

		public static VectorOffset CreateParamVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateParamVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateParamVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateParamVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartParamVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddPurchase(FlatBufferBuilder builder, bool purchase)
		{
			builder.AddBool(3, purchase, false);
		}

		public static void AddLimitttime(FlatBufferBuilder builder, long limitttime)
		{
			builder.AddLong(4, limitttime, 0);
		}

		public static void AddPackageofferdata(FlatBufferBuilder builder, VectorOffset packageofferdataOffset)
		{
			builder.AddOffset(5, packageofferdataOffset.Value, 0);
		}

		public static VectorOffset CreatePackageofferdataVector(FlatBufferBuilder builder, Offset<PackageOfferData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreatePackageofferdataVectorBlock(FlatBufferBuilder builder, Offset<PackageOfferData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreatePackageofferdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<PackageOfferData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreatePackageofferdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartPackageofferdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<SpecialPackageData> EndSpecialPackageData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SpecialPackageData>(o);
		}

		public SpecialPackageDataT UnPack()
		{
			var _o = new SpecialPackageDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SpecialPackageDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Expire = this.Expire;
			_o.Param = new List<int>();
			for (var _j = 0; _j < this.ParamLength; ++_j)
				_o.Param.Add(this.Param(_j));
			_o.Purchase = this.Purchase;
			_o.Limitttime = this.Limitttime;
			_o.Packageofferdata = new List<PackageOfferDataT>();
			for (var _j = 0; _j < this.PackageofferdataLength; ++_j)
				_o.Packageofferdata.Add(this.Packageofferdata(_j).HasValue ? this.Packageofferdata(_j).Value.UnPack() : null);
		}

		public static Offset<SpecialPackageData> Pack(FlatBufferBuilder builder, SpecialPackageDataT _o)
		{
			if (_o == null) return default(Offset<SpecialPackageData>);
			var _param = default(VectorOffset);
			if (_o.Param != null)
			{
				var __param = _o.Param.ToArray();
				_param = CreateParamVector(builder, __param);
			}
			var _packageofferdata = default(VectorOffset);
			if (_o.Packageofferdata != null)
			{
				var __packageofferdata = new Offset<PackageOfferData>[_o.Packageofferdata.Count];
				for (var _j = 0; _j < _o.Packageofferdata.Count; ++_j)
					__packageofferdata[_j] = PackageOfferData.Pack(builder, _o.Packageofferdata[_j]);
				_packageofferdata = CreatePackageofferdataVector(builder, __packageofferdata);
			}
			StartSpecialPackageData(builder);
			AddIdx(builder, _o.Idx);
			AddExpire(builder, _o.Expire);
			AddParam(builder, _param);
			AddPurchase(builder, _o.Purchase);
			AddLimitttime(builder, _o.Limitttime);
			AddPackageofferdata(builder, _packageofferdata);
			return EndSpecialPackageData(builder);
		}
	}
}
