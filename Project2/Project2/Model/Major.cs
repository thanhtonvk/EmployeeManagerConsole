using System;
using Project2.Utilites;

namespace Project2.Model
{
    // luu thong tin major
    public class Major
    {
        private int id;
        private int idEmployee;
        private string majorName;

        public Major(int id, int idEmployee, string majorName)
        {
            this.id = id;
            this.idEmployee = idEmployee;
            this.majorName = majorName;
        }

        public Major()
        {
            
        }

        // nhap thong tin
        public void Input()
        {
            id = new Random(1000).Next();
            Console.Write("Major name: ");
            majorName = Validattion.InputString();
        }
// hiển thị thông tin
        public void Display(int idx)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", idx, id, majorName);
        }
// trả về chuỗi thông tin cách nhau bởi dấu #
        public override string ToString()
        {
            return id + "#" + majorName + "#" + idEmployee;
        }


        public int IdEmployee
        {
            get => idEmployee;
            set => idEmployee = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string MajorName
        {
            get => majorName;
            set => majorName = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}