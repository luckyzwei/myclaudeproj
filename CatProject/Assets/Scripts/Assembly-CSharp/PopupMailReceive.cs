using System.Collections.Generic;
using Treeplla;
using UnityEngine;

[UIPath("UI/Popup/PopupMailReceive", false, false)]
public class PopupMailReceive : UIBase
{
	private struct Article
	{
		public int type;

		public int idx;

		public int grade;

		public int count;

		public int region;

		public Article(int _type, int _idx, int _grade, int _count, int _region)
		{
			type = 0;
			idx = 0;
			grade = 0;
			count = 0;
			region = 0;
		}

		public Article(int _type, int _idx, int _count, int _region)
		{
			type = 0;
			idx = 0;
			grade = 0;
			count = 0;
			region = 0;
		}
	}

	[SerializeField]
	private List<ItemArticle> itemArticles;

	public void Init(Post post)
	{
		// Initialize
	}
}
