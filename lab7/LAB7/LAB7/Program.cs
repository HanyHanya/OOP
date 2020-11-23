using System;
using System.Diagnostics;

namespace LAB7
{
    class Program
    {
        static void Main(string[] args)
        {
            Island island1 = new Island("AIsland");
            Island island2 = new Island(0);
            Island island3 = new Island(3);
            Sea sea1 = new Sea("OneS");
            Sea sea2 = new Sea(5);// Exception 1
            Ocean ocean1 = new Ocean();
            Continent con1 = new Continent(-1);// Exception 2
            Continent con2 = new Continent(4);
            State state1 = new State("OneState1");// Exception 3
            State state2 = new State("TwoState");
            Console.WriteLine("Введите ваш возраст: ");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());// Exception 4
                if (i < 18)
                {
                    throw new YearException("Вы еще слишком молоды!");
                }
            }
            catch (YearException e)
            {
                Console.WriteLine(e.Message);
                
            }

            try
            {
                Earth N = null;// Exception 5
                Console.WriteLine(N);
                throw new NullReferenceException("Объект неопределен!");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            //Assert
            Debug.Assert(true, "finished");
        }
    }
}
