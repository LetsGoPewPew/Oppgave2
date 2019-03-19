using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Exceptions;

namespace TDD
{
    public class Program
    {
        public static readonly int start = 1;
        public static readonly int end = 100;
        public static StringBuilder stringBuilder = new StringBuilder();

        static void Main(string[] args)
        {
            Counter(start, end, stringBuilder);
            Console.Write(stringBuilder);
            Console.ReadLine();
        }

        public static void Counter(int start, int end, StringBuilder stringBuilder)
        {
            for (int i = start; i <= end; i++)
            {
                stringBuilder.AppendLine(ConvertNumberToCorrectString(i));
            }
        }

        public static String ConvertNumberToCorrectString(int i)
        {
            if(i <= 0)
            {
                throw new TooNegativeException("Value must be above 0");
            }

            if(i % 3 == 0 && i % 5 == 0)
            {
                return "HiOf";
            }

            if(i % 3 == 0)
            {
                return "Hi";
            }

            if(i % 5 == 0)
            {
                return "Of";
            }

            return i.ToString();
        }
    }
}