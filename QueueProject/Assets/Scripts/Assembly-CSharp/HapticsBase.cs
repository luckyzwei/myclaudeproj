public abstract class HapticsBase
{
	public abstract bool IsSupported();

	public abstract void Trigger(int type);
}
