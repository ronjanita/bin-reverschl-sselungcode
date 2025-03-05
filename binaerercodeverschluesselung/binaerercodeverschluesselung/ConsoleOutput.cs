namespace binaerercodeverschluesselung_RoNi
{
    class ConsoleOutput
    {
        public ConsoleOutput()
        {
            GeneratedText();
        }
        public static void GeneratedText()
        {
            Console.WriteLine("Welcome to this binary encryption/ decryption program!");
            Console.WriteLine("Would you like to encrypt(E) or decrypt(D) ?");
            string UserInput = Console.ReadLine();
            if (UserInput == "E")
            {
                Console.WriteLine("Enter the text that you want to encrypt:");
                string input = Console.ReadLine();
                TextToBinary textToBinary = new TextToBinary(input);
                Console.WriteLine($"Your generated ecryption is: {textToBinary.converted} ");
            }
            if (UserInput == "D")
            {
                Console.WriteLine("Enter the binary code that you want to decrypt:");
                string input = Console.ReadLine();
                BinaryToText binaryToText = new BinaryToText(input);
                Console.WriteLine("Your generated decryption is:" + binaryToText.converted);
            }
            else
            {
                Console.WriteLine("Invalid input. please try again.");
            }
        }
    }
}
