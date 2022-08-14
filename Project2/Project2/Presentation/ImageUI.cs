using System;
using Project2.DataAccessLayer;
using Project2.Model;
using Project2.Utilites;

namespace Project2.Presentation
{
    //giao dien ctrinh 
    public class ImageUI
    {
        private ImageDAL _dal = new ImageDAL();


        public void Add() //giao dien them
        {
            Image image = new Image(); //khoi tao doi tuong
            image.Input(); //nhap thong tin
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
                image.IdCategory = category.Id;
            }

            _dal.Add(image); //them
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
                Image image = list[choose]; //get doi tuong
                image.Input(); //nhap lai thong tin
                _dal.Update(choose, image);
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
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-40}|", "Index", "Id", "Name", "Url");
            var list = _dal.GetAll();
            foreach (var image in list)
            {
                image.Display(list.IndexOf(image));
            }
        }

        public void Run() //giao dien chinh
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("       Image Management");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Add Image");
                Console.WriteLine("2. Update Image");
                Console.WriteLine("3. Delete Image");
                Console.WriteLine("4. View Image");
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