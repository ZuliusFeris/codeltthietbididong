using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QLSinhVien
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void log(object sender, EventArgs e)
        {
            if(user.Text=="20TH"&& password.Text == "12345")
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Cảnh báo!", "Sai tài khoản hoặc mật khẩu", "OK");
            }
        }
    }
}