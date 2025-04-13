using System;

namespace _40KBinaryConverter
{

    internal class Program
    {
        static void Main() //Méthode Main qui lance le programme
        {
            Console.ForegroundColor = ConsoleColor.Green; //Changement de la couleur de police de la console au lancement du programme

            Menu menu = new Menu();
            menu.DisplayMainMenu();
        }
    }
}