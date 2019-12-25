using System;
using System.Text.RegularExpressions;

namespace Packt.Shared
{
    public static class StringExtensions
    {
        // public bool IsValidEmail(this string input)
        public static bool IsValidEmail(this string input)
        {
            // use simple regular express to check 
            // that the input string is a valid email
            return Regex.IsMatch(
                input,
                @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}