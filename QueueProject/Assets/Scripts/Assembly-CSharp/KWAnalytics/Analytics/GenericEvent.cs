using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class GenericEvent : OpenSchema
	{
		private string m_uniqueKeyForJoin;

		public GenericEvent()
		{
		}

		public GenericEvent(int level, int stage)
		{
		}

		public void SetEventName(string name)
		{
		}

		public void SetUniqueKeyForJoin(string uniqueKeyForJoin)
		{
		}

		protected override string GetUniqueKeyForJoin()
		{
			return null;
		}

		private void SetParam<T>(int index, T param)
		{
		}

		public void SetStringParam(int index, string param)
		{
		}

		public void SetIntParam(int index, int param)
		{
		}

		public void SetFloatParam(int index, float param)
		{
		}

		public void SetBoolParam(int index, bool param)
		{
		}

		public void UsedOnlyForAOTCodeGeneration()
		{
		}
	}
}
