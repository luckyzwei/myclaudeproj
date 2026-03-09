using UnityEngine;

[CreateAssetMenu(fileName = "CountryIsoContainer", menuName = "Kwalee/KWNakama/LeaderboardCountryIsoContainer")]
public class CountryIsoContainer : ScriptableObject
{
	public const string PATH = "CountryIsoContainer";

	public CountryIsoData[] m_countryIsoDatas;

	public string m_localisationKeyPrefix;

	public string GetIso3(string iso2Code)
	{
		return null;
	}

	public string GetIso2(string iso3Code)
	{
		return null;
	}

	public string GetLocaleKey(string isoCode)
	{
		return null;
	}

	private string Convert(string isoCode)
	{
		return null;
	}
}
