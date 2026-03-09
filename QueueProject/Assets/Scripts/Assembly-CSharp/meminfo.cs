using System.Text.RegularExpressions;

public class meminfo
{
	public struct meminf
	{
		public int memtotal;

		public int memfree;

		public int memavailable;

		public int swaptotal;

		public int swapfree;

		public int memcache;

		public int active;

		public int inactive;

		public int swapcached;

		public int memLoad;

		public int memused;

		public int memwired;
	}

	public static meminf minf;

	private static Regex re;

	private static void clearMinfStruct()
	{
	}

	public static bool getMemInfo()
	{
		return false;
	}

	private static int mVal(string s)
	{
		return 0;
	}

	public static void gc_Collect()
	{
	}
}
