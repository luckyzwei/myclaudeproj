using System;
using UnityEngine;

[Serializable]
public struct CamOffset
{
	public float xOffset;

	public float yOffset;

	public float zoomSize;

	public CamOffset(float xOffset, float yOffset, float zoomSize)
	{
		this.xOffset = 0f;
		this.yOffset = 0f;
		this.zoomSize = 0f;
	}

	public Vector3 ToVector()
	{
		return default(Vector3);
	}
}
