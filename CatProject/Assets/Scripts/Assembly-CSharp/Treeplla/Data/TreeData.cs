using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct TreeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Index => 0;

		public int Grade => 0;

		public static void ValidateVersion()
		{
		}

		public static TreeData GetRootAsTreeData(ByteBuffer _bb)
		{
			return default(TreeData);
		}

		public static TreeData GetRootAsTreeData(ByteBuffer _bb, TreeData obj)
		{
			return default(TreeData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public TreeData __assign(int _i, ByteBuffer _bb)
		{
			return default(TreeData);
		}

		public bool MutateIndex(int index)
		{
			return false;
		}

		public bool MutateGrade(int grade)
		{
			return false;
		}

		public static Offset<TreeData> CreateTreeData(FlatBufferBuilder builder, int index = 0, int grade = 0)
		{
			return default(Offset<TreeData>);
		}

		public static void StartTreeData(FlatBufferBuilder builder)
		{
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
		}

		public static void AddGrade(FlatBufferBuilder builder, int grade)
		{
		}

		public static Offset<TreeData> EndTreeData(FlatBufferBuilder builder)
		{
			return default(Offset<TreeData>);
		}

		public TreeDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(TreeDataT _o)
		{
		}

		public static Offset<TreeData> Pack(FlatBufferBuilder builder, TreeDataT _o)
		{
			return default(Offset<TreeData>);
		}
	}
}
