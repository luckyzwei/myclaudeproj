using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;

public class NavigatorSystem
{
	public class NaviData
	{
		public int group;

		public int slot;

		public int desk;

		public BigInteger price;

		public Vector3 position;
	}

	private List<NaviData> listHudNavi;

	private List<NaviData> listArrowNavi;

	private List<int> listDoctorNavi;

	public Action OnChangeHudList;

	public Action OnChangeArrowList;

	public Action OnChangeDoctorList;

	private int staffIndex;

	private int slotIndex;

	public NavigatorSystem()
	{
		listHudNavi = new List<NaviData>();
		listArrowNavi = new List<NaviData>();
		listDoctorNavi = new List<int>();
	}

	public int GetArrowNaviIndex(bool staff)
	{
		return staff ? staffIndex : slotIndex;
	}

	public void AddArrowNavi(int group = -1, int desk = -1, int slot = -1, Vector3 pos = default(Vector3))
	{
		var data = new NaviData
		{
			group = group,
			desk = desk,
			slot = slot,
			position = pos
		};
		listArrowNavi.Add(data);
		OnChangeArrowList?.Invoke();
	}

	public void RemoveArrowNavi(bool staff, int index)
	{
		if (index >= 0 && index < listArrowNavi.Count)
		{
			listArrowNavi.RemoveAt(index);
			OnChangeArrowList?.Invoke();
		}
	}

	public void AddHudNavi(int group, int slot = -1, int desk = -1, BigInteger price = default(BigInteger))
	{
		var data = new NaviData
		{
			group = group,
			slot = slot,
			desk = desk,
			price = price
		};
		listHudNavi.Add(data);
		OnChangeHudList?.Invoke();
	}

	public void RemoveHudNavi(int group, int slot, int desk)
	{
		for (int i = listHudNavi.Count - 1; i >= 0; i--)
		{
			var data = listHudNavi[i];
			if (data.group == group && data.slot == slot && data.desk == desk)
			{
				listHudNavi.RemoveAt(i);
				break;
			}
		}
		OnChangeHudList?.Invoke();
	}

	public void AddDoctorNavi(int manager)
	{
		if (!listDoctorNavi.Contains(manager))
		{
			listDoctorNavi.Add(manager);
			OnChangeDoctorList?.Invoke();
		}
	}

	public void RemoveDoctorNavi(int manager)
	{
		if (listDoctorNavi.Remove(manager))
		{
			OnChangeDoctorList?.Invoke();
		}
	}

	public void Clear()
	{
		listHudNavi.Clear();
		listArrowNavi.Clear();
		listDoctorNavi.Clear();
		OnChangeHudList?.Invoke();
		OnChangeArrowList?.Invoke();
		OnChangeDoctorList?.Invoke();
	}

	public List<int> GetDoctorNaviList()
	{
		return listDoctorNavi;
	}

	public int GetFirstDoctorElement()
	{
		if (listDoctorNavi.Count > 0)
			return listDoctorNavi[0];
		return -1;
	}

	public List<NaviData> GetArrowNaviList()
	{
		return listArrowNavi;
	}

	public NaviData GetFirstArrowElement()
	{
		if (listArrowNavi.Count > 0)
			return listArrowNavi[0];
		return null;
	}

	public NaviData GetFirstElement()
	{
		if (listHudNavi.Count > 0)
			return listHudNavi[0];
		return null;
	}
}
