using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEg
{
    class SystemExceptionEg
    {
        // example of System Exception
        static void Main()
        {
            int num = 30;
            string[] fruits = { "Orange", "Mango" };
            int[,] arr = { { 10, 20,90 }, { 30, 40,80} };
            //num=num/0; (wont allow to execute)
            try
            {
                //Note : if there is any error in the first statement then it will directly go to catch class ,it wont go for other errors or non error statement.
                Console.WriteLine("num: {2}", num);
                Console.WriteLine("Fruit[2] : {0}", fruits[2]);

                num = num / 0;
                int add = 10 + 30;
                Console.WriteLine("Addition : {0}", add);
            }
            // exception is only handeled in catch block.if catch block is nt there your program will not get executed
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Message : {0}", ex);
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Message : {0}", ex);
            }

            catch (Exception ex)
            {
                // Console.WriteLine("Message : {0}",ex);
                Console.WriteLine("Message : {0}", ex.Message);
                Console.WriteLine("SourceName: {0}", ex.Source);
                Console.WriteLine("Exact Location of Source: {0}", ex.StackTrace);
                Console.WriteLine("Message : Please check the inputs");
            }

            finally         // if any database program or connection is open to close it finally block is used.
            {
                Console.WriteLine("Used to close Opened connection");

            }


            num = num * num;

            Console.WriteLine("\nMultiplication : {0}", num);
            Console.WriteLine("\nEnd of System Exception");
           

            Console.Read();
        }
    }
}
