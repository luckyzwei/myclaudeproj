using System;
using System.Collections.Generic;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JigsawPuzzleCell : MonoBehaviour
{
	private const string ANIM_JIGSAW_ANIMATION = "Jigsaw-Animation";

	private const float PUNCH_SCALE_MULT = 0.05f;

	private const float PUNCH_SCALE_TIME = 0.5f;

	private const string ANIM_ANIM_JIGSAWSHINE = "Anim-JigsawShine";

	private const string ANIM_ANIM_JIGSAWSHINEHIDDEN = "Anim-JigsawShineHidden";

	private const string ANIM_ANIM_JIGSAWSHINE_HAND = "Anim-JigsawShine&Hand";

	private const string ANIM_ANIM_IDLE = "Anim-Idle";

	private const string ANIM_ANIM_AVAILABLE = "Anim-Available";

	private const string ANIM_ANIM_COLLECTED = "Anim-Collected";

	private const string ANIM_ANIM_JIGSAWCOMPLETE_TRANSITION = "Anim-JigsawComplete-Transition";

	[SerializeField]
	private Image m_puzzleImage;

	[SerializeField]
	private RectTransform m_piecesParent;

	[SerializeField]
	private Image m_bgImage;

	[SerializeField]
	private Image m_progressBar;

	[SerializeField]
	private GameObject m_loadingWidget;

	[SerializeField]
	private RectTransform m_rectTransform;

	[SerializeField]
	private AnimatorHelper m_progressBarAnimator;

	[SerializeField]
	private TextMeshProUGUI m_progressBarTMP;

	[SerializeField]
	private GameObject m_notification;

	[SerializeField]
	private Button m_puzzleBGButton;

	[SerializeField]
	private AnimatorHelper m_cellAnimatorHelper;

	[SerializeField]
	private Image m_rewardIcon;

	[SerializeField]
	private SkeletonGraphic m_skeletonGraphic;

	[SerializeField]
	private SpineAnimatorHelper m_spineAnimatorHelper;

	private static float s_lastSfxTime;

	protected string m_clientID;

	private List<Transform> m_newPieces;

	private Action m_doneCallback;

	private JigsawGenerator m_jigsawGenerator;

	private List<GameObject> m_allPieces;

	private Vector2Int m_puzzleSize;

	private int m_totalPiecesCount;

	private int m_collectedPiecesCount;

	private int m_visitedPiecesCount;

	private bool m_isCompleted;

	private int m_newlyCollectedPiecesCount;

	private SkeletonDataAsset m_skeletonDataAsset;

	private Texture2D m_puzzleGraphics;

	private Action m_puzzleClickedCallback;

	private bool m_initialised;

	public bool NewPieceFlowComplete => false;

	public RectTransform ScrollTargetRectTrasnform => null;

	public string ClientID => null;

	public bool IsComplete => false;

	public virtual void Config(string clientID, Action done)
	{
	}

	protected virtual void SetPuzzle(Action done, Texture2D puzzleGraphics)
	{
	}

	private void PiecesGenerated()
	{
	}

	public bool HasAnyProgress()
	{
		return false;
	}

	public void ClearNewPieces()
	{
	}

	public int GetNewPiecesCount()
	{
		return 0;
	}

	public static Sprite ConvertTextureToSprite(Texture2D texture)
	{
		return null;
	}

	public void Reload()
	{
	}

	private void DisableLoading()
	{
	}

	public Transform GetNewPieceTransform(int pieceIndex)
	{
		return null;
	}

	public void ShowNewPiece(float pitch)
	{
	}

	private void SwapFullImage()
	{
	}

	private void DoCompletedPulse()
	{
	}

	private bool IsClaimed()
	{
		return false;
	}

	public void SetClaimed()
	{
	}

	public void OnPlayerPuzzleClicked()
	{
	}

	public void OnPuzzleClicked(Action callback = null)
	{
	}

	private void OnCompletePopUpClosed()
	{
	}

	protected void EnableSkeletonAnimation()
	{
	}

	private void OnEnable()
	{
	}

	public void OnReopenMenuTab()
	{
	}

	private void UpdateAndCheckCompletion()
	{
	}

	private void OnDisable()
	{
	}

	public void ShowNotification()
	{
	}

	public void PlayTransitionAnimation()
	{
	}

	public void PlayDefaultAnimation()
	{
	}
}
