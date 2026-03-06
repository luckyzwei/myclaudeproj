using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class BlurDimComponent : MonoBehaviour
{
	private RawImage BlurBG;

	private void SetBlurBG()
	{
		if (BlurBG == null) BlurBG = GetComponent<RawImage>();
		if (BlurBG != null) BlurBG.enabled = true;
	}

	private void ClearBlurBG()
	{
		if (BlurBG != null) BlurBG.enabled = false;
	}

	private void OnEnable()
	{
		SetBlurBG();
	}

	private void OnDisable()
	{
		ClearBlurBG();
	}
}
