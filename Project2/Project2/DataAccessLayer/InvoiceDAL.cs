using System;
using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public class InvoiceDAL
    {
        //file path
        private string file = "invoice.txt";

        // lay ve danh sacch tu csdl
        public List<Invoice> GetAll()
        {
            // khoi tao ds
            List<Invoice> list = new List<Invoice>();
            if (File.Exists(file))
            {
                //mo luong doc file
                            using (StreamReader reader = new StreamReader(file))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null) //doc tung dong
                                {
                                    string[] arr = line.Split("#"); //tach chuoi luu vao mang
                                    Invoice invoice = new Invoice(int.Parse(arr[0]), DateTime.Parse(arr[1]), int.Parse(arr[2]),
                                        arr[3], int.Parse(arr[4])); //luu thong ttin vao doi tuong
                                    list.Add(invoice); //them vao ds
                                }
                            }
            }
            

            return list;
        }

        //them vao csdl
        public void Add(Invoice invoice)
        {
            var list = GetAll(); //get ve ds
            list.Add(invoice); //them vao ds
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //cap nhat
        public void Update(int idx, Invoice invoice)
        {
            var list = GetAll(); //get ve ds
            list[idx] = invoice; //cap nhat vi tri
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //xoa
        public void Delete(int idx, Invoice invoice)
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
    }
}