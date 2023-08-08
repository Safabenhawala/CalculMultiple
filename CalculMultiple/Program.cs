using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculMultiple
{
    class Program
    {
        static void Main(string[] args)
        {

            Multiple multiple = new Multiple();
            string cheminFichier = $"C:/Users/safa/Documents/test_Essai/Resultat_C.txt"; 


            string restultat = multiple.Multiple_3(3);

            Console.WriteLine(restultat);

            // Écrire le résultat dans le fichier
            using (StreamWriter writer = new StreamWriter(cheminFichier, true)) // Le deuxième argument "true" indique d'ajouter du contenu sans écraser le fichier existant
            {
                writer.WriteLine(restultat);
            }


        }
    }
}
