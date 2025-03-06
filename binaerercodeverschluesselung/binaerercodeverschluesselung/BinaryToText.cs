//namespace binaerercodeverschluesselung_RoNi
//{
//    internal class BinaryToText
//    {
//        public string converted = "";

//        public BinaryToText(string binTxtUserInput)
//        {
//            for (int startIndexByte = 0; startIndexByte < binTxtUserInput.Length; startIndexByte += 8)   //in 8er schritten durch eingegeben code gehen
//            {
//                string bytePlaceHolder = ""; // Ein leerer String für jedes 8-Bit-Set
//                for (int currentByteIndex = 0; currentByteIndex < 8; currentByteIndex++)  //8 byte für jedes zeicehgn ---> die einzelnen bits ewrden zu bytePlayeHolde3r hinzugefügt
//                {
//                    if (startIndexByte + currentByteIndex < binTxtUserInput.Length)
//                    {
//                        bytePlaceHolder += binTxtUserInput[startIndexByte + currentByteIndex];
//                    }                                                                              //brechnet den aktueöen index im gesamten binärstring und stellt sicher das der idex nicht ausserhalb des strings liegt. Wenn index gültig ist, wird er zum bytePlayeHolder hinzugefü¨gt
//                }
//                int byteValueInAscii = Convert.ToInt32(bytePlaceHolder, 2);         //konvertiert bytePlaceHolder in eine Zahl (byteValueAscii) und 2 braucht man damnit man weiss das es ich  um eine binär zahl handlet
//                converted += (char)byteValueInAscii;   //wandelt byteValueAscii in den converted text um wlecher dan ausgegeben wird.
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
            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };

            for (int startIndexByte = 0; startIndexByte < binTxtUserInput.Length; startIndexByte += 8)
            {
                int byteValueInAscii = 0;

                for (int currentByteIndex = 0; currentByteIndex < 8; currentByteIndex++)
                {
                    if (startIndexByte + currentByteIndex < binTxtUserInput.Length && binTxtUserInput[startIndexByte + currentByteIndex] == '1')
                    {
                        byteValueInAscii += binarynumbers[currentByteIndex];
                    }
                }
                converted += (char)byteValueInAscii;
            }
        }
    }
}


