using binaerercodeverschluesselung_RoNi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaerercodeverschluesselung
{
    class ConsoleOutput
    {
        public static void GeneratedText(BinaryToText binaryToText, TextToBinary textToBinary)
        {
            Console.WriteLine("Welcome to this binary encryption/ decryption program!");
            Console.WriteLine("Would you like to encrypt(E) or decrypt(D) ?");
            string EncDec = Console.ReadLine();
            if (EncDec == "E")
            {
                Console.WriteLine($"Your generated ecryption is: {binaryToText} ");
            }
            if (EncDec == "D")
            {
                Console.WriteLine($"Your generated decryption is {textToBinary} ");
            }
            else
            {
                Console.WriteLine("Invalid input. please try again.");
            }
        }
    }
}
