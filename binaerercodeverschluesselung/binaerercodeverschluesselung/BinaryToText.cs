﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaerercodeverschluesselung_RoNi
{
    internal class BinaryToText
    {
        public BinaryToText(string binTxt)
        {
            int UserInput = Convert.ToInt32(Console.ReadLine());
            string BinTxt;
            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };  //make structur to assign value of binary system according to input by user.
            
            for (int i = 0; i < binarynumbers.Length; i++) ;
            {
               if (UserInput / binarynumbers[i] > 1)
                {
                    binTxt + = 1;
                }
               else { }
            }
        }
    }
}
