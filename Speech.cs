namespace knightmoves;
public class Speech
{   
    public const string Quote = "...ask not what your country can do for you — ask what you can do for your country.";

    public string PrintLengthAndTwentySecondLetter(){
        //Add your code here
        int Length = Quote.Length;
        char TwentySecondLetter = Quote[21];
        string Final = $@"{Length} + {TwentySecondLetter}";
        return Final;
    }
}




















