using System;
using System.Collections.Generic;
using Firebase.Firestore;

public class TpFirebaseDataProp
{
	public static readonly string dbPath;

	public static readonly string customTablePath;

	public void Init()
	{
	}

	public void GetCustomTableData(int idx, Action<List<Config.RewardItemData>> callback)
	{
	}

	public void UpLoadData(Action<bool> OnEnd)
	{
	}

	public void GetSaveDate(Action<long> OnReturn)
	{
	}

	public void DownLoadData(Action OnEnd)
	{
	}

	public static FirebaseUserData ConvertToUserData(DocumentSnapshot snapshot)
	{
		return default(FirebaseUserData);
	}

	public void EditorDownLoadData(Action OnEnd)
	{
	}
}
