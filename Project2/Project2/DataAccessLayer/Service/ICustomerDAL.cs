using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public interface ICustomerDAL
    {


        // lay ve danh sacch tu csdl
        public List<Customer> GetAll();


        //them vao csdl
        public void Add(Customer customer);


        //cap nhat
        public void Update(int idx, Customer customer);


        //xoa
        public void Delete(int idx, Customer customer);
        

      
    }
}