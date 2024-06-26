using System.Diagnostics;

namespace Algolia.Utils;

public class PlaygroundHelper
{
  public static async Task<T> Start<T>(string startMessage, Func<Task<T>> ac, string endMessage)
  {
    Console.WriteLine(startMessage);
    var stopwatch = new Stopwatch();
    stopwatch.Start();
    var waitResult = await ac().ConfigureAwait(false);
    stopwatch.Stop();
    Console.WriteLine($"  Task took {stopwatch.ElapsedMilliseconds}ms");
    Console.WriteLine(endMessage);
    return waitResult;
  }
  
  public static void Hello(string startMessage)
  {
    var currentForegroundColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"| {startMessage} |");
    Console.WriteLine("------------------------------------");
    Console.ForegroundColor = currentForegroundColor;
  }
  
}
