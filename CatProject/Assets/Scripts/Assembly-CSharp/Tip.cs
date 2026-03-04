using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;

public class Tip : MonoBehaviour
{
	[SerializeField]
	private Transform ValueTrans;

	[SerializeField]
	private GameObject TipObj;

	[SerializeField]
	private GameObject CriticalTipObj;

	[SerializeField]
	private GameObject SpecialTipObj;

	private InGameTipValue ValueUI;

	private BigInteger TipValue;

	protected InGameTipValue GetValueUI;

	private bool isCritical;

	private bool isUnique;

	private void Awake()
	{
	}

	public void AddPrice(BigInteger Price, bool Critical = false, bool Unique = false)
	{
	}

	private void OnDisable()
	{
	}

	public void OnClick()
	{
	}

	public bool isActive()
	{
		return false;
	}
}
