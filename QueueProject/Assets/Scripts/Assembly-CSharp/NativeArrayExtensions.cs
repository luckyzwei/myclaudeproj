using Unity.Collections;

public static class NativeArrayExtensions
{
	public static NativeArray<T> ToNativeArray<T>(this T[] array, Allocator allocator) where T : struct
	{
		return default(NativeArray<T>);
	}
}
