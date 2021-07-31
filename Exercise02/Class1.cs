using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public static class NumberExtension
    {
        public static String Towards(this BigInteger number)
        {
            String description = "";

           
            return description;
        }

        public static String Towards(this int number)
        {
            String description = "";

            return description;
        }

        private static String describeSingleDigit(String token) 
        {
            int number = Int32.Parse(token);

            if (number == 0) return "";
            if (number == 1) return "One";
            if (number == 2) return "two";
            if (number == 3) return "three";
            if (number == 4) return "four";
            if (number == 5) return "five";
            if (number == 6) return "six";
            if (number == 7) return "seven";
            if (number == 8) return "eight";

            return "nine";
        }

        private static String describeDoubleDigit(String token)
        {
            String description;

            String tensDigit = token[0].ToString();

            if (tensDigit.Equals("0"))
                return describeSingleDigit(tensDigit);

            else if (tensDigit.Equals("1"))
            {
                int number = Int32.Parse(token[1].ToString());

                if (number == 1) return "eleven";
                if (number == 2) return "twelve";
                if (number == 3) return "thriteen";
                if (number == 4) return "fourteen";
                if (number == 5) return "fifteen";
                if (number == 6) return "sixteen";
                if (number == 7) return "seventeen";
                if (number == 8) return "eighteen";

                return "nineteen";
            }
            else
            {
                String singleDigitDescription = describeSingleDigit(token[1].ToString());
                String tensDesc = "";

                if (tensDigit.Equals("2")) tensDesc = "twenty";
                if (tensDigit.Equals("3")) tensDesc = "thirty";
                if (tensDigit.Equals("4")) tensDesc = "fourty";
                if (tensDigit.Equals("5")) tensDesc = "fifty";
                if (tensDigit.Equals("6")) tensDesc = "sixty";
                if (tensDigit.Equals("7")) tensDesc = "seventy";
                if (tensDigit.Equals("8")) tensDesc = "eighty";
                if (tensDigit.Equals("9")) tensDesc = "ninety";

                description = tensDesc + " " + singleDigitDescription;
            }



            return description;
        }

        private static String describeTrippleDigit(String token)
        {
            
            String hundreds = token[2].ToString();
            String tens = token[1].ToString();
            String units = token[0].ToString();

            if (hundreds.Equals("0"))
                return describeDoubleDigit(tens + units);

            String hundredsDesc = describeSingleDigit(token[2].ToString()) + " hundred ";

            if (Int32.Parse(tens) + Int32.Parse(units) == 0)
                return hundredsDesc;
            else
                return hundredsDesc + " and " + describeDoubleDigit(tens + units);
        }

    }
}
