using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct TreeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Grade { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static TreeData GetRootAsTreeData(ByteBuffer _bb)
		{
			return GetRootAsTreeData(_bb, new TreeData());
		}

		public static TreeData GetRootAsTreeData(ByteBuffer _bb, TreeData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public TreeData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIndex(int index)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, index);
				return true;
			}
			return false;
		}

		public bool MutateGrade(int grade)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, grade);
				return true;
			}
			return false;
		}

		public static Offset<TreeData> CreateTreeData(FlatBufferBuilder builder, int index = 0, int grade = 0)
		{
			builder.StartTable(2);
			AddGrade(builder, grade);
			AddIndex(builder, index);
			return EndTreeData(builder);
		}

		public static void StartTreeData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		public static void AddGrade(FlatBufferBuilder builder, int grade)
		{
			builder.AddInt(1, grade, 0);
		}

		public static Offset<TreeData> EndTreeData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<TreeData>(o);
		}

		public TreeDataT UnPack()
		{
			var _o = new TreeDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(TreeDataT _o)
		{
			_o.Index = this.Index;
			_o.Grade = this.Grade;
		}

		public static Offset<TreeData> Pack(FlatBufferBuilder builder, TreeDataT _o)
		{
			if (_o == null) return default(Offset<TreeData>);
			StartTreeData(builder);
			AddIndex(builder, _o.Index);
			AddGrade(builder, _o.Grade);
			return EndTreeData(builder);
		}
	}
}
