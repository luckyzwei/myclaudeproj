using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using KWAudio;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class JigsawPuzzleCompletedCell : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSequentialRevealPuzzle_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JigsawPuzzleCompletedCell _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSequentialRevealPuzzle_003Ed__30(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const string ANIM_JIGSAW_ANIMATION = "Jigsaw-Animation";

	private const float CLOSE_BUTTON_DELAY = 1f;

	[SerializeField]
	protected Image m_puzzleImage;

	[Header("Reveal")]
	[SerializeField]
	private long m_smallRevealTimeMS;

	[SerializeField]
	private long m_mediumRevealTimeMS;

	[SerializeField]
	private long m_largeRevealTimeMS;

	[SerializeField]
	private AnimationCurve m_revealCurve;

	[SerializeField]
	private Ease m_individualPieceScaleEase;

	[SerializeField]
	private string m_subkey;

	[SerializeField]
	protected Color m_unfinishedColor;

	[SerializeField]
	private SkeletonGraphic m_skeletonGraphic;

	[SerializeField]
	private SpineAnimatorHelper m_spineAnimatorHelper;

	protected JigsawGenerator m_jigsawGenerator;

	protected string m_clientID;

	private Vector2Int m_puzzleSize;

	private List<GameObject> m_allPieces;

	private Action m_completeCallback;

	protected Texture2D m_puzzleTexture;

	private bool m_completeFlow;

	protected SkeletonDataAsset m_skeletonDataAsset;

	protected AudioClipReference m_puzzleSfx;

	public virtual void Config(string clientID, bool completeFlow, Action completeCallback)
	{
	}

	protected virtual void PrepareData()
	{
	}

	protected virtual void PreparePuzzle()
	{
	}

	protected virtual void ShowPainting(bool generateAtlas = false)
	{
	}

	public void ResetCell()
	{
	}

	private void OnPiecesGenerated()
	{
	}

	private void PreviewFlow()
	{
	}

	private void CompleteFlow()
	{
	}

	private float GetRevealTimeBasedOnPuzzleSize()
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CSequentialRevealPuzzle_003Ed__30))]
	private IEnumerator SequentialRevealPuzzle()
	{
		return null;
	}

	protected void EnableCompleteImage()
	{
	}

	public void ShowSkeletonSpineFlow(Action callback)
	{
	}

	protected void EnableSkeletonSpineAnimation(bool loop = true)
	{
	}

	private void OnScaledUp()
	{
	}

	public bool IsAnimated()
	{
		return false;
	}

	private void OnDestroy()
	{
	}
}
