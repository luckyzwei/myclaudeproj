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
			type = _type;
			idx = _idx;
			region = _region;
			grade = _grade;
			count = _count;
		}

		public Article(int _type, int _idx, int _region, int _count)
		{
			type = _type;
			idx = _idx;
			region = _region;
			grade = 0;
			count = _count;
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
		if (receiveBtn != null)
			receiveBtn.onClick.AddListener(OnClickReceive);
	}

	public void Init(Post post)
	{
		postData = post;
		if (post == null) return;
		if (content != null)
			content.text = post.content ?? string.Empty;
		if (date != null)
			date.text = post.sentDate ?? string.Empty;
		if (expire != null)
			expire.text = post.expirationDate ?? string.Empty;
		if (receiveBtn != null)
			receiveBtn.gameObject.SetActive(post.isCanReceive);
	}

	private void OnClickReceive()
	{
		if (postData == null) return;
	}
}
