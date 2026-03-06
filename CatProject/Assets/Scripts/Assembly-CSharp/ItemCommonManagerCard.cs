using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ItemCommonManagerCard : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPrefabActiveNextFrame_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemCommonManagerCard _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPrefabActiveNextFrame_003Ed__23(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private string MANAGER_PREFAB_NAME;

	[Header("Info Area")]
	[SerializeField]
	private Text ManagerName;

	[SerializeField]
	private Image ManagerImg;

	[SerializeField]
	private Image ManagerFrame;

	[SerializeField]
	private Text ManagerGradeText;

	[Header("Manager Prefab 해당 오브젝트 설정시 이미지 설정이 아닌 UI 매니저 프리팹 로드")]
	[SerializeField]
	private GameObject ManagerPrefabRoot;

	[Space(5f)]
	[SerializeField]
	private bool ShowFullName;

	[SerializeField]
	private GameObject hireRoot;

	[SerializeField]
	private GameObject RegionRoot;

	[SerializeField]
	private Text HiredOfficeText;

	[SerializeField]
	private Text HiredRegionText;

	private int ManagerIdx;

	private GameObject LoadedManagerPrefab;

	private Action LoadEndCallback;

	private Vector3 ManagerPrefabRootPosition_Origin;

	private Vector3 ManagerPrefabRootPosition_Outer;

	private void Awake()
	{
		if (ManagerPrefabRoot != null)
			ManagerPrefabRootPosition_Origin = ManagerPrefabRoot.transform.localPosition;
		ManagerPrefabRootPosition_Outer = ManagerPrefabRootPosition_Origin + Vector3.right * 1000f;
	}

	public void Set(int managerIdx)
	{
		ManagerIdx = managerIdx;
		bool usePrefab = ManagerPrefabRoot != null;
		SetManagerInfo(managerIdx, !usePrefab);
		if (usePrefab)
			LoadManagerPrefab(managerIdx);
	}

	public void SetAnimateManager(int managerIdx, Action endCallback)
	{
		ManagerIdx = managerIdx;
		LoadEndCallback = endCallback;
		SetManagerInfo(managerIdx, false);
		if (ManagerPrefabRoot != null)
			LoadManagerPrefab(managerIdx);
	}

	public void Reset()
	{
		ManagerIdx = 0;
		if (ManagerName != null) ManagerName.text = "";
		if (ManagerImg != null) ManagerImg.gameObject.SetActive(false);
		if (LoadedManagerPrefab != null)
		{
			Destroy(LoadedManagerPrefab);
			LoadedManagerPrefab = null;
		}
	}

	private void SetManagerInfo(int managerIdx, bool setImg)
	{
		if (hireRoot != null) hireRoot.SetActive(false);
		if (RegionRoot != null) RegionRoot.SetActive(false);
	}

	public void UpdateManagerHireInfo()
	{
		if (hireRoot != null) hireRoot.SetActive(ManagerIdx > 0);
	}

	private void LoadManagerPrefab(int managerIdx)
	{
		if (LoadedManagerPrefab != null)
		{
			Destroy(LoadedManagerPrefab);
			LoadedManagerPrefab = null;
		}
		StartCoroutine(PrefabActiveNextFrame());
	}

	[IteratorStateMachine(typeof(_003CPrefabActiveNextFrame_003Ed__23))]
	private IEnumerator PrefabActiveNextFrame()
	{
		yield return null;
		if (ManagerPrefabRoot != null)
			ManagerPrefabRoot.transform.localPosition = ManagerPrefabRootPosition_Origin;
		LoadEndCallback?.Invoke();
		LoadEndCallback = null;
	}
}
