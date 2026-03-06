public class InAppPackageData
{
	public string ProductId;

	public int SaleValue;

	public static InAppPackageData FromShopSpecial(int shopSpecialIdx)
	{
		var data = new InAppPackageData();
		return data;
	}
}
