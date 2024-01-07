using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logica
{
    public static class Exercicios
    {
        public static double FromCelsiusToFahrenheit(double celsiusTemperature)
        {
            return (celsiusTemperature * 9 / 5) + 32;
        }
        
        public static double FromFahrenheitToCelsius(double fahrenheitTemperature)
        {
            return (fahrenheitTemperature - 32) * 5 / 9;
        }

        public static bool IsNumberPrime(double number)
        {
            if (number == 2)
                return true;

            if (number <= 1 || number %2 == 0) 
                return false;
           
            
            for(int i = 3; i < (int)Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static long GetFatorialOfANumber(int number)
        {
            if(number >= 0)
            {
                long result = 1;

                for (int i = 2; i <= number; i++)
                    result *= i;

                return result;
            }
            return 0;
        }

        public static List<int> OrderListOfNumber(List<int> numbers)
        {
            numbers.Sort();
            return numbers;
        }

        public static bool IsStringAPalindrome(string str)
        {
            char[] array = str.ToLower().ToCharArray();
            Array.Reverse(array);
            string reversedString = new string(array);

            return str.ToLower().Equals(reversedString);
        }

        public static double GetSquaredRoot(double number)
        {
            //x^2 - number = 0
            if(number > 0)
            {
                double errorLimit = 0.6;

                double squaredRoot = number;
                double nextSquaredRootTry = 0;

                while (true)
                {
                    nextSquaredRootTry = (squaredRoot + number / squaredRoot) / 2;
                    if (Math.Abs(nextSquaredRootTry - squaredRoot) < errorLimit)
                        return nextSquaredRootTry;

                    squaredRoot = nextSquaredRootTry;
                }

            }
            return 0;
        }

        public static double HowManyDolarsFromReal(double real, double quotation)
        {
            return real / quotation;
        }
        public static bool IsPasswordValid(string password)
        {
            if (password.Length < 8)
                return false;
            if (!Regex.IsMatch(password, "[A-Z]"))
                return false;
            if (!Regex.IsMatch(password, "[a-z]"))
                return false;
            if (!Regex.IsMatch(password, "[0-9]"))
                return false;
            return true;
        }

        public static bool IsCPFValid(string input)
        {
            input = new string(input.Where(char.IsDigit).ToArray());

            if (input.Length != 11)
                return false;

            if (input.All(c => c == input[0]))
                return false;

            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += (input[i] - '0') * (10 - i);

            int remainder = (sum * 10) % 11;

            if (remainder == 10) remainder = 0;

            if (input[9] != remainder + '0')
                return false;

            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += (input[i] - '0') * (11 - i);

            remainder = (sum * 10) % 11;

            if (remainder == 10) remainder = 0;

            if (input[10] != remainder + '0')
                return false;

            return true;
        }

        public static Dictionary<string, int> CountHowManyTimeEachWordAppears(string str)
        {
            char[] wordEnders = [' ', '\r', '\n', '\t', ',', '.', ';', ':', '!', '?'];
            string[] palavras = str.Split(wordEnders, StringSplitOptions.RemoveEmptyEntries);

            List<string> words = new List<string>(palavras);

            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                if (result.ContainsKey(words.ElementAt(i)))
                    result[words.ElementAt(i)]++;
                else
                    result[words.ElementAt(i)] = 1;
                
            }
            return result; 
        }
    }
}
