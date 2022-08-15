using System;
using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public interface IImageDAL
    {


        // lay ve danh sacch tu csdl
        public List<Image> GetAll();


        //them vao csdl
        public void Add(Image image);

        //cap nhat
        public void Update(int idx, Image image);


        //xoa
        public void Delete(int idx, Image image);
       
    }
}