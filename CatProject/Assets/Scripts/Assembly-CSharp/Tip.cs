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
		// Initialize
	}

	public void AddPrice(BigInteger Price, bool Critical = false, bool Unique = false)
	{
		TipValue += Price;
		isCritical = Critical;
		isUnique = Unique;
		if (TipObj != null) TipObj.SetActive(!Critical && !Unique);
		if (CriticalTipObj != null) CriticalTipObj.SetActive(Critical);
		if (SpecialTipObj != null) SpecialTipObj.SetActive(Unique);
	}

	private void OnDisable()
	{
		TipValue = BigInteger.Zero;
		isCritical = false;
		isUnique = false;
	}

	public void OnClick()
	{
		// Handle click
	}

	public bool isActive()
	{
		return TipValue > BigInteger.Zero;
	}
}
