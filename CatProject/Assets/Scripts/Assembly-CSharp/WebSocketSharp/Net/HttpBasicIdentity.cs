using System.Security.Principal;

namespace WebSocketSharp.Net
{
	public class HttpBasicIdentity : GenericIdentity
	{
		private string _password;

		public virtual string Password => null;

		internal HttpBasicIdentity(string username, string password)
			: base(null, null)
		{
		}
	}
}
