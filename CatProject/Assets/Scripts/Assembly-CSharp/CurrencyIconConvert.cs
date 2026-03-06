using UnityEngine;

public class CurrencyIconConvert : MonoBehaviour
{
	private enum currencyType
	{
		Money = 0,
		Power = 1,
		Point = 2
	}

	[SerializeField]
	private currencyType currency;

	public bool bSetCustom;

	private void Start()
	{
		// Start initialization
	}
}
