using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalMissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Missionidx => 0;

		public int MissionvalueLength => 0;

		public int MissioncompleteLength => 0;

		public int MissionneedvalueLength => 0;

		public int NeedupdatetargetrequirevalueLength => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalMissionData GetRootAsSeasonalMissionData(ByteBuffer _bb)
		{
			return default(SeasonalMissionData);
		}

		public static SeasonalMissionData GetRootAsSeasonalMissionData(ByteBuffer _bb, SeasonalMissionData obj)
		{
			return default(SeasonalMissionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalMissionData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalMissionData);
		}

		public bool MutateMissionidx(int missionidx)
		{
			return false;
		}

		public string Missionvalue(int j)
		{
			return null;
		}

		public bool Missioncomplete(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetMissioncompleteBytes()
		{
			return null;
		}

		public bool[] GetMissioncompleteArray()
		{
			return null;
		}

		public bool MutateMissioncomplete(int j, bool missioncomplete)
		{
			return false;
		}

		public string Missionneedvalue(int j)
		{
			return null;
		}

		public bool Needupdatetargetrequirevalue(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetNeedupdatetargetrequirevalueBytes()
		{
			return null;
		}

		public bool[] GetNeedupdatetargetrequirevalueArray()
		{
			return null;
		}

		public bool MutateNeedupdatetargetrequirevalue(int j, bool needupdatetargetrequirevalue)
		{
			return false;
		}

		public static Offset<SeasonalMissionData> CreateSeasonalMissionData(FlatBufferBuilder builder, int missionidx = 0, VectorOffset missionvalueOffset = default(VectorOffset), VectorOffset missioncompleteOffset = default(VectorOffset), VectorOffset missionneedvalueOffset = default(VectorOffset), VectorOffset needupdatetargetrequirevalueOffset = default(VectorOffset))
		{
			return default(Offset<SeasonalMissionData>);
		}

		public static void StartSeasonalMissionData(FlatBufferBuilder builder)
		{
		}

		public static void AddMissionidx(FlatBufferBuilder builder, int missionidx)
		{
		}

		public static void AddMissionvalue(FlatBufferBuilder builder, VectorOffset missionvalueOffset)
		{
		}

		public static VectorOffset CreateMissionvalueVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionvalueVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionvalueVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionvalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartMissionvalueVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddMissioncomplete(FlatBufferBuilder builder, VectorOffset missioncompleteOffset)
		{
		}

		public static VectorOffset CreateMissioncompleteVector(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissioncompleteVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissioncompleteVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissioncompleteVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartMissioncompleteVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddMissionneedvalue(FlatBufferBuilder builder, VectorOffset missionneedvalueOffset)
		{
		}

		public static VectorOffset CreateMissionneedvalueVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionneedvalueVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionneedvalueVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionneedvalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartMissionneedvalueVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddNeedupdatetargetrequirevalue(FlatBufferBuilder builder, VectorOffset needupdatetargetrequirevalueOffset)
		{
		}

		public static VectorOffset CreateNeedupdatetargetrequirevalueVector(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateNeedupdatetargetrequirevalueVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateNeedupdatetargetrequirevalueVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateNeedupdatetargetrequirevalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartNeedupdatetargetrequirevalueVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<SeasonalMissionData> EndSeasonalMissionData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalMissionData>);
		}

		public SeasonalMissionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalMissionDataT _o)
		{
		}

		public static Offset<SeasonalMissionData> Pack(FlatBufferBuilder builder, SeasonalMissionDataT _o)
		{
			return default(Offset<SeasonalMissionData>);
		}
	}
}
