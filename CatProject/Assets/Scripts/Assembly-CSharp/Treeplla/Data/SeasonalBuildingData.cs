using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalBuildingData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Buildingidx => 0;

		public int Level => 0;

		public long Constructioncompletetimeticks => 0L;

		public bool Needcompletenotice => false;

		public bool Isopen => false;

		public bool Isconstruction => false;

		public int FacilitydataLength => 0;

		public SeasonalBuildingWorkerData? Workerdata => null;

		public SeasonalWorkshopManagerData? Managerdata => null;

		public static void ValidateVersion()
		{
		}

		public static SeasonalBuildingData GetRootAsSeasonalBuildingData(ByteBuffer _bb)
		{
			return default(SeasonalBuildingData);
		}

		public static SeasonalBuildingData GetRootAsSeasonalBuildingData(ByteBuffer _bb, SeasonalBuildingData obj)
		{
			return default(SeasonalBuildingData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalBuildingData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalBuildingData);
		}

		public bool MutateBuildingidx(int buildingidx)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateConstructioncompletetimeticks(long constructioncompletetimeticks)
		{
			return false;
		}

		public bool MutateNeedcompletenotice(bool needcompletenotice)
		{
			return false;
		}

		public bool MutateIsopen(bool isopen)
		{
			return false;
		}

		public bool MutateIsconstruction(bool isconstruction)
		{
			return false;
		}

		public SeasonalBuildingFacilityData? Facilitydata(int j)
		{
			return null;
		}

		public static Offset<SeasonalBuildingData> CreateSeasonalBuildingData(FlatBufferBuilder builder, int buildingidx = 0, int level = 0, long constructioncompletetimeticks = 0L, bool needcompletenotice = false, bool isopen = false, bool isconstruction = false, VectorOffset facilitydataOffset = default(VectorOffset), Offset<SeasonalBuildingWorkerData> workerdataOffset = default(Offset<SeasonalBuildingWorkerData>), Offset<SeasonalWorkshopManagerData> managerdataOffset = default(Offset<SeasonalWorkshopManagerData>))
		{
			return default(Offset<SeasonalBuildingData>);
		}

		public static void StartSeasonalBuildingData(FlatBufferBuilder builder)
		{
		}

		public static void AddBuildingidx(FlatBufferBuilder builder, int buildingidx)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddConstructioncompletetimeticks(FlatBufferBuilder builder, long constructioncompletetimeticks)
		{
		}

		public static void AddNeedcompletenotice(FlatBufferBuilder builder, bool needcompletenotice)
		{
		}

		public static void AddIsopen(FlatBufferBuilder builder, bool isopen)
		{
		}

		public static void AddIsconstruction(FlatBufferBuilder builder, bool isconstruction)
		{
		}

		public static void AddFacilitydata(FlatBufferBuilder builder, VectorOffset facilitydataOffset)
		{
		}

		public static VectorOffset CreateFacilitydataVector(FlatBufferBuilder builder, Offset<SeasonalBuildingFacilityData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFacilitydataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalBuildingFacilityData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFacilitydataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalBuildingFacilityData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFacilitydataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartFacilitydataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddWorkerdata(FlatBufferBuilder builder, Offset<SeasonalBuildingWorkerData> workerdataOffset)
		{
		}

		public static void AddManagerdata(FlatBufferBuilder builder, Offset<SeasonalWorkshopManagerData> managerdataOffset)
		{
		}

		public static Offset<SeasonalBuildingData> EndSeasonalBuildingData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalBuildingData>);
		}

		public SeasonalBuildingDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalBuildingDataT _o)
		{
		}

		public static Offset<SeasonalBuildingData> Pack(FlatBufferBuilder builder, SeasonalBuildingDataT _o)
		{
			return default(Offset<SeasonalBuildingData>);
		}
	}
}
