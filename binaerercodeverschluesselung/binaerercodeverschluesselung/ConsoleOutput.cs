namespace binaerercodeverschluesselung_RoNi
{
    class ConsoleOutput
    {
        public static void GeneratedText(BinaryToText binaryToText, TextToBinary textToBinary)
        {
            Console.WriteLine("Welcome to this binary encryption/ decryption program!");
            Console.WriteLine("Would you like to encrypt(E) or decrypt(D) ?");
            string UserInput = Console.ReadLine();
            if (UserInput == "E")
            {
                Console.WriteLine("Enter the binary code that you want to encrypt:");
                Console.WriteLine($"Your generated ecryption is: {textToBinary} ");
            }
            if (UserInput == "D")
            {
                Console.WriteLine($"Your generated decryption is {binaryToText} ");
            }
            else
            {
                Console.WriteLine("Invalid input. please try again.");
            }
        }
    }
}
