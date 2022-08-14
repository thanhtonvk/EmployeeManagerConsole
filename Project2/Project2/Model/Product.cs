using System;
using Project2.Utilites;

namespace Project2.Model
{
    // luu thogn tin cua product
    public class Product
    {
        private int id;
        private string productName;
        private int unitBief, unitPrice;
        private string description;
        private string status;
        private int quantity;
        private int idCategory;

        public Product(int id, string productName, int unitBief, int unitPrice, string description, string status, int quantity, int idCategory)
        {
            this.id = id;
            this.productName = productName;
            this.unitBief = unitBief;
            this.unitPrice = unitPrice;
            this.description = description;
            this.status = status;
            this.quantity = quantity;
            this.idCategory = idCategory;
        }

        public Product()
        {
            
        }

        // nhap thong tin
        public void Input()
        {
            id = new Random(1000).Next();
            Console.Write("Product name: ");
            productName = Validattion.InputString();
            Console.Write("Unit Bief: ");
            unitBief = Validattion.InputNumber();
            Console.Write("Description: ");
            description = Validattion.InputString();
            Console.Write("Status:  ");
            status = Validattion.InputString();
            Console.Write("Quantity: ");
            quantity = Validattion.InputNumber();
        }

        // hien thi thogn tin
        public void Display(int idx)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", idx, id, productName,
                unitBief, description,
                status, quantity);
        }

// tra ve chuoi thong tin cach nhau boi dau #
        public override string ToString()
        {
            return id + "#" + productName + "#" + unitBief + "#" + unitPrice + "#" + description + "#" + status + "#" +
                   quantity + "#" + idCategory;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int UnitBief
        {
            get => unitBief;
            set => unitBief = value;
        }

        public int UnitPrice
        {
            get => unitPrice;
            set => unitPrice = value;
        }

        public string Description
        {
            get => description;
            set => description = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Status
        {
            get => status;
            set => status = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public int IdCategory
        {
            get => idCategory;
            set => idCategory = value;
        }
    }
}