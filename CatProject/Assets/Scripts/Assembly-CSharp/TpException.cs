using UnityEngine.ResourceManagement.AsyncOperations;

public static class TpException
{
	public static bool IsValid<T>(in T value) where T : class
	{
		return false;
	}

	public static bool IsValidCondition(in bool condition)
	{
		return false;
	}

	public static bool IsValidAddressableResult(in AsyncOperationHandle handle)
	{
		return false;
	}
}
