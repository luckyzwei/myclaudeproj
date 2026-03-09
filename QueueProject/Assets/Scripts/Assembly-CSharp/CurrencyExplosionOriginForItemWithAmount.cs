using UnityEngine;

public class CurrencyExplosionOriginForItemWithAmount : CurrencyExplosionOrigin
{
	[SerializeField]
	[Autohook]
	private ItemWithAmountCell m_itemWithAmount;

	private bool m_cellInitialised;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public override string GetClientID()
	{
		return null;
	}
}
