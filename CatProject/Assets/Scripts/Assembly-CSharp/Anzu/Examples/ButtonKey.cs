using UnityEngine;
using UnityEngine.UI;

namespace Anzu.Examples
{
	[ExecuteInEditMode]
	public class ButtonKey : MonoBehaviour
	{
		[SerializeField]
		private string buttonText;

		[SerializeField]
		private InputType inputType;

		[Header("References")]
		[SerializeField]
		private Sprite[] iconOptions;

		[SerializeField]
		private Text buttonTextObj;

		[SerializeField]
		private Image buttonIconObj;

		private Button button;

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		private void GetInputPC()
		{
		}

		private void GetInputConsole()
		{
		}
	}
}
