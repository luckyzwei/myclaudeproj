using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIEventPath("UI/Seasonal/PageLoadingSeasonal")]
public class LoadingSeasonal : LoadingBasic
{
	[SerializeField]
	private Image StatueImg;

	private int NowSeasonResourceIdx;

	private bool bFirstEnable;

	protected override void OnEnable()
	{
		base.OnEnable();
		if (!bFirstEnable)
		{
			bFirstEnable = true;
		}
	}

	protected override void OnDisable()
	{
		base.OnDisable();
	}

	public void SetSeasonalTheme(int seasonResourceIdx)
	{
		NowSeasonResourceIdx = seasonResourceIdx;
	}
}
