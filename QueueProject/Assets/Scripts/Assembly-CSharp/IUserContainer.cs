public interface IUserContainer
{
	string UserID { get; }

	void OnPlayerProfileChanged(PublicProfile profile);
}
