using UnityEngine;

[ExecuteAlways]
public class TouchCounterRecorder : MonoBehaviour
{
	[SerializeField]
	private Vector2Int m_recordGridSize;

	[Header("Debug Settings")]
	[Space]
	[SerializeField]
	private bool m_enableDebug;

	[SerializeField]
	private Color m_cellColor;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_fontSizeFactor;

	[SerializeField]
	private string m_base64;

	private byte[] m_gridCounterData;

	private bool m_startedHeatMap;

	private bool m_isHTML;

	private void OnValidate()
	{
	}

	public void StartHeatMap(bool isHTML = false)
	{
	}

	public void ResetHeatMap()
	{
	}

	public void StopHeatMap()
	{
	}

	private void Update()
	{
	}

	private void RecordMousePress(float mousePositionX, float mousePositionY)
	{
	}

	public void UpdateCounter(float mousePositionX, float mousePositionY)
	{
	}

	public string GetBase64()
	{
		return null;
	}
}
