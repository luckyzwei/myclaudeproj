using System;
using UnityEngine;

public class JigsawIapProgressPip : MonoBehaviour
{
	private const string ANIM_ANIM_JIGSAWPIP_LIT_01 = "Anim-JigsawPip-Lit-01";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Transform m_discountTransform;

	public void PlayAnimation(Transform target, Action onComplete)
	{
	}

	public void DisableDiscount()
	{
	}
}
