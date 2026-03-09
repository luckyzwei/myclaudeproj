using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Balancy.Data;

public class UserProfile
{
	public delegate void UserProfileDelegate(ParentBaseData userProfile);

	private static Dictionary<Type, ParentBaseData> s_typeUserProfileInstances;

	private static List<object> s_templateReferences;

	public static event UserProfileDelegate OnUserProfileLoaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void Register<T>() where T : ParentBaseData, new()
	{
	}

	public static T Get<T>() where T : ParentBaseData
	{
		return null;
	}

	private static void OnSmartObjectLoaded<T>(TemplatedUserProfile<T> userProfile) where T : ParentBaseData, new()
	{
	}
}
