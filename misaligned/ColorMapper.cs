namespace misaligned;

static class ColorMapper
{
	public static int Print(ColorPrinter printer)
	{
		int pair = 0;
		for (int i = 0; i < ColorData.Major.Length; i++)
		{
			for (int j = 0; j < ColorData.Minor.Length; j++)
			{
				printer(pair, ColorData.Major[i], ColorData.Minor[j]);
				pair++;
			}
		}
		return pair;
	}
}