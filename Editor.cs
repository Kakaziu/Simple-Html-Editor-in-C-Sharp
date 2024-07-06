using System.Text;

public static class Editor {
  public static void Show() {
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("MODO EDITOR (Pressione ESC para sair)");
    Console.WriteLine("------------------");
    Start();
  }

  private static void Start() {
    var file = new StringBuilder();
    
    do{

    } while(Console.ReadKey().Key != ConsoleKey.Escape);
  }
}