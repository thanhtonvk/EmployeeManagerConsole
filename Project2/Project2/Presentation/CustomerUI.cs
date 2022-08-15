using System;
using Project2.DataAccessLayer;
using Project2.Model;
using Project2.Utilites;

namespace Project2.Presentation
{
     //giao dien ctrinh 
    public class CustomerUI
    {
        private ICustomerDAL _dal = new CustomerDAL();

        
        public void Add()//giao dien them
        {
            Customer customer = new Customer();//khoi tao doi tuong
            customer.Input();//nhap thong tin
            _dal.Add(customer);//them
            Console.ReadKey();
            Console.Clear();
        }

        public void Update()//giao dien cap nhat
        {
            var list = _dal.GetAll();//lay ve ds
            Display();//hien thi
            int choose = Validattion.InputNumber();
            if (choose >= list.Count)
            {
                Console.WriteLine("InValid");
            }
            else
            {
                Customer customer = list[choose];//get doi tuong
                customer.Input();//nhap lai thong tin
                _dal.Update(choose, customer);
            }

            Console.ReadKey();
            Console.Clear();
        }

        public void Delete()//giao dien xoa
        {
            var list = _dal.GetAll();//get ve ds
            Display();//hien thi
            int choose = Validattion.InputNumber();
            if (choose >= list.Count)
            {
                Console.WriteLine("InValid");
            }
            else
            {
                _dal.Delete(choose, null);//xoa theo vi tri 
            }

            Console.ReadKey();
            Console.Clear();
        }

        public void Display()//giao dien hien thi ds
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}", "Index", "ID", "FullName", "Email", "Phone");
            var list = _dal.GetAll();
            foreach (var customer in list)
            {
                customer.Display(list.IndexOf(customer));
            }

        
        }

        public void Run()//giao dien chinh
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("       Customer Management");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Update Customer");
                Console.WriteLine("3. Delete Customer");
                Console.WriteLine("4. View Customer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("--------------------------------------");
                int choose = Validattion.InputNumber();
                switch (choose)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        Display();
                        break;
                    default: break;
                }

                if (choose == 0) break;
            }
        }
    }
    
}