using UnityEngine;

public class CurrencyExplosionOrigin : MonoBehaviour
{
	[SerializeField]
	private string m_assignedClientID;

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	public virtual string GetClientID()
	{
		return null;
	}
}
