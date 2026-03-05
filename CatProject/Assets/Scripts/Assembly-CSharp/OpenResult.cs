public readonly struct OpenResult
{
	public readonly OpenResultStatus Status;

	public readonly int HitItemIndex;

	public readonly bool IsItemCompleted;

	public OpenResult(OpenResultStatus status, int hitItemIndex = -1, bool isItemCompleted = false)
	{
		Status = status;
		HitItemIndex = hitItemIndex;
		IsItemCompleted = isItemCompleted;
	}

	public bool IsSuccessOpen()
	{
		return Status == OpenResultStatus.HitEmpty || Status == OpenResultStatus.HitItem;
	}
}
