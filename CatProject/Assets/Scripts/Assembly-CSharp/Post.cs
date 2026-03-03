using System.Collections.Generic;

public class Post
{
	public struct PostReward
	{
		public int idx;

		public string name;

		public int reward_type;

		public int reward_idx;

		public int grade;

		public int reward_region;
	}

	public bool isCanReceive;

	public string title;

	public string content;

	public string inDate;

	public string expirationDate;

	public string sentDate;

	public Dictionary<PostReward, int> postRewardDic;

	public override string ToString()
	{
		return null;
	}
}
