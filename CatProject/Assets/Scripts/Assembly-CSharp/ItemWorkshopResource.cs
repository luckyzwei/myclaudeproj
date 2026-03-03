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
	}

	public void SetWorkshopProductInfo(int productIdx, bool isCost)
	{
	}

	public void SetResourceInfo(Config.AtlasType atlasType, string iconPath, string valueText)
	{
	}

	public void SetResourceIcon(Config.AtlasType atlasType, string iconPath)
	{
	}

	public void SetResourceValue(string valueStr)
	{
	}

	public void SetIsEnoughResource(bool isEnoughRes)
	{
	}

	public void ShowHighlightFx()
	{
	}

	private void OnClickedShortCutButton()
	{
	}
}
