using System;
using Project2.Utilites;

namespace Project2.Presentation
{
    public class StaffUI
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("       Staff Management");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Invoice Management");
                Console.WriteLine("2. Change password");
                Console.WriteLine("0. Logout");
                Console.WriteLine("--------------------------------------");
                int choose = Validattion.InputNumber();
                switch (choose)
                {
                    case 1:
                        new InvoiceUI().Run();
                        break;
                    case 2:
                        new LoginUI().ChangePassword();
                        break;
                    default: break;
                }

                if (choose == 0) break;
            }
        }
    }
}