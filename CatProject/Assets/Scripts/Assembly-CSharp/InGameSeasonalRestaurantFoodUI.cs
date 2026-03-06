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
		Disposables = new CompositeDisposable();
		FoodProductIdx = buildingIdx;
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	private void SetFoodIconImage(string imageKey)
	{
		// Update display
	}

	private void OnChangedFoodValue(int hasValue, int maxValue)
	{
		MaxHasValue = maxValue;
		if (FoodHasValueText != null)
			FoodHasValueText.text = hasValue + "/" + maxValue;
	}
}
