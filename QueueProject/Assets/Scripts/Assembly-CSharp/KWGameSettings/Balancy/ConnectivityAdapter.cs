using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class ConnectivityAdapter : Connectivity
	{
		public override ForceConnectionPopup ForceConnectionPopup { get; set; }
	}
}
