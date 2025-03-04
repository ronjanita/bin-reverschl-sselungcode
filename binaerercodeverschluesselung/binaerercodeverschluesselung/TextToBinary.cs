namespace binaerercodeverschluesselung_RoNi
{
    internal class TextToBinary
    {
        public TextToBinary(string binTxt)
        {
            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };
            
            int UserInput = Convert.ToInt32(binTxt);

            for (int i = 0; i < binarynumbers.Length; i++)
            {
                char BinTxt = (char)binarynumbers[i];
                if (char.IsLetter(BinTxt))
                {
                    binTxt += 1;
                }
            }
        }
    }
}
