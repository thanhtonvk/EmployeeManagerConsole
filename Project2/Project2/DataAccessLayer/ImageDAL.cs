using System;
using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public class ImageDAL: IImageDAL
    {
        //file path
        private string file = "image.txt";

        // lay ve danh sacch tu csdl
        public List<Image> GetAll()
        {
            // khoi tao ds
            List<Image> list = new List<Image>();
            if (File.Exists(file))
            {
                 //mo luong doc file
                            using (StreamReader reader = new StreamReader(file))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null) //doc tung dong
                                {
                                    string[] arr = line.Split("#"); //tach chuoi luu vao mang
                                    Image image = new Image(int.Parse(arr[0]), arr[1], arr[2], int.Parse(arr[3])); //luu thong ttin vao doi tuong
                                    list.Add(image); //them vao ds
                                }
                            }
            }
           

            return list;
        }

        //them vao csdl
        public void Add(Image image)
        {
            var list = GetAll(); //get ve ds
            list.Add(image); //them vao ds
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //cap nhat
        public void Update(int idx, Image image)
        {
            var list = GetAll(); //get ve ds
            list[idx] = image; //cap nhat vi tri
            using (StreamWriter writer = new StreamWriter(file)) //mo luong ghi file
            {
                foreach (var ctx in list) //duyet ds
                {
                    writer.WriteLine(ctx.ToString()); //ghi vao file
                }
            }
        }

        //xoa
        public void Delete(int idx, Image image)
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