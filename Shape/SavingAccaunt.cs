using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccauntTekshir
{
    class SavingAccaunt : Accaunt
    {
        public void CalculateInterest(string name,string email, int num)
        {
           
            if (name == "Muminov Abdurahmon" && email == "abdurahmon7985@gmail.com" && num == 977507260)
            {

                Console.Write("Tizimga hush kelibsiz!");
            }
            else
            {
                Console.WriteLine("Siz ro'yhatdan o'tmagansiz");
            }

        }
    }
}
