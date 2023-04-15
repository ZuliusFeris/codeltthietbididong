using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using QLSinhVien.Controller;
using QLSinhVien.Views;
using QLSinhVien.Models;

namespace QLSinhVien
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async protected override void OnAppearing()
        {
            //hiển thị danh sách sinh viên
            listsinhvien.ItemsSource = await App.Db.listSV();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            //sự kiện thêm sinh viên
            Navigation.PushAsync(new AddSV());
        }

        private void BtnSua_Clicked(object sender, EventArgs e)
        {
            //sự kiên sửa
            Button button = sender as Button;
            Grid grib = (Grid)button.Parent;
            //lấy thông tin trong grib
            Label id = grib.FindByName<Label>("lblid");
            Label hoten = grib.FindByName<Label>("lblhoten");
            Label ngaysinh = grib.FindByName<Label>("lblngaysinh");
            Label gioitinh = grib.FindByName<Label>("lblgioitinh");
            Label sdt = grib.FindByName<Label>("lblsdt");
            //tạo mới sinhvien và cập nhật sinh viên
            sinhvien sv = new sinhvien();
            sv.id = Convert.ToInt32(id.Text);
            sv.hoten = hoten.Text;
            sv.ngaysinh = Convert.ToDateTime(ngaysinh.Text);
            sv.gioitinh = gioitinh.Text ;
            sv.sdt = sdt.Text;
            Navigation.PushAsync(new AddSV(sv));
        }

        private async void BtnXoa_Clicked(object sender, EventArgs e)
        {
            //sự kiện xóa sinh viên
            var ans = await DisplayAlert("Cảnh báo!", "Bạn chắc chắn muốn xóa?", "Yes", "No");
            if (ans == true)
            {
                Button button = sender as Button;
                Grid grib = (Grid)button.Parent;
                Label id = grib.FindByName<Label>("lblid");
                sinhvien sv = await App.Db.getSV(Convert.ToInt32(id.Text));
                int xoasv = await App.Db.deleted(sv);
                listsinhvien.ItemsSource = await App.Db.listSV();
            }
            
            
        }

        private void OnNoteAddedClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Diem());
        }
    }
}
