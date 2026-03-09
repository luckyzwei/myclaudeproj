public class QueensCalendarCell : CalendarCell
{
	private enum State
	{
		UNDECIDED = 0,
		AVAILABLE = 1,
		COMPLETED = 2,
		FAILED = 3,
		DISABLED = 4,
		UNAVAILABLE = 5
	}

	private const string ANIM_ANIM_CELL_CALENDAR_SELECTED = "Anim-Cell-Calendar-Selected";

	private const string ANIM_ANIM_CELL_CALENDAR_SELECTED_LOSE = "Anim-Cell-Calendar-Selected-Lose";

	private const string ANIM_ANIM_CELL_CALENDAR_SELECTED_COMPLETED = "Anim-Cell-Calendar-Selected-Completed";

	private const string ANIM_HIGHLIGHTED = "Highlighted";

	private State m_state;

	public override void SelectedCell()
	{
	}

	public override void CompletedCell()
	{
	}

	public override void FailedCell()
	{
	}

	public override void AvailableCell()
	{
	}

	public override void DisableCell()
	{
	}

	public override void UnavailableCell()
	{
	}
}
