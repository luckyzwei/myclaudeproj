using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrophyWidget : MonoBehaviour
{
	[SerializeField]
	private Image m_bgImage;

	[SerializeField]
	private Image m_fillImage;

	[SerializeField]
	private TMP_Text m_monthName;

	[SerializeField]
	private TMP_Text m_daysText;

	[SerializeField]
	private Image m_bar;

	[Space]
	[SerializeField]
	private GameObject m_progressBar;

	[SerializeField]
	private GameObject m_completed;

	private int m_month;

	private int m_year;

	public event Action<int, int> Clicked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Config(int year, int month, Sprite trophySprite, Sprite emptySprite)
	{
	}

	public void OnClicked()
	{
	}
}
