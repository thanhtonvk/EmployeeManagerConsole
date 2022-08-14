using System;
using Project2.Utilites;

namespace Project2.Model
{
    // luu thong tin employee
    public class Employee
    {
        public static Employee EMP;


        private int id;
        private string fullName;
        private DateTime dateOfBirth;
        private string email;
        private int phoneNumber;
        private string accountName;
        private string password;
        private int roles;

        public Employee(int id, string fullName, DateTime dateOfBirth, string email, int phoneNumber,
            string accountName, string password, int roles)
        {
            this.id = id;
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.accountName = accountName;
            this.password = password;
            this.roles = roles;
        }

        public Employee()
        {
        }

        // nhap thong tin
        public void Input()
        {
            id = new Random(1000).Next();
            Console.Write("Fullname: ");
            fullName = Validattion.InputString();
            Console.Write("Date of birth: ");
            dateOfBirth = Validattion.InputDateTime();
            Console.Write("Email: ");
            email = Validattion.InputString();
            Console.Write("Phone number: ");
            phoneNumber = Validattion.InputNumber();
            Console.Write("Account name: ");
            accountName = Validattion.InputString();
            Console.Write("Password: ");
            password = Validattion.InputString();
            Console.Write("Roles: 1. HR   2.Staff");
            roles = Validattion.InputNumber();
            if (roles == 1)
            {
                roles = 1;
            }
            else
            {
                roles = 2;
            }
        }

        public void Display(int idx)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", idx, id, fullName,
                dateOfBirth,
                email, phoneNumber, accountName, password);
        }

// tra ve thong tin cach nhau boi dau #
        public override string ToString()
        {
            return id + "#" + fullName + "#" + dateOfBirth.ToString("MM/dd/yyyy") + "#" + email + "#" + phoneNumber + "#" + accountName + "#" +
                   password + "#" + roles;
        }

        public int Roles
        {
            get => roles;
            set => roles = value;
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

        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }

        public string Email
        {
            get => email;
            set => email = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string AccountName
        {
            get => accountName;
            set => accountName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Password
        {
            get => password;
            set => password = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}