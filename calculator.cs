using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    public class Program
    {
        public static void Main()
        {
            int num1, num2;
            string op;

            WriteLine("input first number");
            num1 = int.Parse(ReadLine());
            WriteLine("input second number");
            num2 = int.Parse(ReadLine());
            WriteLine("select +, -, *, /");
            op = ReadLine();

            WriteLine(" The result is " + calculator(num1, num2, op) );
           
            ReadKey();
        }

        static int calculator(int n1, int n2, string op)
        {
            int re;

            switch(op)
            {
                case "+":
                    re= n1 + n2;
                    break;
                case "-":
                    re= n1 - n2;
                    break;
                case "/":
                    re = n1 / n2;
                    break;
                case "*":
                    re = n1 * n2;
                    break;
                default:
                    WriteLine("input error");
                    re = 0;
                    break;
            }
            return re;

        }

        

        
    }
}
