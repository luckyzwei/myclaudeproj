using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemSuperStaffCard : MonoBehaviour
{
	[Header("ItemSuperStaffCard")]
	[SerializeField]
	private Button ManagerBtn;

	[Header("Info")]
	[SerializeField]
	private Text ManagerName;

	[SerializeField]
	private Image ManagerImg;

	[SerializeField]
	private GameObject obj_Lock;

	[Header("Level")]
	[SerializeField]
	private Text text_level;

	[SerializeField]
	private Slider slider_exp;

	[SerializeField]
	private Text text_exp;

	[SerializeField]
	private GameObject LevelIcon;

	[SerializeField]
	private GameObject LevelUpArrow;

	[Header("Noti")]
	[SerializeField]
	private GameObject LevelUpNoti;

	protected int curIdx;

	private SuperStaffCardData curCardData;

	public Action InfoCloseCb;

	private bool isLock;

	private CompositeDisposable disposables;

	public int CurManagerIdx { get { return 0; } }

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void Set(int idx)
	{
	}

	protected virtual void OnClickManager()
	{
	}
}
