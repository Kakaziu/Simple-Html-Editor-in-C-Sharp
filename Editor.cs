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
      file.Append(Console.ReadLine());
      file.Append(Environment.NewLine);
    } while(Console.ReadKey().Key != ConsoleKey.Escape);
  
    Console.WriteLine("Deseja salvar o arquivo? (s = sim | n = não)");
    char option = Convert.ToChar(Console.ReadLine());

    if(option == 's') Viewer.Show(file.ToString());
    else Console.WriteLine("Não salvo");
  }
}