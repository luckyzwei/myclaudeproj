public class EndFtueStateFtueAction : BaseFtueAction
{
	public override void Play()
	{
		if (m_grid != null)
			m_grid.ClearFtueMode();
		Finished();
	}
}
