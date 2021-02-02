using System;

namespace Delegates
{
    class Program
    {

        static void Main(string[] args)
        {
            MusicGenre typeOfMusic = new MusicGenre();

            typeOfMusic.ShowMenu();

        }
    }
}
public class MusicGenre
{
    private Action musicAction;

    public void ShowMenu()
    {
        ConsoleKey key = ConsoleKey.Enter;

        while (key != ConsoleKey.E) {
            Console.WriteLine("A -> Gospel");
            Console.WriteLine("B -> R&B");
            Console.WriteLine("c -> Hip Hop");
            Console.WriteLine("D -> Rap");
            Console.WriteLine("E -> Exit");

            Console.WriteLine("");
            Console.WriteLine("Please select your favorite genre: ");
            key = Console.ReadKey().Key;

            switch(key){
                case ConsoleKey.A:
                    musicAction = Gospel;
                    break;
                case ConsoleKey.B:
                    musicAction = RBMusic;
                    break;
                case ConsoleKey.C:
                    musicAction = HipHop;
                    break;
                case ConsoleKey.D:
                    musicAction = Rap;
                    musicAction += RBMusic;
                    break;
            }
            handleMusic();
        }
    }
    public void Gospel()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("My favorite artist is Ricky Dillard");
    }
    public void RBMusic()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("This type of music is soothing");
    }
    public void HipHop()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("This type of music makes you dance");
    }
    public void Rap()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("I am a Biggie fan!");
    }
    public void handleMusic()
    {
        musicAction();
        
       
    }
}