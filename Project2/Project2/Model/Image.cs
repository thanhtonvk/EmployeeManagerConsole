using System;
using Project2.Utilites;

namespace Project2.Model
{
    // luu  thong tint hinh anh cateogry
    public class Image
    {
        private int id;
        private string name;
        private string url;
        private int idCategory;

        public Image(int id, string name, string url, int idCategory)
        {
            this.id = id;
            this.name = name;
            this.url = url;
            this.idCategory = idCategory;
        }

        public Image()
        {
            
        }


        // tra ve chuoi thogn tin cach nhau boi dau #
        public override string ToString()
        {
            return id + "#" + name + "#" + url + "#" + idCategory;
        }

// hien thi thong tin
        public void Display(int idx)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-40}|", idx, id, name, url);
        }
        // nhap thong tin

        public void Input()
        {
            id = new Random(1000).Next();
            Console.Write("Name: ");
            name = Validattion.InputString();
            Console.Write("URL: ");
            name = Validattion.InputString();
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Url
        {
            get => url;
            set => url = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int IdCategory
        {
            get => idCategory;
            set => idCategory = value;
        }
    }
}