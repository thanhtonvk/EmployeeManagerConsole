using System;
using Project2.DataAccessLayer;
using Project2.Model;
using Project2.Utilites;

namespace Project2.Presentation
{
    public class LoginUI
    {
        private EmployeeDAL _dal = new EmployeeDAL();

        public void Login()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("             Login");
                Console.Write("Username: ");
                string username = Validattion.InputString();
                Console.Write("Password: ");
                string password = Validattion.InputString();
                Console.WriteLine("--------------------------------------");
                Employee employee = _dal.Login(username, password);
                if (employee == null)
                {
                    Console.WriteLine("Username or password is not correct");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Employee.EMP = employee;
                    if (employee.Roles == 1)
                    {
                        Console.Clear();
                        //HR 
                        new HRManager().Run();
                    }
                    else
                    {
                        Console.Clear();
                        //staff
                        new StaffUI().Run();
                    }
                }
            }
        }

        public void ChangePassword()
        {
            Employee employee = Employee.EMP;
            Console.Write("Input your current password: ");
            string current = Validattion.InputString();
            if (current == employee.Password)
            {
                Console.Write("Input new password: ");
                employee.Password = Validattion.InputString();
                new EmployeeDAL().ChangePassword(employee);
            }
            else
            {
                Console.WriteLine("Password iscorrect");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}