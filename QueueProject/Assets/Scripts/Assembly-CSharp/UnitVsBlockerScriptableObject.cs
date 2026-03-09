using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitVsBlockerData", menuName = "Data/UnitVsBlockerData", order = 1)]
public class UnitVsBlockerScriptableObject : BaseData
{
	[Serializable]
	public class UnitVsBlocker
	{
		public long[] values;
	}

	[SerializeField]
	public List<UnitVsBlocker> listDestructionTime;

	public long GetValueAt(int column, int row)
	{
		return 0L;
	}

	public override void ParseData(Hashtable data)
	{
	}
}
