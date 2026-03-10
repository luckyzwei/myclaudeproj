public class BitwiseFlag
{
	private int m_number;

	public bool this[int index]
	{
		get
		{
			return (m_number & (1 << index)) != 0;
		}
		set
		{
			if (value)
				m_number |= (1 << index);
			else
				m_number &= ~(1 << index);
		}
	}

	public static BitwiseFlag FromInt(int n)
	{
		return new BitwiseFlag(n);
	}

	public BitwiseFlag(int number = 0)
	{
		m_number = number;
	}

	public int ToInt()
	{
		return m_number;
	}

	public void LoadInt(int number)
	{
		m_number = number;
	}

	public static string GetBinary(int number)
	{
		return System.Convert.ToString(number, 2);
	}

	public void Clear()
	{
		m_number = 0;
	}
}
