using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace NextSimilarNumber
{
    class Program
    {
        static void Main()
        {
            string number;
            Console.WriteLine("Enter number:");
            number = Console.ReadLine();
            Console.WriteLine(SearchNextSimilarNumber(number));
        }
        static bool ContainDigits(string number,string str)
        {
            for(int i=0;i<number.Length;i++)
            {
                if(str.Contains(number[i])==false)
                {
                    return false;
                }
            }
            return true;
        }
        static int CountDigits(int number)
        {
            int counter = 0;
            while(number!=0)
            {
                number = number / 10;
                counter++;
            }
            return counter;
        }
        static int  SearchNextSimilarNumber(string number)
        {
            int counter = 0, temp = -1;
            while(true)
            {
                if(CountDigits(counter)>number.Length)
                {
                    break;
                }
                if(CountDigits(counter)==number.Length)
                {
                    if(ContainDigits(number,counter.ToString()))
                    {
                        int.TryParse(number, out temp);
                        if(counter>temp)
                        {
                            temp = counter;
                            break;
                        }
                        else
                        {
                            temp = -1;
                        }
                    }
                }
                counter++;
            }
            return temp;
        }
    }
}
