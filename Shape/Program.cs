namespace AccauntTekshir

{
     class Program
    {
        static void Main(string[] args)
        {
            NewAccaunt newAccaunt = new NewAccaunt();

            SavingAccaunt savingAccaunt = new SavingAccaunt();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t ____________________________________ ");
                Console.WriteLine("\t\t\t\t\t\t|                                    |");
                Console.WriteLine("\t\t\t\t\t\t|           ACCAUNT TIZIMI           |");
                Console.WriteLine("\t\t\t\t\t\t|____________________________________|\n\n");
        

                        Console.Write("FullNameni kiriting: ");
                savingAccaunt.FullName = Console.ReadLine();

                Console.Write("Emailni kiriting: ");
                savingAccaunt.Email = Console.ReadLine();

                Console.Write("Numberni kiriting: ");
                savingAccaunt.Number = Convert.ToInt32(Console.ReadLine());
                  
                Console.WriteLine(" ____________________________________         ____________________________________ ");
                Console.WriteLine("|                                    |       |                                    |");
                Console.WriteLine("|         1. Tizimga kirish          |       |        2. Ro'yhatdam o'tish        |");
                Console.WriteLine("|____________________________________|       |____________________________________|\n");


                Console.Write("(1 yoki 2) = ");

               int number = Convert.ToInt32(Console.ReadLine());
               
                switch (number)
                {
                    //mavjud bolgan accaunt uchun
                    case 1: savingAccaunt.CalculateInterest(savingAccaunt.FullName, savingAccaunt.Email, savingAccaunt.Number); break;  

                    //mavjud bo'lmagan accaunt uchun
                    case 2: newAccaunt.CalculateInterest(); break;  

                    default: Console.WriteLine(); break;
                }
                Console.WriteLine("\nDavom etish uchun istalgan tugmani bosing...");


                Console.ReadKey();

                Console.Clear();
            }
         }
        }
}
