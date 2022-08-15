using System;
using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public class MajorDAL: IMajorDAL
    {
        //file path
        private string file = "major.txt";

        // lay ve danh sacch tu csdl
        public List<Major> GetAll()
        {
            // khoi tao ds
            List<Major> list = new List<Major>();
            if (File.Exists(file))
            {
                 //mo luong doc file
                            using (StreamReader reader = new StreamReader(file))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null) //doc tung dong
                                {
                                    string[] arr = line.Split("#"); //tach chuoi luu vao mang
                                    Major major = new Major(int.Parse(arr[0]), int.Parse(arr[1]),
                                        arr[2]); //luu thong ttin vao doi tuong
                                    list.Add(major); //them vao ds
                                }
                            }
            }
           

            return list;
        }

        //them vao csdl
        public void Add(Major major)
        {
            var list = GetAll(); //get ve ds
            list.Add(major); //them vao ds
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //cap nhat
        public void Update(int idx, Major major)
        {
            var list = GetAll(); //get ve ds
            list[idx] = major; //cap nhat vi tri
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //xoa
        public void Delete(int idx, Major major)
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