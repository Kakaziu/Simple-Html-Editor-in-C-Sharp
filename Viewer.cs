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
    var htmlTag = new Regex(@"<[^>]+>");
    var words = text.Split(" ");

    for (int i = 0; i < words.Length; i++) {
      if(htmlTag.IsMatch(words[i])) {
        Console.Write(
          words[i].Substring(1, words[i].IndexOf('>') - 1)
        );
      }
    }
  }
}