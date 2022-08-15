using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public class CustomerDAL: ICustomerDAL
    {
        //file path
        private string file = "customer.txt";

        // lay ve danh sacch tu csdl
        public List<Customer> GetAll()
        {
            // khoi tao ds
            List<Customer> list = new List<Customer>();
            if (File.Exists(file))
            {
                 //mo luong doc file
                            using (StreamReader reader = new StreamReader(file))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null) //doc tung dong
                                {
                                    string[] arr = line.Split("#"); //tach chuoi luu vao mang
                                    Customer customer = new Customer(int.Parse(arr[0]), arr[1], arr[2], int.Parse(arr[3])); //luu thong ttin vao doi tuong
                                    list.Add(customer); //them vao ds
                                }
                            }
            }
           

            return list;
        }

        //them vao csdl
        public void Add(Customer customer)
        {
            var list = GetAll(); //get ve ds
            list.Add(customer); //them vao ds
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //cap nhat
        public void Update(int idx, Customer customer)
        {
            var list = GetAll(); //get ve ds
            list[idx] = customer; //cap nhat vi tri
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //xoa
        public void Delete(int idx, Customer customer)
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