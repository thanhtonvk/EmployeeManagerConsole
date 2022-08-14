using System;
using Project2.DataAccessLayer;
using Project2.Model;
using Project2.Utilites;

namespace Project2.Presentation
{
    //giao dien ctrinh 
    public class ProductUI
    {
        private ProductDAL _dal = new ProductDAL();


        public void Add() //giao dien them
        {
            Product product = new Product(); //khoi tao doi tuong
            product.Input(); //nhap thong tin
            _dal.Add(product); //them
            
            
            var listCategory = new CategoryDAL().GetAll();
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "Index", "Id", "Category Name", "CategoryImage");
            var list = _dal.GetAll();
            foreach (var category in listCategory)
            {
                category.Display(listCategory.IndexOf(category));
            }

            int choose = Validattion.InputNumber();
            if (choose >= list.Count)
            {
                Console.WriteLine("InValid");
            }
            else
            {
                Category category = listCategory[choose]; //get doi tuong
                product.IdCategory = category.Id;
            }
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
                Product product = list[choose]; //get doi tuong
                product.Input(); //nhap lai thong tin
                _dal.Update(choose, product);
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
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "Index", "ID",
                "Product Name",
                "Unit Bief", "Description",
                "Status", "Quantity");
            var list = _dal.GetAll();
            foreach (var product in list)
            {
                product.Display(list.IndexOf(product));
            }

         
        }

        public void Run() //giao dien chinh
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("       Product Management");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. View Product");
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