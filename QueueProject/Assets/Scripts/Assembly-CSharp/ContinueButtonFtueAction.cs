public class ContinueButtonFtueAction : BaseFtueAction
{
	public override void Play()
	{
		// Wait for user to press continue - do not call Finished()
	}

	public override void ContinuePressed()
	{
		Finished();
	}
}
