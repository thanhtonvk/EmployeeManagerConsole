using System;

namespace Project2.Utilites
{
    public class Validattion
    {
        public static string InputString() //kiem tra chuoi nhap, neu rong thi se bat nhap lai
        {
            string input = Console.ReadLine();
            while (true)
            {
                if (input != "") break;
                Console.Write("String is empty: ");
                input = Console.ReadLine();
            }

            return input;
        }

        public static int InputNumber() //kiem tra co phai nhap so khong, va so co lon hơn 0 không
        {
            String input = Console.ReadLine();
            int number;
            while (true)
            {
                bool isNumerical = int.TryParse(input, out number);
                if (isNumerical && number >= 0) break;
                Console.Write("Input is not numberic or <0: ");
                input = Console.ReadLine();
            }

            return number;
        }

        public static DateTime InputDateTime()
        {
            Console.Write("(mm/dd/yyyy): ");
            String input = Console.ReadLine();
            DateTime dateTime;
            while (true)
            {
                bool isDate = DateTime.TryParse(input, out dateTime);
                if (isDate) break;
                Console.Write("Input is not datetime: ");
                input = Console.ReadLine();
            }

            return dateTime;
        }
    }
}