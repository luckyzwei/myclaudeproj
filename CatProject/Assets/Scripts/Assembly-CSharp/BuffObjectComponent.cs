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
	}

	private void OnDestroy()
	{
	}

	public void UpdateActive(Action<BuffObjectComponent> onRemove = null)
	{
	}

	private void UpdateOwn()
	{
	}

	private void UpdateEffect()
	{
	}

	private void OnClickObject()
	{
	}
}
