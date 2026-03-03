using System.Numerics;
using UniRx;

public class JewelryBoxUserData
{
	public BigInteger AccumulateValue { get; set; }

	public IReactiveProperty<int> Level { get; set; }

	public int StageStep { get; set; }

	public int StageLastShownStep { get; set; }
}
