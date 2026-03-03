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
	}

	protected override void OnDisable()
	{
	}

	public void SetSeasonalTheme(int seasonResourceIdx)
	{
	}
}
