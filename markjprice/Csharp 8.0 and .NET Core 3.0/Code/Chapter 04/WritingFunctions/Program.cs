using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine(
                    format: "{0} x {1} = {2}",
                    row,
                    number,
                    row * number);
            }
            WriteLine();
        }
        
        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }
        
        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH": rate = 0.0800M; break; // Switzerland
                case "DK":                        // Denmark
                case "NO": rate = 0.2500M; break; // Norway
                case "GB":                        // Great Britain
                case "FR": rate = 0.2000M; break; // France
                case "HU": rate = 0.2700M; break; // Hungary
                case "AK":                        // Alaska
                case "OR":                        // Oregon
                case "MT": rate = 0.0000M; break; // Montana
                case "ND":                        // North Dakota
                case "WI":                        // Wisconson
                case "VA": rate = 0.0500M; break; // Virginia
                case "ME": rate = 0.0550M; break; // Maine
                case "CA": rate = 0.0825M; break; // California
                default:   rate = 0.0600M; break; // most US states
            }
            return amount * rate;
        }
        
        static void RunCalculateTax() 
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a two-letter region code: ");
            string region = ReadLine();
            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount.!");
            }
        }

        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                  string numberAsText = number.ToString();
                  char lastDigit = numberAsText[numberAsText.Length - 1];
                  string suffix = string.Empty;
                  switch (lastDigit)
                  {
                      case '1': suffix = "st"; break; 
                      case '2': suffix = "nd"; break; 
                      case '3': suffix = "rd"; break; 
                      default:  suffix = "th"; break; 
                  }
                  return $"{number}{suffix}";
            }
        }

        static void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
            WriteLine();
        }

        static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCalculateTax();
            RunCardinalToOrdinal();
        }
    }
}
