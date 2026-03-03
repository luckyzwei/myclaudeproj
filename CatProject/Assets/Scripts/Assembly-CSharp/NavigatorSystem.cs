using System;
using System.Collections.Generic;
using System.Numerics;
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

	public int GetArrowNaviIndex(bool staff)
	{
		return 0;
	}

	public void AddArrowNavi(int group = -1, int desk = -1, int slot = -1, Vector3 pos = default(Vector3))
	{
	}

	public void RemoveArrowNavi(bool staff, int index)
	{
	}

	public void AddHudNavi(int group, int slot = -1, int desk = -1, BigInteger price = default(BigInteger))
	{
	}

	public void RemoveHudNavi(int group, int slot, int desk)
	{
	}

	public void AddDoctorNavi(int manager)
	{
	}

	public void RemoveDoctorNavi(int manager)
	{
	}

	public void Clear()
	{
	}

	public List<int> GetDoctorNaviList()
	{
		return null;
	}

	public int GetFirstDoctorElement()
	{
		return 0;
	}

	public List<NaviData> GetArrowNaviList()
	{
		return null;
	}

	public NaviData GetFirstArrowElement()
	{
		return null;
	}

	public NaviData GetFirstElement()
	{
		return null;
	}
}
