using System.Collections.Generic;
using Balancy.Models.KWSpinWheel;
using UnityEngine;

public class SpinWheelSegmentsController : MonoBehaviour
{
	private const float FULL_ROTATION = 360f;

	[SerializeField]
	private SpinWheelSegment m_spinWheelSegmentPrefab;

	[SerializeField]
	private Transform m_segmentsParent;

	[SerializeField]
	private Sprite[] m_segmentSprites;

	[Header("SegmentScale Map")]
	[SerializeField]
	private int m_minSegments;

	[SerializeField]
	private int m_maxSegments;

	[SerializeField]
	private float m_minScale;

	[SerializeField]
	private float m_maxScale;

	private List<SpinWheelSegment> m_spinWheelSegments;

	public int SegmentCount => 0;

	public List<SpinWheelSegment> Segments => null;

	public void CreateSegments(SpinWheelRewards reward)
	{
	}

	public SpinWheelSegment GetSpinWheelSegment(int index)
	{
		return null;
	}

	private float SegmentScale(float totalSegments)
	{
		return 0f;
	}
}
