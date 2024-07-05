using WordCounterApp.Services;

namespace WordCounterApp
{
  internal abstract class Program
  {
    private static void Main(string[] args)
    {
      var analyzer = new TextAnalyzer();
            
      while (true)
      {
        Console.WriteLine("Enter text:");
        var input = Console.ReadLine();

        var (letterCount, digitCount) = analyzer.Analyze(input);

        Console.WriteLine($"Number of letters: {letterCount}");
        Console.WriteLine($"Number of digits: {digitCount}");

        Console.WriteLine("Do you want to continue? (yes/no)");
        var response = Console.ReadLine()?.ToLower();

        if (response != "yes")
        {
          break;
        }
      }
    }
  }
}