namespace KWGameCore
{
	public interface IMarket
	{
		void Initialise(MarketInterface del);

		void DoOnApplicationPause(bool isPaused);
	}
}
