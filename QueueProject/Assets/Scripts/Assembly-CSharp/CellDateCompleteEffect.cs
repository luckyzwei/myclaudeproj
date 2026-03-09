using System;
using UnityEngine;

public class CellDateCompleteEffect : MonoBehaviour
{
	private const string ANIM_CELL_DATECOMPLETEEFFECT_INTRO = "Cell-DateCompleteEffect-Intro";

	private const string ANIM_CELL_DATECOMPLETEEFFECT_OUTRO = "Cell-DateCompleteEffect-Outro";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	public void PlayIntro(Action completeCallback = null)
	{
	}

	public void PlayOutro(Action completeCallback = null)
	{
	}
}
