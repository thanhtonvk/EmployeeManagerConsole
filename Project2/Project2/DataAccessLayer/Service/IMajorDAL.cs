using System;
using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public interface IMajorDAL
    {


        // lay ve danh sacch tu csdl
        public List<Major> GetAll();


        //them vao csdl
        public void Add(Major major);


        //cap nhat
        public void Update(int idx, Major major);


        //xoa
        public void Delete(int idx, Major major);
        
    }
}