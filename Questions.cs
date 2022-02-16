using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject
{
    public class Questions
    {

        public int CounterGeneric<T, U>(T a, U b)
        {
            int counter = 0;

            //In production would check that a letter is being parsed - try catch
            if(a.GetType() == typeof(string) && b.GetType() == typeof(char))
            {
                string lorStr = a.ToString().ToLower();
                char[] lorChar = lorStr.ToCharArray();

                char charEquals = (char)(object)b;

                foreach (char c in lorChar)
                {
                    if(c == charEquals)
                    {
                        counter++;
                    }
                }
            }

            //Number needs to be string as integer is too large

            //In production would check that a letter is being parsed - try catch
            else if (a.GetType() == typeof(string) && b.GetType() == typeof(int))
            {
                string numValue = a.ToString();
                char[] numValArr = numValue.ToCharArray();

                foreach(char x in numValArr)
                {
                    if(x.ToString() == b.ToString())
                    {
                        counter++;
                    }
                }

            }

            return counter;
        }

        // Another way is to method overloading but this way there is only one method ^^^^


        public int AddNums(int a, int b)
        {
            return a + b;
        }

    }
}
