using UnityEngine;
using UnityEngine.UI;

public class ItemSpecialEvent2 : MonoBehaviour
{
	[SerializeField]
	private Animator ItemAnimator;

	[SerializeField]
	private Image EmptyImg;

	[SerializeField]
	private Image IconImg;

	[SerializeField]
	private Text cntText;

	[SerializeField]
	private GameObject effectObj;

	private int decoIdx;

	private int curCnt;

	public int DecoIdx { get { return decoIdx; } }

	public void Init(int idx)
	{
		decoIdx = idx;
		curCnt = 0;
		if (cntText != null) cntText.text = "0";
		if (effectObj != null) effectObj.SetActive(false);
	}

	public void SetCnt(int cnt, bool showEffect = false)
	{
		curCnt = cnt;
		if (cntText != null) cntText.text = cnt.ToString();
		if (effectObj != null) effectObj.SetActive(showEffect);
		if (showEffect && ItemAnimator != null) ItemAnimator.SetTrigger("Play");
	}
}
