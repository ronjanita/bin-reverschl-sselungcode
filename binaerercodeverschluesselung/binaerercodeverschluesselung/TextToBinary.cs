//namespace binaerercodeverschluesselung_RoNi
//{
//    internal class TextToBinary
//    {
//        public string converted = "";
//        public TextToBinary(string binTxt)
//        {
//            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };

//            int UserInput = Convert.ToInt32(binTxt);

//            for (int i = 0; i < binarynumbers.Length; i++)
//            {
//                char BinTxt = (char)binarynumbers[i];
//                if (char.IsLetter(BinTxt))
//                {
//                    converted += 1;
//                }
//            }
//        }
//    }
//}
//namespace binaerercodeverschluesselung_RoNi
//{
//    internal class TextToBinary
//    {
//        public string converted = "";

//        public TextToBinary(string userInput)
//        {
//            foreach (char currentSymbol in userInput)      //foreach macht das durch jedes zeichen von userInput durchegehen wird, currentSymbol speichert jedes Zeichen des Textes einzel
//            {
//                string convertedToBinary = Convert.ToString(currentSymbol, 2).PadLeft(8, '0');  //convert to string wandelt das currentSymbol in eine binärzahl um, die 2 ist dazu da dass die zahl im binären system dargestellt werden solll. Padleft ist dazu da das ergebniss immer 8 stellen haben soll und immer links noch auffülen mit 0 bisa 8
//                converted += convertedToBinary + " ";    //wandelt text zu binär um damit das richtige ausgegeben wird.
//            }
//        }
//    }
//}
namespace binaerercodeverschluesselung_RoNi
{
    internal class TextToBinary
    {
        public string converted = "";

        public TextToBinary(string userInput)
        {
            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };

            foreach (char currentSymbol in userInput)
            {
                string convertedToBinary = "";

                int byteValueInAscii = (int)currentSymbol; // ASCII-Wert des Zeichens holen

                for (int bitPosition = 0; bitPosition < 8; bitPosition++) // dazuzu da um zu prüfen wleche bytes in de rbinärstellung gesetzt werden müssen
                {
                    if (byteValueInAscii >= binarynumbers[bitPosition])
                    {
                        convertedToBinary += "1";
                        byteValueInAscii -= binarynumbers[bitPosition];
                    }
                    else
                    {
                        convertedToBinary += "0";
                    }
                }

                converted += convertedToBinary + " ";
            }
        }
    }
}


