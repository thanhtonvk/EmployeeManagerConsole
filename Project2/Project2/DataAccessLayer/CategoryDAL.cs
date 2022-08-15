using System.Collections.Generic;
using System.IO;
using Project2.Model;

namespace Project2.DataAccessLayer
{
    //them sua xoa lay ve danh sach tu csdl
    public class CategoryDAL:ICategoryDAL
    {
        //file path
        private string file = "category.txt";

        // lay ve danh sacch tu csdl
        public List<Category> GetAll()
        {
            // khoi tao ds
            List<Category> list = new List<Category>();
            if (File.Exists(file))
            {
                //mo luong doc file
                using (StreamReader reader = new StreamReader(file))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) //doc tung dong
                    {
                        string[] arr = line.Split("#"); //tach chuoi luu vao mang
                        Category category = new Category(int.Parse(arr[0]), arr[1], arr[2]); //luu thong ttin vao doi tuong
                        list.Add(category); //them vao ds
                    }
                }
            }
           

            return list;
        }

        //them vao csdl
        public void Add(Category category)
        {
            var list = GetAll();//get ve ds
            list.Add(category);//them vao ds
            using (StreamWriter writer = new StreamWriter(file))//mo luong ghi file
            {
                foreach (var ctx in list)//duyet ds
                {
                    writer.WriteLine(ctx.ToString());//ghi vao file
                }
            }
        }
        //cap nhat
        public void Update(int idx, Category category)
        {
            var list = GetAll();//get ve ds
            list[idx] = category;//cap nhat vi tri
            using (StreamWriter writer = new StreamWriter(file))//mo luong ghi file
            {
                foreach (var ctx in list)//duyet ds
                {
                    writer.WriteLine(ctx.ToString());//ghi vao file
                }
            }
        }
        //xoa
        public void Delete(int idx, Category category)
        {
            var list = GetAll();//get ve ds
            list.RemoveAt(idx);//xoa theo vi tri
            using (StreamWriter writer = new StreamWriter(file))//mo luong ghi file
            {
                foreach (var ctx in list)//duyet ds
                {
                    writer.WriteLine(ctx.ToString());//ghi vao file
                }
            }
        }
        
    }
}