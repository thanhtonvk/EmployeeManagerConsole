using System;
using Project2.DataAccessLayer;
using Project2.Model;
using Project2.Utilites;

namespace Project2.Presentation
{
    //giao dien ctrinh 
    public class EmployeeUI
    {
        private EmployeeDAL _dal = new EmployeeDAL();
        public void Add() //giao dien them
        {
            Employee employee = new Employee(); //khoi tao doi tuong
            employee.Input(); //nhap thong tin
            _dal.Add(employee); //them
            Console.ReadKey();
            Console.Clear();
        }

        public void Update() //giao dien cap nhat
        {
            var list = _dal.GetAll(); //lay ve ds
            Display(); //hien thi
            int choose = Validattion.InputNumber();
            if (choose >= list.Count)
            {
                Console.WriteLine("InValid");
            }
            else
            {
                Employee employee = list[choose]; //get doi tuong
                employee.Input(); //nhap lai thong tin
                _dal.Update(choose, employee);
            }

            Console.ReadKey();
            Console.Clear();
        }

        public void Delete() //giao dien xoa
        {
            var list = _dal.GetAll(); //get ve ds
            Display(); //hien thi
            int choose = Validattion.InputNumber();
            if (choose >= list.Count)
            {
                Console.WriteLine("InValid");
            }
            else
            {
                _dal.Delete(choose, null); //xoa theo vi tri 
            }

            Console.ReadKey();
            Console.Clear();
        }

        public void Display() //giao dien hien thi ds
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "Index", "Id",
                "Fullname",
                "Date of birth",
                "Email", "Phone number", "Account name", "Password");
            var list = _dal.GetAll();
            foreach (var employee in list)
            {
                employee.Display(list.IndexOf(employee));
            }

        
        }

        public void Run() //giao dien chinh
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("       Employee Management");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. View Employee");
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