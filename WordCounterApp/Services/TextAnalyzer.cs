namespace WordCounterApp.Services;

public class TextAnalyzer
{
  public (int letterCount, int digitCount) Analyze(string input)
  {
    var letterCount = input.Count(char.IsLetter);
    var digitCount = input.Count(char.IsDigit);
    return (letterCount, digitCount);
  }
}