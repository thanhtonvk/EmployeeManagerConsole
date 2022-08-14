using System;
using Project2.Utilites;

namespace Project2.Model
{
    // luuu thong tin customer
    public class Customer
    {
        private int id;
        private string fullName;
        private string email;
        private int phone;
      

        public Customer(int id, string fullName, string email, int phone)
        {
            this.id = id;
            this.fullName = fullName;
            this.email = email;
            this.phone = phone;
           
        }

        public Customer()
        {
            
        }

        // tra ve chuoi cach nhau boi dau #
        public override string ToString()
        {
            return id + "#" + fullName + "#" + email + "#" + phone;
        }

// nhap thong tin
        public void Input()
        {
            id = new Random(1000).Next();
            Console.Write("Full name: ");
            fullName = Validattion.InputString();
            Console.Write("Email: ");
            email = Validattion.InputString();
            Console.Write("Phone: ");
            phone = Validattion.InputNumber();
            
        }

// hien thi thong tin
        public void Display(int idx)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}", idx, id, fullName, email, phone);
        }

    

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string FullName
        {
            get => fullName;
            set => fullName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Email
        {
            get => email;
            set => email = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Phone
        {
            get => phone;
            set => phone = value;
        }
    }
}