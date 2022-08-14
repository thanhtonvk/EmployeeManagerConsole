using System;
using Project2.DataAccessLayer;
using Project2.Model;
using Project2.Utilites;

namespace Project2.Presentation
{
    //giao dien ctrinh 
    public class InvoiceUI
    {
        private InvoiceDAL _dal = new InvoiceDAL();


        public void Add() //giao dien them
        {
            Invoice invoice = new Invoice(); //khoi tao doi tuong
            invoice.Input(); //nhap thong tin

            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "Index", "ID",
                "Product Name",
                "Unit Bief", "Description",
                "Status", "Quantity");
            var list = new ProductDAL().GetAll();
            foreach (var product in list)
            {
                product.Display(list.IndexOf(product));
            }

            int choose = Validattion.InputNumber();
            if (choose >= list.Count)
            {
                Console.WriteLine("InValid");
            }
            else
            {
                Product product = list[choose]; //get doi tuong
                invoice.ProductId = product.Id;
            }


            _dal.Add(invoice); //them
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
                Invoice invoice = list[choose]; //get doi tuong
                invoice.Input(); //nhap lai thong tin
                _dal.Update(choose, invoice);
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
            Console.Write("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Index", "ID", "Invoice date",
                "Invoice Number",
                "Description", "Product Id");
            var list = _dal.GetAll();
            foreach (var invoice in list)
            {
                invoice.Display(list.IndexOf(invoice));
            }
        }

        public void Run() //giao dien chinh
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("       Invoice Management");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Add Invoice");
                Console.WriteLine("2. Update Invoice");
                Console.WriteLine("3. Delete Invoice");
                Console.WriteLine("4. View Invoice");
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