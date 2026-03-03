using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SubMissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Missionidx => 0;

		public int MissionvalueLength => 0;

		public int MissioncompleteLength => 0;

		public int MissionneedvalueLength => 0;

		public static void ValidateVersion()
		{
		}

		public static SubMissionData GetRootAsSubMissionData(ByteBuffer _bb)
		{
			return default(SubMissionData);
		}

		public static SubMissionData GetRootAsSubMissionData(ByteBuffer _bb, SubMissionData obj)
		{
			return default(SubMissionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SubMissionData __assign(int _i, ByteBuffer _bb)
		{
			return default(SubMissionData);
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

		public static Offset<SubMissionData> CreateSubMissionData(FlatBufferBuilder builder, int missionidx = 0, VectorOffset missionvalueOffset = default(VectorOffset), VectorOffset missioncompleteOffset = default(VectorOffset), VectorOffset missionneedvalueOffset = default(VectorOffset))
		{
			return default(Offset<SubMissionData>);
		}

		public static void StartSubMissionData(FlatBufferBuilder builder)
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

		public static Offset<SubMissionData> EndSubMissionData(FlatBufferBuilder builder)
		{
			return default(Offset<SubMissionData>);
		}

		public SubMissionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SubMissionDataT _o)
		{
		}

		public static Offset<SubMissionData> Pack(FlatBufferBuilder builder, SubMissionDataT _o)
		{
			return default(Offset<SubMissionData>);
		}
	}
}
