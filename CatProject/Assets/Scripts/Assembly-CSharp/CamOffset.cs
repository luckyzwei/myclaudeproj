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
		this.xOffset = xOffset;
		this.yOffset = yOffset;
		this.zoomSize = zoomSize;
	}

	public Vector3 ToVector()
	{
		return new Vector3(xOffset, yOffset, 0f);
	}
}
