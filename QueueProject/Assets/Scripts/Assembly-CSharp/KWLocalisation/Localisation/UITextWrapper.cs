using UnityEngine;
using UnityEngine.UI;

namespace KWLocalisation.Localisation
{
	public sealed class UITextWrapper : TextWrapper
	{
		[SerializeField]
		private Text m_textComponent;

		public override void SetText(string text)
		{
		}

		public override string GetText()
		{
			return null;
		}

		public override void SetTextComponent(Graphic textComponent)
		{
		}

		public override Graphic GetTextComponent()
		{
			return null;
		}

		public override void SetColor(Color color)
		{
		}

		public override Color GetColor()
		{
			return default(Color);
		}

		public override object GetFont()
		{
			return null;
		}

		public override void SetFont(object font)
		{
		}
	}
}
