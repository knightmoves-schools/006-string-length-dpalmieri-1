namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Return_A_String_That_Contains_The_Length_Of_Quote_And_The_Twenty_Second_Character_In_The_Quote_From_The_Method_Named_PrintLengthAndTwentySecondLetter()
    {
        var speech = new Speech();

        Assert.True(speech.PrintLengthAndTwentySecondLetter().Contains("c"), "should return a string that contains the twenty-second character in the `Quote`");
        Assert.True(speech.PrintLengthAndTwentySecondLetter().Contains("83"), "should return a string that contains the twenty-second character in the `Quote`");
    }
}