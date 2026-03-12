using UnityEngine;

public class AddQueenFtueAction : BaseFtueAction
{
	[SerializeField]
	private int m_queensNeeded;

	[SerializeField]
	protected Vector2Int[] m_ftueCells;

	[SerializeField]
	private bool m_clearFtueCellsAtEnd;

	[SerializeField]
	protected PlayableDirectorHelper m_wrongPLayable;

	[SerializeField]
	protected FtueHandController m_hand;

	[SerializeField]
	protected bool m_showHandAtStart;

	[SerializeField]
	protected bool m_removeHilightOnCross;

	private int m_queensCount;

	public override void Play()
	{
		m_queensCount = 0;

		// Hide continue button during placement steps
		HideContinueButton();

		if (m_grid != null)
		{
			m_grid.SetFtueMode();
			m_grid.ClearFtueTargets();

			if (m_ftueCells != null)
			{
				for (int i = 0; i < m_ftueCells.Length; i++)
					m_grid.AddFtueTarget(m_ftueCells[i].x, m_ftueCells[i].y);
			}

			m_grid.QueenMarked += QueenMarked;
			m_grid.CrossMarked += CrossMarked;
			m_grid.LifeLost += OnLifeLost;
		}

		ConfigureFTUEHand();
	}

	private void HideContinueButton()
	{
		var popup = GetComponentInParent<PopupQueensInGameAdaptiveFTUE>();
		if (popup == null) return;
		var buttons = popup.GetComponentsInChildren<UnityEngine.UI.Button>(true);
		for (int i = 0; i < buttons.Length; i++)
		{
			if (buttons[i].gameObject.name == "Button-Continue")
			{
				buttons[i].gameObject.SetActive(false);
				break;
			}
		}
	}

	private void ConfigureFTUEHand()
	{
		// 只有 prefab 绑定了 m_hand 的步骤才显示手
		if (m_hand != null && m_showHandAtStart && m_ftueCells != null && m_ftueCells.Length > 0)
		{
			var cell = m_grid != null ? m_grid.GetCell(m_ftueCells[0].x, m_ftueCells[0].y) : null;
			if (cell != null)
				m_hand.Config(cell);
		}
	}

	private void CrossMarked(int cellIndex)
	{
		if (m_removeHilightOnCross && m_grid != null)
		{
			// Cross was placed - possibly play wrong animation
		}
	}

	private void OnLifeLost(int cellIndex)
	{
		if (m_wrongPLayable != null)
			m_wrongPLayable.Play();
	}

	protected override void Finished()
	{
		UnityEngine.Debug.Log($"[AddQueenFtueAction] Finished() on '{gameObject.name}' - m_hand={(m_hand != null ? m_hand.gameObject.name : "NULL")}, queensCount={m_queensCount}");

		if (m_grid != null)
		{
			m_grid.QueenMarked -= QueenMarked;
			m_grid.CrossMarked -= CrossMarked;
			m_grid.LifeLost -= OnLifeLost;

			if (m_clearFtueCellsAtEnd)
				m_grid.ClearFtueTargets();
		}
		if (m_hand != null)
			m_hand.Hide();
		base.Finished();
	}

	private void QueenMarked(int cellIndex)
	{
		m_queensCount++;
		if (m_queensCount >= m_queensNeeded)
		{
			Finished();
		}
	}
}
