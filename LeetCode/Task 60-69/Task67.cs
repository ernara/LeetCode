//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Text;

//namespace LeetCode.Task_60_69
//{
//    internal class Task67
//    {
//        public string AddBinary(string a, string b)
//        {
//            BigInteger aa = BigInteger.Parse(a);
//            BigInteger bb = BigInteger.Parse(b);

//            BigInteger result = aa + bb;

//            return Convert.ToString(result, 2);

//            BigInteger bigInt1 = BigInteger.Parse(binary1, System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowTrailingSign);
//            BigInteger bigInt2 = BigInteger.Parse(binary2, System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowTrailingSign);

//            // Add the BigIntegers
//            BigInteger sum = bigInt1 + bigInt2;

//            // Convert the sum back to a binary string
//            string binarySum = sum.ToString(2);

//            return binarySum;
//        }
        
//    }
//}
