

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S - Segundos");
        Console.WriteLine("M - Minuto");
        Console.WriteLine("0 - Sair");
        char n = char.Parse(Console.ReadLine());
        if (n == 0) { Environment.Exit(0); }
        Console.WriteLine("Quanto tempo deseja contar?");
        int segundos = int.Parse(Console.ReadLine().ToLower());

        if (n == 's')
        {
            Start(segundos);
        }
        else if (n == 'm')
        {
            Start(segundos * 60);
        }

    }


    static void Start(int time)
    {
        Console.Clear();

        int currentTime = 0;

        while (currentTime < time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); // Processador dormir por 1 segundo.
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado.");
        Thread.Sleep(2000);
        Menu();
    }
}