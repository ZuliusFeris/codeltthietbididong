using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QLSinhVien.Controller;
using System.IO;

namespace QLSinhVien
{
    public partial class App : Application
    {
        private static quanlisinhvien _db;
        public static quanlisinhvien Db
        {
            get
            {
                if (_db == null)
                    //khai báo đường dẫn file
                    _db = new quanlisinhvien(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "qlsv.db3"));
                return _db;
            }
        }
        public App()
        {
            InitializeComponent();
            //kích hoạt trang chính hiển thị của ứng dụng
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
