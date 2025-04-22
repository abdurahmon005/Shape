using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccauntTekshir
{
    class NewAccaunt : Accaunt
    {
        public void CalculateInterest()
        {
       
            Console.Write("6 + 7 = ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("19 - 7 = ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("75 / 5 = ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 13 && num2 == 12 && num3 == 15)
            {
                Console.WriteLine("SIz bot emassiz, tizimga hush kelibsiz");
            }
            else  
                {
                    Console.Write("Qaytadan urunib koring ");
                }
            }
        }
    }

