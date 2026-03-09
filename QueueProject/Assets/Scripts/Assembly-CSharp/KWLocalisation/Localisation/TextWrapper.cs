using UnityEngine;
using UnityEngine.UI;

namespace KWLocalisation.Localisation
{
	public abstract class TextWrapper : MonoBehaviour
	{
		public abstract void SetText(string text);

		public abstract string GetText();

		public abstract void SetTextComponent(Graphic textComponent);

		public abstract Graphic GetTextComponent();

		public abstract void SetColor(Color color);

		public abstract Color GetColor();

		public abstract object GetFont();

		public abstract void SetFont(object font);
	}
}
