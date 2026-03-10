using UnityEngine;
using UnityEngine.UI;

public class InputTimerWidget : MonoBehaviour
{
	[SerializeField]
	private Image m_bar;

	private float m_time;

	private float m_duration;

	private bool m_active;

	private QueensGridCell m_cell;

	public void Config(QueensGridCell cell, float time)
	{
		m_cell = cell;
		m_duration = time;
		m_time = 0f;
		m_active = true;
		gameObject.SetActive(true);

		if (m_bar != null)
			m_bar.fillAmount = 1f;
	}

	public void Deactivate()
	{
		m_active = false;
		m_cell = null;
		gameObject.SetActive(false);
	}

	private void Update()
	{
		if (!m_active || m_duration <= 0f) return;

		m_time += Time.deltaTime;
		float remaining = 1f - (m_time / m_duration);

		if (m_bar != null)
			m_bar.fillAmount = Mathf.Clamp01(remaining);

		if (m_time >= m_duration)
		{
			m_active = false;
			// Timer expired - cell auto-clears
			if (m_cell != null)
			{
				var grid = QueensGameController.Instance?.Grid;
				if (grid != null)
					grid.ClearCell(m_cell.CellIndex);
			}
			Deactivate();
		}
	}
}
