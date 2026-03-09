using System;
using UnityEngine;

public abstract class FeatureUnlockComponent : MonoBehaviour, IQueueableEntity
{
	[SerializeField]
	protected Sprite m_featureIcon;

	[SerializeField]
	protected string m_featureNameKey;

	[SerializeField]
	protected string m_featureDescriptionKey;

	[SerializeField]
	protected Transform m_receiverParent;

	[SerializeField]
	protected QueensQueue.UnlockLocation m_unlockLocation;

	[SerializeField]
	protected Transform m_receiverTransform;

	[SerializeField]
	protected TabToolbarButton m_tabButton;

	protected virtual void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void StartProcess(Action finishCallback)
	{
	}

	public virtual int GetPriority()
	{
		return 0;
	}

	public int GetUnlockLocationMask()
	{
		return 0;
	}

	public void TryShowFeatureUnlock()
	{
	}

	public virtual void ShowFeatureUnlockPopup(Action onFeatureUnlockComplete)
	{
	}

	protected abstract int UnlockLevel();

	protected abstract bool IsFeatureUnlocked();

	protected abstract void SetFeatureUnlocked();
}
