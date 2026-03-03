using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/Seasonal/ItemSeasonalFood", true)]
[FloatingDepth(11)]
public class InGameSeasonalRestaurantFoodUI : InGameFloatingUI
{
	[SerializeField]
	private Image FoodIconImage;

	[SerializeField]
	private Text FoodHasValueText;

	private int FoodProductIdx;

	private int MaxHasValue;

	private CompositeDisposable Disposables;

	public void Init(int buildingIdx)
	{
	}

	private void OnDestroy()
	{
	}

	private void SetFoodIconImage(string imageKey)
	{
	}

	private void OnChangedFoodValue(int hasValue, int maxValue)
	{
	}
}
