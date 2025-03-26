using System;

public class Menu
{
    
    public void DisplayMainMenu()
    {
        string menu = @"
==== Welcome to 40K Binary Converter ====

1. Binary to string
2. String to binary
3. Exit

Choose menu number (1-3)

==== Glory to the Machine God! ====
";
        
        Console.WriteLine(menu);
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                break;

            case "2":
                break;

            case"3": //Fermeture du programme
                Console.Clear();
                Console.WriteLine("Praise the Omnissiah!");
                Environment.Exit(0);
                break;
        }
    }
    
    
}