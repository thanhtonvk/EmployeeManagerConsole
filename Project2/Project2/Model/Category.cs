using System;
using Project2.Utilites;

namespace Project2.Model
{
    // luu thong tin category
    public class Category
    {
        private int id;
        private string categoryName, categoryImage;

        public Category(int id, string categoryName, string categoryImage)
        {
            this.id = id;
            this.categoryName = categoryName;
            this.categoryImage = categoryImage;
        }

        public Category()
        {
            
        }

        // nhap thong tin
        public void Input()
        {
            id = new Random(1000).Next();
            Console.Write("Category name: ");
            categoryName = Validattion.InputString();
            Console.Write("Category image: ");
            categoryImage = Validattion.InputString();
        }

// hien thi thong tin
        public void Display(int idx)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", idx, id, categoryName, categoryImage);
        }

        public override string ToString()
        {
            return id + "#" + categoryName + "#" + categoryImage;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string CategoryName
        {
            get => categoryName;
            set => categoryName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string CategoryImage
        {
            get => categoryImage;
            set => categoryImage = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}