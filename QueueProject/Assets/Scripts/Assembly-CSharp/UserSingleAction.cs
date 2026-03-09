public struct UserSingleAction
{
	public UserActionType Action;

	public float Time;

	public int CellIndex;

	public UserSingleAction(UserActionType action, float time, int cellIndex)
	{
		Action = default(UserActionType);
		Time = 0f;
		CellIndex = 0;
	}
}
