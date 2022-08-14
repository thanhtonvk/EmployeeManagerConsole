using System;
using Project2.Utilites;

namespace Project2.Presentation
{
    public class HRManager
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("       HR Management");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Employee Management");
                Console.WriteLine("2. Category Management");
                Console.WriteLine("3. Image Management");
                Console.WriteLine("4. Manjor Management");
                Console.WriteLine("5. Product  Management");
                Console.WriteLine("0. Exit");
                Console.WriteLine("--------------------------------------");
                int choose = Validattion.InputNumber();
                switch (choose)
                {
                    case 1:
                        new EmployeeUI().Run();
                        break;
                    case 2:
                        new CategoryUI().Run();
                        break;
                    case 3:
                        new ImageUI().Run();
                        break;
                    case 4:
                        new MajorUI().Run();
                        break;
                    case 5:
                        new ProductUI().Run();
                        break;
                    default: break;
                }

                if (choose == 0) break;
            }
        }
    }
}