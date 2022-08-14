using System;
using Project2.Utilites;

namespace Project2.Model
{
    // luu thong tin invoice
    public class Invoice
    {
        private int id;
        private DateTime invoiceDate;
        private int invoiceNumber;
        private string description;
        private int productId;

        public Invoice(int id, DateTime invoiceDate, int invoiceNumber, string description, int productId)
        {
            this.id = id;
            this.invoiceDate = invoiceDate;
            this.invoiceNumber = invoiceNumber;
            this.description = description;
            this.productId = productId;
        }

        public Invoice()
        {
            
        }

        // tra ve chuoi cach nhau boi dau #
        public override string ToString()
        {
            return id + "#" + invoiceDate + "#" + invoiceNumber + "#" + description + "#" + productId;
        }
// nhap thong tin
        public void Input()
        {
            Console.Write("Invoice Date: ");
            invoiceDate = Validattion.InputDateTime();
            Console.Write("Invoie number: ");
            invoiceNumber = Validattion.InputNumber();
            Console.Write("Description: ");
            description = Validattion.InputString();
        }
// hien thi thong tin
        public void Display(int idx)
        {
            Console.Write("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|",idx, id, invoiceDate, invoiceNumber,
                description, productId);
        }

        public int ProductId
        {
            get => productId;
            set => productId = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public DateTime InvoiceDate
        {
            get => invoiceDate;
            set => invoiceDate = value;
        }

        public int InvoiceNumber
        {
            get => invoiceNumber;
            set => invoiceNumber = value;
        }

        public string Description
        {
            get => description;
            set => description = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}