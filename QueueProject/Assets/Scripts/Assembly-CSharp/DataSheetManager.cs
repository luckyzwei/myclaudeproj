using System;
using System.Collections.Generic;
using KWCore.Utils;
using UnityEngine;

public class DataSheetManager : MonoSingleton<DataSheetManager>
{
	private Dictionary<Type, Dictionary<string, BaseData>> m_dataDictionary;

	[SerializeField]
	private BaseData[] m_baseDatas;

	public Dictionary<Type, Dictionary<string, BaseData>> DataDictionary => null;

	protected override void Init()
	{
	}

	public T GetDataOfType<T>(string clientId = "")
	{
		return default(T);
	}

	public void PopulateDictionary()
	{
	}
}
