using System;


namespace _40KBinaryConverter
{
    internal class Menu
    {

        internal static void DisplayMainMenu()
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
                    string binaryOutput = ConvertBytesToBinary(ConvertStringToBytes(CollectInputString())); //Conversion string > bytes ASCII > binaire
                    Console.WriteLine(" Conversion finished. Output is : \n" + binaryOutput);
                    string jsonSerialized = ConversionEngine.SerializeToJson(binaryOutput);
                    Console.WriteLine("DEBUG - JSON content is : " + jsonSerialized);
                    ConversionEngine.ExportToJsonFile(jsonSerialized);

                    //Implémenter le choix plus tard
                    //Console.WriteLine("Preserve the data ? (Y/N)");
                    //string subchoice = Console.ReadLine();


                    break;

                case "3": //Fermeture du programme
                    Console.Clear();
                    Console.WriteLine("Praise the Omnissiah!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalide user input. Please try again.");
                    break;
            }
        }

        private static string CollectInputString()
        {
            Console.Clear();
            Console.WriteLine("Enter string to be converted");
            string inputString = Console.ReadLine();
            if (inputString != null)
            {
                Console.WriteLine("\nAcknowledged. Processing input string : \"" + inputString + "\"");
                return inputString;
            }
            else
            {
                Console.WriteLine("ERROR : Input string is empty");
                return string.Empty;
            }
        }

        private static byte[] ConvertStringToBytes(string inputString)
        {
            byte[] outputbytes = ConversionEngine.ConvertStringToAsciiBytes(inputString);
            Console.WriteLine("\nConverting string to bytes... Done. Output is : ");
            string bytesString = "";
            foreach (byte b in outputbytes)
            {
                bytesString = bytesString + ", " + b;
            }
            Console.WriteLine(bytesString);
            return outputbytes;
        }
        private static string ConvertBytesToBinary(byte[] inputBytes)
        {
            //Console.WriteLine("\nConverting bytes to binary... Done. Output is : ");
            string convertedBinaryString = ConversionEngine.ConvertAsciiBytesToBinary(inputBytes);
            //Console.WriteLine(convertedBinaryString);
            
            return convertedBinaryString;

        }



    }
}