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
    Console.WriteLine(text);
  }
}