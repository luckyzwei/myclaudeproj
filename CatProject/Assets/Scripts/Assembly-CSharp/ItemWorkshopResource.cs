using UnityEngine;
using UnityEngine.UI;

public class ItemWorkshopResource : MonoBehaviour
{
	[SerializeField]
	private Image IconImage;

	[SerializeField]
	private Text ValueText;

	[SerializeField]
	private Button ShortCutBtn;

	[SerializeField]
	private GameObject HighlightFxObj;

	[SerializeField]
	private GameObject LeakReddot;

	public int ProductIdx { get; private set; }

	public bool IsCostResource { get; private set; }

	public bool IsEnoughResource { get; private set; }

	private void Awake()
	{
		if (ShortCutBtn != null)
			ShortCutBtn.onClick.AddListener(OnClickedShortCutButton);
	}

	public void SetWorkshopProductInfo(int productIdx, bool isCost)
	{
		ProductIdx = productIdx;
		IsCostResource = isCost;
	}

	public void SetResourceInfo(Config.AtlasType atlasType, string iconPath, string valueText)
	{
		SetResourceIcon(atlasType, iconPath);
		SetResourceValue(valueText);
	}

	public void SetResourceIcon(Config.AtlasType atlasType, string iconPath)
	{
		if (IconImage != null)
		{
			Sprite sprite = Resources.Load<Sprite>(iconPath);
			if (sprite != null) IconImage.sprite = sprite;
		}
	}

	public void SetResourceValue(string valueStr)
	{
		if (ValueText != null)
			ValueText.text = valueStr;
	}

	public void SetIsEnoughResource(bool isEnoughRes)
	{
		IsEnoughResource = isEnoughRes;
		if (LeakReddot != null)
			LeakReddot.SetActive(!isEnoughRes && IsCostResource);
		if (ValueText != null)
			ValueText.color = isEnoughRes ? Color.white : Color.red;
	}

	public void ShowHighlightFx()
	{
		if (HighlightFxObj != null)
			HighlightFxObj.SetActive(true);
	}

	private void OnClickedShortCutButton()
	{
		// Navigate to the source of this resource
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}
}
