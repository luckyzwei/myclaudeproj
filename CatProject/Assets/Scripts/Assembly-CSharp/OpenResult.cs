public readonly struct OpenResult
{
	public readonly OpenResultStatus Status;

	public readonly int HitItemIndex;

	public readonly bool IsItemCompleted;

	public OpenResult(OpenResultStatus status, int hitItemIndex = -1, bool isItemCompleted = false)
	{
		Status = default(OpenResultStatus);
		HitItemIndex = 0;
		IsItemCompleted = false;
	}

	public bool IsSuccessOpen()
	{
		return false;
	}
}
