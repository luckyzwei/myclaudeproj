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
	}

	private void OnDisable()
	{
	}
}
