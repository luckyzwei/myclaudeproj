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
		return MoveRootObj;
	}

	public ObjectFollowCam GetFollowCam()
	{
		return followCamera;
	}

	public Camera GetFollowCameraComponent()
	{
		if (followCamera == null) return null;
		return followCamera.GetComponent<Camera>();
	}

	private void Awake()
	{
		CarIdx = DEFAULT_CAR_IDX;
		Buildings = new List<BizAcqBuilding>();
		if (StartTr != null && EndTr != null)
		{
			MoveDir = (EndTr.position - StartTr.position).normalized;
		}
	}

	public void StartMove()
	{
		IsMoving = true;
	}

	public void StopMove()
	{
		IsMoving = false;
	}

	private void LoadCar()
	{
		// Would load car prefab via Addressables
	}

	private void ResetBuildings()
	{
		if (Buildings != null)
			Buildings.Clear();
		if (BuildingsRoot != null)
		{
			var buildingComponents = BuildingsRoot.GetComponentsInChildren<BizAcqBuilding>();
			if (buildingComponents != null)
			{
				Buildings = new List<BizAcqBuilding>(buildingComponents);
			}
		}
	}

	private void Update()
	{
		if (!IsMoving || MoveRootObj == null) return;
		MoveRootObj.transform.position += MoveDir * MoveSpeed * Time.deltaTime;
	}

	private void FixedUpdate()
	{
		if (!IsMoving || CarObj == null || followCamera == null) return;
		// Check building distance for effects
		if (Buildings == null) return;
		Vector3 carPos = CarObj.transform.position;
		for (int i = 0; i < Buildings.Count; i++)
		{
			if (Buildings[i] == null) continue;
			float dist = Vector3.Distance(carPos, Buildings[i].transform.position);
			if (dist <= BuildingFxPlayDistance)
			{
				// Would trigger building effect
			}
		}
	}
}
