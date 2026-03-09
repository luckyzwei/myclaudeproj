using UnityEngine;

public interface IScrollItemRecyclable
{
	int DataIndex { get; set; }

	RectTransform GetRectTransform();
}
