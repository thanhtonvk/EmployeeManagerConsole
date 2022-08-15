using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public interface IProductDAL
    {

        // lay ve danh sacch tu csdl
        public List<Product> GetAll();


        //them vao csdl
        public void Add(Product product);

        //cap nhat
        public void Update(int idx, Product product);
        

        //xoa
        public void Delete(int idx, Product product);
       
    }
}