using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using QLSinhVien.Models;
using System.Threading.Tasks;

namespace QLSinhVien.Controller
{
    public class quanlisinhvien
    {
        private SQLiteAsyncConnection csdl;
        // hàm khởi tạo sqlite
        public quanlisinhvien(string duongdan)
        {
            csdl = new SQLiteAsyncConnection(duongdan);
            csdl.CreateTableAsync<sinhvien>().Wait();
        }
        //nhap danh sach sinh vien
        public Task<List<sinhvien>> listSV()
        {
            return csdl.Table<sinhvien>().ToListAsync();
        }
        //tim sinh vien theo id
        public Task<sinhvien> getSV(int id)
        {
            return csdl.Table<sinhvien>().Where(p => p.id == id).FirstOrDefaultAsync();
        }
        //cap nhat sv
        public Task<int> save(sinhvien sv)
        {
            if (sv.id == 0)
                return csdl.InsertAsync(sv);
            else
                return csdl.UpdateAsync(sv);
        }
        //xoa sv
        public Task<int> deleted(sinhvien sv)
        {
            return csdl.DeleteAsync(sv);
        }

    }
}
