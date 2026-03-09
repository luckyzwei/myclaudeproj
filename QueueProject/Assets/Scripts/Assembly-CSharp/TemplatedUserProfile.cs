using System;
using Balancy.Data;

public class TemplatedUserProfile<T> where T : ParentBaseData, new()
{
	private T m_userProfile;

	private Action<TemplatedUserProfile<T>> m_responseCallback;

	public T UserProfile => null;

	public void AddResponseCallback(Action<TemplatedUserProfile<T>> callback)
	{
	}

	private void OnSmartObjectsInitializedEvent()
	{
	}

	private void OnSmartObjectLoaded(SmartObjectResponseData<T> responseData)
	{
	}
}
