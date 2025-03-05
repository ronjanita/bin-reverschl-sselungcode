//namespace binaerercodeverschluesselung_RoNi
//{
//    internal class BinaryToText
//    {
//        public string converted = "";

//        public BinaryToText(string binTxt)
//        {
//            int UserInput = Convert.ToInt32(binTxt, 2); // Konvertiert Binärstring zu int

//            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };

//            for (int i = 0; i < binarynumbers.Length; i++) // Schleife korrekt geöffnet
//            {
//                converted += ((UserInput & binarynumbers[i]) != 0) ? "1" : "0"; // Binärzahl korrekt ermitteln
//            }
//        }
//    }
//}
//using System;

//namespace binaerercodeverschluesselung_RoNi
//{
//    internal class BinaryToText
//    {
//        public string converted = "";  // Speichert den entschlüsselten Text

//        public BinaryToText(string binInput)  // Konstruktor wird aufgerufen, weil ein BinaryToText-Objekt mit Binärstring erstellt wird
//        {
//            // Durchlaufe den Binärstring in 8-Bit-Schritten
//            for (int i = 0; i < binInput.Length; i += 9)  // 8 Bits + 1 Leerzeichen
//            {
//                // Nehme die nächsten 8 Zeichen (Binärblock)
//                string bin = binInput.Substring(i, 8);  // Hol dir die 8 Zeichen, die den Binärblock bilden

//                // Binär zu Dezimal umwandeln
//                int binToDez = Convert.ToInt32(bin, 2);  // Wandelt den Binärstring in eine Dezimalzahl um

//                // Füge das Zeichen zum Ergebnis hinzu
//                converted += (char)binToDez;  // Umwandlung der Dezimalzahl in das entsprechende ASCII-Zeichen
//            }
//        }
//    }
//}
namespace binaerercodeverschluesselung_RoNi
{
    internal class BinaryToText
    {
        public string converted = "";

        public BinaryToText(string binTxtUserInput)
        {
            // Durch den binären Text in 8-Bit-Schritten iterieren
            for (int startIndexByte = 0; startIndexByte < binTxtUserInput.Length; startIndexByte += 8)
            {
                string bytePlaceHolder = ""; // Ein leerer String für jedes 8-Bit-Set

                // 8 Bit für jedes Zeichen sammeln
                for (int currentByteIndex = 0; currentByteIndex < 8; currentByteIndex++)
                {
                    // Füge ein einzelnes Bit (z.B. "0" oder "1") hinzu
                    if (startIndexByte + currentByteIndex < binTxtUserInput.Length)
                    {
                        bytePlaceHolder += binTxtUserInput[startIndexByte + currentByteIndex];
                    }
                }

                // Konvertiere den 8-Bit-String in eine Zahl
                int byteValueInAscii = Convert.ToInt32(bytePlaceHolder, 2);

                // Konvertiere die Zahl in ein Zeichen und füge es zum Ergebnis hinzu
                converted += (char)byteValueInAscii;
            }
        }
    }
}


