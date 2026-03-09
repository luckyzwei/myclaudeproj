using System.Collections;

public interface IDataInterface<T> where T : ProgressionData.DataHolder
{
	void MapHashTableToClass(Hashtable hashtable);

	void ClearList();
}
