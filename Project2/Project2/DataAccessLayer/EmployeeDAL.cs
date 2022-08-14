using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public class EmployeeDAL
    {
        //file path
        private string file = "employee.txt";

        // lay ve danh sacch tu csdl
        public List<Employee> GetAll()
        {
            // khoi tao ds
            List<Employee> list = new List<Employee>();
            if (File.Exists(file))
            {
                //mo luong doc file
                using (StreamReader reader = new StreamReader(file))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) //doc tung dong
                    {
                        string[] arr = line.Split("#"); //tach chuoi luu vao mang
                        Employee employee = new Employee(int.Parse(arr[0]), arr[1], DateTime.Parse(arr[2]), arr[3],
                            int.Parse(arr[4]),
                            arr[5], arr[6], int.Parse(arr[7])); //luu thong ttin vao doi tuong
                        list.Add(employee); //them vao ds
                    }
                }
            }
            

            return list;
        }

        //them vao csdl
        public void Add(Employee employee)
        {
            var list = GetAll(); //get ve ds
            list.Add(employee); //them vao ds
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //cap nhat
        public void Update(int idx, Employee employee)
        {
            var list = GetAll(); //get ve ds
            list[idx] = employee; //cap nhat vi tri
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }
        //update password
        public void ChangePassword(Employee employee)
        {
            var list = GetAll(); //get ve ds
            int idx = GetAll().FindIndex(x => x.Id == employee.Id);
            list[idx] = employee; //cap nhat vi tri
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //xoa
        public void Delete(int idx, Employee employee)
        {
            var list = GetAll(); //get ve ds
            list.RemoveAt(idx); //xoa theo vi tri
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        public Employee Login(string username, string password)
        {
            return GetAll().FirstOrDefault(x => x.AccountName == username && x.Password == password);
        }
    }
}