using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class BuffObjectComponent : MonoBehaviour
{
	public int BuffObjectIdx;

	[SerializeField]
	private Transform UITrans;

	[SerializeField]
	private SpriteRenderer ObjSprite;

	[SerializeField]
	private List<GameObject> OwnObj;

	private Material OriginMat;

	private CompositeDisposable disposables;

	public int Floor { get; private set; }

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (ObjSprite != null) OriginMat = ObjSprite.material;
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	public void UpdateActive(Action<BuffObjectComponent> onRemove = null)
	{
		UpdateOwn();
		UpdateEffect();
	}

	private void UpdateOwn()
	{
		if (OwnObj == null) return;
		for (int i = 0; i < OwnObj.Count; i++)
		{
			if (OwnObj[i] != null)
				OwnObj[i].SetActive(true);
		}
	}

	private void UpdateEffect()
	{
		// Apply buff object visual effects
	}

	private void OnClickObject()
	{
		// Show buff object info popup
	}
}
