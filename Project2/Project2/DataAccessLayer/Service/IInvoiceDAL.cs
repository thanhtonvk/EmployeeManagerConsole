using System;
using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public interface IInvoiceDAL
    {

        public List<Invoice> GetAll();

        //them vao csdl
        public void Add(Invoice invoice);


        //cap nhat
        public void Update(int idx, Invoice invoice);

        //xoa
        public void Delete(int idx, Invoice invoice);
      
    }
}