using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(Animator))]
public class PlayAnimationOnEnable : MonoBehaviour
{
	[SerializeField]
	private AnimationClip animationClip;

	private PlayableGraph playableGraph;

	private void OnEnable()
	{
		var animator = GetComponent<Animator>();
		if (animator != null) animator.Play(0);
	}

	private void OnDisable()
	{
		// Disabled
	}
}
