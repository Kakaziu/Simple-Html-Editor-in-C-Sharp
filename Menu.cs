public static class Menu {
  public static void Show() {
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.White;

    DrawnScreen();
    WriteOptions();

    short option = short.Parse(Console.ReadLine());
  
    HandleOptions(option);
  }

  private static void DrawnScreen() {
    int columns = 50;
    int rows = 20;
    
    DrawnEdge(columns);
    DrawnLines(columns, rows);
    DrawnEdge(columns);
  }

  private static void DrawnEdge(int columns) {
    Console.Write("+");
    for (int i = 0; i < columns; i++) {
      Console.Write("-");
    }
    Console.Write("+");
    Console.Write("\n");
  }

  private static void DrawnLines(int columns, int rows) {
    for(int lines = 0; lines < rows; lines++) {
      Console.Write("|");
      for(int i = 0; i < columns; i++) 
        Console.Write(" ");

      Console.Write("|");
      Console.Write("\n");
    }
  }

  private static void WriteOptions() {
    Console.SetCursorPosition(2, 2);
    Console.WriteLine("EDITOR HTML");
    Console.SetCursorPosition(2, 4);
    Console.WriteLine("Selecione uma opção: ");
    Console.SetCursorPosition(2, 6);
    Console.WriteLine("1 - Novo arquivo");
    Console.SetCursorPosition(2, 7);
    Console.WriteLine("2 - Visualizar arquivo");
    Console.SetCursorPosition(2, 8);
    Console.WriteLine("0 - Sair do sistema");
    Console.SetCursorPosition(2, 10);
    Console.Write("Opção: ");
  }

  private static void HandleOptions(short option) {
    switch(option) {
      case 0: System.Environment.Exit(0); break;
      case 1: Console.WriteLine("Modo editor"); break;
      case 2: Console.WriteLine("Modo visualizador"); break;
      default: Menu.Show(); break;
    }
  }
}