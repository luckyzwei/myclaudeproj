using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class InviteDataT
	{
		[JsonProperty("invitereward")]
		public List<int> Invitereward { get; set; }

		[JsonProperty("invitegemreceive")]
		public bool Invitegemreceive { get; set; }

		[JsonProperty("invitegemtime")]
		public long Invitegemtime { get; set; }
	}
}
