[Command("clickElement")]
public class TpClickElementParams : BaseTpObjectParams
{
	public int count;

	public float interval;

	public bool wait;

	public TpClickElementParams(TpObject TpObject, int count, float interval, bool wait)
		: base(null)
	{
	}
}
