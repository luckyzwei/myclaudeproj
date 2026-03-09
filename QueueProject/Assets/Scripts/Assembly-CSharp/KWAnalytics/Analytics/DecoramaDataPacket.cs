using System.Collections;

namespace KWAnalytics.Analytics
{
	public class DecoramaDataPacket : AnalyticsDataPacketBase
	{
		private const string HASHTABLE_KEY = "decorama_data";

		private int m_numTaps;

		private float m_startTime;

		private int m_pointsEarned;

		public override void FillHashTable(ref Hashtable hashTable)
		{
		}

		private int GetNumDecoramasCompleted()
		{
			return 0;
		}

		protected override string HashtableKey()
		{
			return null;
		}

		public override void ResetValues()
		{
		}

		public void IncrementTap()
		{
		}

		public void SetPointsEarned(int pointsEarned)
		{
		}
	}
}
