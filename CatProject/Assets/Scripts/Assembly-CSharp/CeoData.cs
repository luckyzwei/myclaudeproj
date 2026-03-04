public class CeoData : IClientData
{
	public int CeoIdx;

	public string _CeoName;

	public string _CompanyName;

	public string CeoName
	{
		get
		{
			return _CeoName;
		}
		set
		{
			_CeoName = value;
		}
	}

	public string CompanyName
	{
		get
		{
			return _CompanyName;
		}
		set
		{
			_CompanyName = value;
		}
	}
}
