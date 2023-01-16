using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul_9_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exception> exceptionlist = new List<Exception>(); 
            exceptionlist.Add(new CustomException ( "Собственное исключение") );
            exceptionlist.Add(new NullReferenceException("NullReferenceException"));
            exceptionlist.Add(new IndexOutOfRangeException("IndexOutOfRangeException"));
            exceptionlist.Add(new DivideByZeroException("DivideByZeroException"));
            exceptionlist.Add(new FormatException("FormatException"));
            try
            {
                Console.WriteLine("Выберите номер исключения от 1 до 5");
                    string n = Console.ReadLine();


                throw exceptionlist.ElementAt(int.Parse(n));


            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Блок finaly сработал");
            }
        }
    }
}
