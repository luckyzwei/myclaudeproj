using System;
using System.Collections.Generic;
using BackEnd;
using LitJson;

public class BackendPost
{
	private static BackendPost _instance;

	public List<Post> postList;

	public static BackendPost Instance => null;

	public void SavePostToLocal(JsonData item)
	{
	}

	public int PostListGet(PostType postType)
	{
		return 0;
	}

	public void AsyncPostListGet(PostType postType, Action cbAction)
	{
	}

	public bool PostReceive(PostType postType, Post post)
	{
		return false;
	}

	public void AsyncPostReceive(PostType postType, Post post, Action cbAction)
	{
	}
}
