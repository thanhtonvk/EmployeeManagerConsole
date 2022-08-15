using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public interface ICategoryDAL
    {

        // lay ve danh sacch tu csdl
        public List<Category> GetAll();


        //them vao csdl
        public void Add(Category category);

        //cap nhat
        public void Update(int idx, Category category);

        //xoa
        public void Delete(int idx, Category category);
       
        
    }
}