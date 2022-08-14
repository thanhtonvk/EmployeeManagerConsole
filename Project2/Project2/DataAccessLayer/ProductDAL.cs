using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public class ProductDAL
    {
        //file path
        private string file = "product.txt";

        // lay ve danh sacch tu csdl
        public List<Product> GetAll()
        {
            // khoi tao ds
            List<Product> list = new List<Product>();
            if (File.Exists(file))
            {
                //mo luong doc file
                using (StreamReader reader = new StreamReader(file))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) //doc tung dong
                    {
                        string[] arr = line.Split("#"); //tach chuoi luu vao mang
                        Product product = new Product(int.Parse(arr[0]), arr[1],
                            int.Parse(arr[2]), int.Parse(arr[3]), arr[4], arr[5], int.Parse(arr[6]),
                            int.Parse(arr[7])); //luu thong ttin vao doi tuong
                        list.Add(product); //them vao ds
                    }
                }
            }


            return list;
        }

        //them vao csdl
        public void Add(Product product)
        {
            var list = GetAll(); //get ve ds
            list.Add(product); //them vao ds
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //cap nhat
        public void Update(int idx, Product product)
        {
            var list = GetAll(); //get ve ds
            list[idx] = product; //cap nhat vi tri
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //xoa
        public void Delete(int idx, Product product)
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