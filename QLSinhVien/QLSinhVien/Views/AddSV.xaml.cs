using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QLSinhVien.Models;

namespace QLSinhVien.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSV : ContentPage
    {
        int id = 0;
        public AddSV(sinhvien sv = null)
        {
            InitializeComponent();
            //kiểm tra sự kiện
            if (sv != null)
            {
                id = sv.id;
                txtHoten.Text = sv.hoten;
                txtNgaysinh.Date=sv.ngaysinh;
                pkGioitinh.SelectedItem = sv.gioitinh;
                txtSDT.Text = sv.sdt;
            }
            else
                id = 0;
        }

        //sự kiện thêm sinh viên
        private void BtnThem_Clicked(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv.id = id;
            sv.hoten = txtHoten.Text;
            sv.ngaysinh = Convert.ToDateTime( txtNgaysinh.Date);
            sv.gioitinh = (pkGioitinh.SelectedItem.ToString() == "Nam") ? "Nam" : "Nữ";
            sv.sdt = txtSDT.Text;
            App.Db.save(sv);
            Navigation.PopAsync();
        }

        
    }
}