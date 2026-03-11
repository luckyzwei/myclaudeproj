using UnityEngine;
using UnityEngine.UI;

namespace KWLocalisation.Localisation
{
	public sealed class TextMeshProWrapper : TextWrapper
	{
		[SerializeField]
		private Text m_textComponent;

		public override void SetText(string text)
		{
			if (m_textComponent != null)
				m_textComponent.text = text;
		}

		public override string GetText()
		{
			return m_textComponent != null ? m_textComponent.text : null;
		}

		public override void SetTextComponent(Graphic textComponent)
		{
			m_textComponent = textComponent as Text;
		}

		public override Graphic GetTextComponent()
		{
			return m_textComponent;
		}

		public override void SetColor(Color color)
		{
			if (m_textComponent != null)
				m_textComponent.color = color;
		}

		public override Color GetColor()
		{
			return m_textComponent != null ? m_textComponent.color : Color.white;
		}

		public override object GetFont()
		{
			return m_textComponent != null ? m_textComponent.font : null;
		}

		public override void SetFont(object font)
		{
			if (m_textComponent != null && font is Font tmpFont)
				m_textComponent.font = tmpFont;
		}
	}
}
