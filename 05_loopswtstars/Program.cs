using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_loopswtstars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Altalta yıldız ELMAS oluşturma

            ///ARTIRMA KISMI
            int n = 5;
            for (int i = 1; i <= 5; i++)
            {
                for (int k = n - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
            /// AZALTMA KISMI

            for (int i = n; i >= 1; i--)
            {
                for (int k = n - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }


            #endregion



            Console.Read();
        }
    }
}
