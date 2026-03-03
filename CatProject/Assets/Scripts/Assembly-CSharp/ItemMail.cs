using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMail : MonoBehaviour
{
	private struct Article
	{
		public int type;

		public int idx;

		public int region;

		public int grade;

		public int count;

		public Article(int _type, int _idx, int _region, int _grade, int _count)
		{
			type = 0;
			idx = 0;
			region = 0;
			grade = 0;
			count = 0;
		}

		public Article(int _type, int _idx, int _region, int _count)
		{
			type = 0;
			idx = 0;
			region = 0;
			grade = 0;
			count = 0;
		}
	}

	[SerializeField]
	private Text date;

	[SerializeField]
	private Text expire;

	[SerializeField]
	private Text content;

	[SerializeField]
	private Button receiveBtn;

	[SerializeField]
	private List<ItemArticle> itemArticles;

	private Post postData;

	private void Awake()
	{
	}

	public void Init(Post post)
	{
	}

	private void OnClickReceive()
	{
	}
}
