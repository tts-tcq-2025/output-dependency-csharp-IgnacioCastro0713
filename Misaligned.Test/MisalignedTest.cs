namespace Misaligned.Test
{
	public class MisalignedTests
	{

		[Fact]
		public void PrintColorMap_Prints25Lines_And_Returns25()
		{
			var result = MisalignedSpace.Misaligned.printColorMap();
			Assert.Equal(25, result);
		}
	}
}