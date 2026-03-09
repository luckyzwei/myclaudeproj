using UnityEngine.UI;

namespace KWCore.UI
{
	public class NonDrawingGraphic : Graphic
	{
		public override void SetMaterialDirty()
		{
		}

		public override void SetVerticesDirty()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
