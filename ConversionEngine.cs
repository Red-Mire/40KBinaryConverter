using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _40KBinaryConverter
{
    internal class ConversionEngine
    {

        internal static byte[] ConvertStringToAsciiBytes(string inputString)
        {
            return Encoding.ASCII.GetBytes(inputString);
        }

        internal static string ConvertAsciiBytesToBinary(byte[] inputBytes)
        {
            string conversion = "";

            foreach (byte b in inputBytes)
            {
                string convertedByte = Convert.ToString(b, 2).PadLeft(8, '0');
                conversion = conversion + convertedByte;
            }
            return conversion;
        }

        internal static string SerializeToJson(string inputString)
        {
            if (inputString != null)
            {
                //A faire plus tard : 
                //Penser à la création du dossier si non existant
                //Penser à ajouter la phrase originale dans le paramètre SupplicantInput du json
                //Corriger le format non indenté du json et l'extension bizzare dans le nom de fichier

                var jsonfile = new JsonStructure
                {
                    Timestamp = DateTime.Now,
                    SupplicantInput = "Implementation WIP",
                    LinguaTechnis = inputString,
                    ThoughtForTheDay = "Quotes WIP..."
                };

                return JsonSerializer.Serialize(jsonfile);
            }
            else
            {
                Console.WriteLine("ERROR : JSON serialization failed. Input string is null.");
                return string.Empty;
            }

        }

        internal static void ExportToJsonFile(string jsonfile)
        {

            //Création du dossier d'export si il n'existe pas déjà
            string fullPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..","exports"));

            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }

            //Création du fichier à l'emplacement indiqué
            string fileName = "Lingua_Technis_Translation_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".json";
            File.WriteAllText(Path.Combine(fullPath, fileName), jsonfile);
        }

    }
}
