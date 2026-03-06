using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageSeasonalQuestGuide", false, false)]
public class PageSeasonalQuestGuide : UIBase
{
	[SerializeField]
	private Text textStep1;

	[SerializeField]
	private Text textStep2;

	protected override void Awake()
	{
		base.Awake();
	}
}
