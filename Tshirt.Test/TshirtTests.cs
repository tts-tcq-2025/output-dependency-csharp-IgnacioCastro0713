namespace Tshirt.Test;

public class TshirtTests
{
	[Theory]
	[InlineData(37, "S")]
	[InlineData(40, "M")]
	[InlineData(43, "L")]
	public void Size_KnownExamples_Pass(int cms, string expected)
	{
		Assert.Equal(expected, TshirtSpace.Tshirt.Size(cms));
	}

	[Fact]
	public void Size_AtLowerBoundaryOfM_ReturnsM()
	{
		Assert.Equal("M", TshirtSpace.Tshirt.Size(38));
	}

	[Theory]
	[InlineData(42, "L")]
	[InlineData(41, "M")]
	[InlineData(0, "S")]
	public void Size_Boundaries_BehaveAsSpecified(int cms, string expected)
	{
		Assert.Equal(expected, TshirtSpace.Tshirt.Size(cms));
	}
}