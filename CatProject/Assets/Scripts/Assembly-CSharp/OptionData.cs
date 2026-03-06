using System;

[Serializable]
public class OptionData : IReadOnlyData, ICloneable
{
	public bool BGM { get; set; }

	public bool Effect { get; set; }

	public bool Notifi { get; set; }

	public bool SlowGraphic { get; set; }

	public bool Vibration { get; set; }

	public void Create()
	{
		// TODO
	}

	public object Clone()
	{
		return MemberwiseClone();
	}
}
