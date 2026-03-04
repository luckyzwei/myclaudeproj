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

	public int DecoIdx { get { return 0; } }

	public void Init(int idx)
	{
	}

	public void SetCnt(int cnt, bool showEffect = false)
	{
	}
}
