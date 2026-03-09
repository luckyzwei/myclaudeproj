namespace KWGameSettings
{
	public abstract class ForceConnectionPopup
	{
		public abstract int ShowAfterXBoots { get; set; }

		public abstract int ShowAfterXSessions { get; set; }

		public abstract int ShowAfterXGames { get; set; }

		public abstract bool Enabled { get; set; }
	}
}
