using System;
using Project2.DataAccessLayer;
using Project2.Model;
using Project2.Utilites;

namespace Project2.Presentation
{
    //giao dien ctrinh 
    public class MajorUI
    {
        private MajorDAL _dal = new MajorDAL();


        public void Add() //giao dien them
        {
            Major major = new Major(); //khoi tao doi tuong
            major.Input(); //nhap thong tin
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "Index", "Id",
                "Fullname",
                "Date of birth",
                "Email", "Phone number", "Account name", "Password");
            var listEmp = new EmployeeDAL().GetAll();
            foreach (var employee in listEmp)
            {
                employee.Display(listEmp.IndexOf(employee));
            }

            int choose = Validattion.InputNumber();
            if (choose >= listEmp.Count)
            {
                Console.WriteLine("InValid");
            }
            else
            {
                Employee employee = listEmp[choose];
                major.IdEmployee = employee.Id;
            }


            _dal.Add(major); //them


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
                Major major = list[choose]; //get doi tuong
                major.Input(); //nhap lai thong tin
                _dal.Update(choose, major);
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
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", "Index", "ID", "Major Name");
            var list = _dal.GetAll();
            foreach (var major in list)
            {
                major.Display(list.IndexOf(major));
            }
        }

        public void Run() //giao dien chinh
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("       Major Management");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Add Major");
                Console.WriteLine("2. Update Major");
                Console.WriteLine("3. Delete Major");
                Console.WriteLine("4. View Major");
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