using System;
using System.Collections;

public class ProgressionData : BaseData, IDataInterface<ProgressionData.DataHolder>
{
	[Serializable]
	public class DataHolder
	{
	}

	public virtual void MapHashTableToClass(Hashtable hashtable)
	{
	}

	public virtual void ClearList()
	{
	}

	public override void ParseData(Hashtable data)
	{
	}
}
