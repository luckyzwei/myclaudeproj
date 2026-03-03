using System.Collections.Generic;
using UnityEngine;

public class BizAcqStage : MonoBehaviour
{
	[SerializeField]
	private ObjectFollowCam followCamera;

	[SerializeField]
	private GameObject MoveRootObj;

	[SerializeField]
	private Transform StartTr;

	[SerializeField]
	private Transform EndTr;

	[SerializeField]
	private GameObject BuildingsRoot;

	[SerializeField]
	private float BuildingFxPlayDistance;

	[SerializeField]
	private float MoveSpeed;

	private bool IsMoving;

	private Vector3 MoveDir;

	private GameObject CarObj;

	private const int DEFAULT_CAR_IDX = 10001;

	private int CarIdx;

	private List<BizAcqBuilding> Buildings;

	public GameObject GetMoveRootObject()
	{
		return null;
	}

	public ObjectFollowCam GetFollowCam()
	{
		return null;
	}

	public Camera GetFollowCameraComponent()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void StartMove()
	{
	}

	public void StopMove()
	{
	}

	private void LoadCar()
	{
	}

	private void ResetBuildings()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}
}
