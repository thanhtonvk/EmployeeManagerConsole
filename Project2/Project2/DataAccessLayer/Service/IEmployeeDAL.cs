using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public interface IEmployeeDAL
    {


        // lay ve danh sacch tu csdl
        public List<Employee> GetAll();


        //them vao csdl
        public void Add(Employee employee);


        //cap nhat
        public void Update(int idx, Employee employee);

        //update password
        public void ChangePassword(Employee employee);


        //xoa
        public void Delete(int idx, Employee employee);



        public Employee Login(string username, string password);
       
    }
}