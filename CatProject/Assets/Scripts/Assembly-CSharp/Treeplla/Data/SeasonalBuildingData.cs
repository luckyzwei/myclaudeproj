using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalBuildingData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Buildingidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Constructioncompletetimeticks { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public bool Needcompletenotice { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Isopen { get { int o = __p.__offset(12); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Isconstruction { get { int o = __p.__offset(14); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int FacilitydataLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

		public SeasonalBuildingWorkerData? Workerdata { get { int o = __p.__offset(18); return o != 0 ? (new SeasonalBuildingWorkerData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public SeasonalWorkshopManagerData? Managerdata { get { int o = __p.__offset(20); return o != 0 ? (new SeasonalWorkshopManagerData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalBuildingData GetRootAsSeasonalBuildingData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalBuildingData(_bb, new SeasonalBuildingData());
		}

		public static SeasonalBuildingData GetRootAsSeasonalBuildingData(ByteBuffer _bb, SeasonalBuildingData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalBuildingData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateBuildingidx(int buildingidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, buildingidx);
				return true;
			}
			return false;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public bool MutateConstructioncompletetimeticks(long constructioncompletetimeticks)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, constructioncompletetimeticks);
				return true;
			}
			return false;
		}

		public bool MutateNeedcompletenotice(bool needcompletenotice)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(needcompletenotice ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateIsopen(bool isopen)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isopen ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateIsconstruction(bool isconstruction)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isconstruction ? 1 : 0));
				return true;
			}
			return false;
		}

		public SeasonalBuildingFacilityData? Facilitydata(int j)
		{
			int o = __p.__offset(16);
			return o != 0 ? (new SeasonalBuildingFacilityData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<SeasonalBuildingData> CreateSeasonalBuildingData(FlatBufferBuilder builder, int buildingidx = 0, int level = 0, long constructioncompletetimeticks = 0L, bool needcompletenotice = false, bool isopen = false, bool isconstruction = false, VectorOffset facilitydataOffset = default(VectorOffset), Offset<SeasonalBuildingWorkerData> workerdataOffset = default(Offset<SeasonalBuildingWorkerData>), Offset<SeasonalWorkshopManagerData> managerdataOffset = default(Offset<SeasonalWorkshopManagerData>))
		{
			builder.StartTable(9);
			AddManagerdata(builder, managerdataOffset);
			AddWorkerdata(builder, workerdataOffset);
			AddFacilitydata(builder, facilitydataOffset);
			AddIsconstruction(builder, isconstruction);
			AddIsopen(builder, isopen);
			AddNeedcompletenotice(builder, needcompletenotice);
			AddConstructioncompletetimeticks(builder, constructioncompletetimeticks);
			AddLevel(builder, level);
			AddBuildingidx(builder, buildingidx);
			return EndSeasonalBuildingData(builder);
		}

		public static void StartSeasonalBuildingData(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		public static void AddBuildingidx(FlatBufferBuilder builder, int buildingidx)
		{
			builder.AddInt(0, buildingidx, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static void AddConstructioncompletetimeticks(FlatBufferBuilder builder, long constructioncompletetimeticks)
		{
			builder.AddLong(2, constructioncompletetimeticks, 0);
		}

		public static void AddNeedcompletenotice(FlatBufferBuilder builder, bool needcompletenotice)
		{
			builder.AddBool(3, needcompletenotice, false);
		}

		public static void AddIsopen(FlatBufferBuilder builder, bool isopen)
		{
			builder.AddBool(4, isopen, false);
		}

		public static void AddIsconstruction(FlatBufferBuilder builder, bool isconstruction)
		{
			builder.AddBool(5, isconstruction, false);
		}

		public static void AddFacilitydata(FlatBufferBuilder builder, VectorOffset facilitydataOffset)
		{
			builder.AddOffset(6, facilitydataOffset.Value, 0);
		}

		public static VectorOffset CreateFacilitydataVector(FlatBufferBuilder builder, Offset<SeasonalBuildingFacilityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateFacilitydataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalBuildingFacilityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateFacilitydataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalBuildingFacilityData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateFacilitydataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartFacilitydataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddWorkerdata(FlatBufferBuilder builder, Offset<SeasonalBuildingWorkerData> workerdataOffset)
		{
			builder.AddOffset(7, workerdataOffset.Value, 0);
		}

		public static void AddManagerdata(FlatBufferBuilder builder, Offset<SeasonalWorkshopManagerData> managerdataOffset)
		{
			builder.AddOffset(8, managerdataOffset.Value, 0);
		}

		public static Offset<SeasonalBuildingData> EndSeasonalBuildingData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalBuildingData>(o);
		}

		public SeasonalBuildingDataT UnPack()
		{
			var _o = new SeasonalBuildingDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalBuildingDataT _o)
		{
			_o.Buildingidx = this.Buildingidx;
			_o.Level = this.Level;
			_o.Constructioncompletetimeticks = this.Constructioncompletetimeticks;
			_o.Needcompletenotice = this.Needcompletenotice;
			_o.Isopen = this.Isopen;
			_o.Isconstruction = this.Isconstruction;
			_o.Facilitydata = new List<SeasonalBuildingFacilityDataT>();
			for (var _j = 0; _j < this.FacilitydataLength; ++_j)
				_o.Facilitydata.Add(this.Facilitydata(_j).HasValue ? this.Facilitydata(_j).Value.UnPack() : null);
			_o.Workerdata = this.Workerdata.HasValue ? this.Workerdata.Value.UnPack() : null;
			_o.Managerdata = this.Managerdata.HasValue ? this.Managerdata.Value.UnPack() : null;
		}

		public static Offset<SeasonalBuildingData> Pack(FlatBufferBuilder builder, SeasonalBuildingDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalBuildingData>);
			var _facilitydata = default(VectorOffset);
			if (_o.Facilitydata != null)
			{
				var __facilitydata = new Offset<SeasonalBuildingFacilityData>[_o.Facilitydata.Count];
				for (var _j = 0; _j < _o.Facilitydata.Count; ++_j)
					__facilitydata[_j] = SeasonalBuildingFacilityData.Pack(builder, _o.Facilitydata[_j]);
				_facilitydata = CreateFacilitydataVector(builder, __facilitydata);
			}
			var _workerdata = _o.Workerdata == null ? default(Offset<SeasonalBuildingWorkerData>) : SeasonalBuildingWorkerData.Pack(builder, _o.Workerdata);
			var _managerdata = _o.Managerdata == null ? default(Offset<SeasonalWorkshopManagerData>) : SeasonalWorkshopManagerData.Pack(builder, _o.Managerdata);
			StartSeasonalBuildingData(builder);
			AddBuildingidx(builder, _o.Buildingidx);
			AddLevel(builder, _o.Level);
			AddConstructioncompletetimeticks(builder, _o.Constructioncompletetimeticks);
			AddNeedcompletenotice(builder, _o.Needcompletenotice);
			AddIsopen(builder, _o.Isopen);
			AddIsconstruction(builder, _o.Isconstruction);
			AddFacilitydata(builder, _facilitydata);
			AddWorkerdata(builder, _workerdata);
			AddManagerdata(builder, _managerdata);
			return EndSeasonalBuildingData(builder);
		}
	}
}
