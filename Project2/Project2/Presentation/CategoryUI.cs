using System;
using Project2.DataAccessLayer;
using Project2.Model;
using Project2.Utilites;

namespace Project2.Presentation
{
    //giao dien ctrinh 
    public class CategoryUI
    {
        private CategoryDAL _dal = new CategoryDAL();

        
        public void Add()//giao dien them
        {
            Category category = new Category();//khoi tao doi tuong
            category.Input();//nhap thong tin
            _dal.Add(category);//them
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
                Category category = list[choose];//get doi tuong
                category.Input();//nhap lai thong tin
                _dal.Update(choose, category);
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
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "Index", "Id", "Category Name", "CategoryImage");
            var list = _dal.GetAll();
            foreach (var category in list)
            {
                category.Display(list.IndexOf(category));
            }
            
        }

        public void Run()//giao dien chinh
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("       Category Management");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Add Category");
                Console.WriteLine("2. Update Category");
                Console.WriteLine("3. Delete Category");
                Console.WriteLine("4. View Category");
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