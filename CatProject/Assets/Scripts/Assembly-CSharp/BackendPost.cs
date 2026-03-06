using System;
using System.Collections.Generic;
using BackEnd;
using LitJson;

public class BackendPost
{
	private static BackendPost _instance;

	public List<Post> postList;

	public static BackendPost Instance
	{
		get
		{
			if (_instance == null)
				_instance = new BackendPost();
			return _instance;
		}
	}

	public BackendPost()
	{
		postList = new List<Post>();
	}

	public void SavePostToLocal(JsonData item)
	{
		if (item == null) return;
	}

	public int PostListGet(PostType postType)
	{
		if (postList == null) return 0;
		return postList.Count;
	}

	public void AsyncPostListGet(PostType postType, Action cbAction)
	{
		PostListGet(postType);
		cbAction?.Invoke();
	}

	public bool PostReceive(PostType postType, Post post)
	{
		if (post == null) return false;
		if (postList != null)
			postList.Remove(post);
		return true;
	}

	public void AsyncPostReceive(PostType postType, Post post, Action cbAction)
	{
		PostReceive(postType, post);
		cbAction?.Invoke();
	}
}
