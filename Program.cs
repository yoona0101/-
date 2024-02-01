using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практ_раб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите n: ");
                throw new Exception
                double n;
                double S = 0;
                n = Convert.ToDouble(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    S += Math.Pow(i, 7);
                }

                Console.WriteLine($"Ваша сумма = {S}");
            }
            catch(FormatException ) 
            {
                Console.WriteLine("Данное значение недопустимо"); 
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
            finally
            {
                Console.WriteLine("Программа завершила работу");
            }
        }

    }
}
