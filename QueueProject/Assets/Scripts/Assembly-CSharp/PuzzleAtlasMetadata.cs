using System;
using System.Collections.Generic;

[Serializable]
public class PuzzleAtlasMetadata
{
	[Serializable]
	public struct RectData
	{
		public float x;

		public float y;

		public float width;

		public float height;
	}

	public string sourceImageNameHash;

	public int numPiecesH;

	public int numPiecesV;

	public float knobFactor;

	public float pixelsPerUnit;

	public float padding;

	public int cellWidth;

	public int cellHeight;

	public float actualKnobRadius;

	public int pieceTexWidth;

	public int pieceTexHeight;

	public int atlasWidth;

	public int atlasHeight;

	public List<RectData> pieceRects;
}
