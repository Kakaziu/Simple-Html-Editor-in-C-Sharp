using System.Text.RegularExpressions;

public static class Viewer {
  public static void Show(string text) {
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("MODO VISUALIZADOR");
    Console.WriteLine("------------------");
    Replace(text);
    Console.WriteLine("\n---------------");
    Console.ReadKey();
    Menu.Show();
  }

  public static void Replace(string text) {
     string patternTag = @"<\s*(\w+)[^>]*>";
     Match matchTag = Regex.Match(text, patternTag);

     if(matchTag.Success) {
      string tagName = matchTag.Groups[1].Value;
      string patternText = @"<[^>]+>(.*?)<\/[^>]+>";
      Match matchText = Regex.Match(text, patternText);
      string content = matchText.Groups[1].Value;

      IdentifiesTag(tagName, content);
     } 
  }

  public static void IdentifiesTag(string tag, string text) {
    switch(tag) {
      case "strong": ReplaceStrong(text); break;
    }
  }

  public static void ReplaceStrong(string text) {

  }
}