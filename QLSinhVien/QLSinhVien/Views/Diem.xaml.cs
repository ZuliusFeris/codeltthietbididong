using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QLSinhVien.Models;

namespace QLSinhVien.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Diem : ContentPage
    {
        List<tkb> t = new List<tkb>();
        //{
        //    new tkb(){T2="",T3="",T4="",T5="",T6="",T7="" },
        //    new tkb(){T2="",T3="",T4="",T5="",T6="",T7="" },
        //    new tkb(){T2="",T3="",T4="",T5="",T6="",T7="" },
        //    new tkb(){T2="",T3="",T4="",T5="",T6="",T7="" },
        //    new tkb(){T2="",T3="",T4="",T5="",T6="",T7="" },
        //    new tkb(){T2="",T3="",T4="",T5="",T6="",T7="" },
        //    new tkb(){T2="",T3="",T4="",T5="",T6="",T7="" },
        //    new tkb(){T2="",T3="",T4="",T5="",T6="",T7="" },
        //    new tkb(){T2="",T3="",T4="",T5="",T6="",T7="" }
        //};



        public Diem()
        {
            InitializeComponent();
            t.Add(new tkb {Class="20TH",  T2 = "Lập trình HDT", T3 = "Phát triển UD", T4 = "Cơ sở dữ liệu", T5 = "Lịch sử Đảng", T6 = "Lập trình mạng", T7 = "Lập trình trên tbdđ" });
            t.Add(new tkb { Class = "20KT", T2 = "Kế toán ngân hàng", T3 = "AV chuyên ngành 3", T4 = "Phân tích hoạt động kd", T5 = "Kế toán tài chính", T6 = "Kế toán quản trị", T7 = "Kiểm toán" });
            t.Add(new tkb { Class = "20TC", T2 = "AV chuyên ngành 3", T3 = "Phân tích và đầu tư ck", T4 = "Báo cáo tài chính", T5 = "Thẩm định tín dụng", T6 = "Bảo hiểm", T7 = "Ngân hàng quốc tế" });
            t.Add(new tkb { Class = "20XD", T2 = "An toàn lao động", T3 = "Thiết kế công trình", T4 = "AV chuyên ngành 3", T5 = "Đồ án kết cấu", T6 = "Công trình cơ bản", T7 = "Công trình nâng cao" });
            t.Add(new tkb { Class = "20TA", T2 = "Văn học Anh", T3 = "Nghệ thuật hùng biện", T4 = "Kĩ thuật giảng dạy", T5 = "PP nghiên cứu khoa học", T6 = "Ngữ nghĩa học", T7 = "TA B2.1" });
            t.Add(new tkb { Class = "20MK", T2 = "Quản trị sản phẩm", T3 = "Quản trị giá doanh nghiệp", T4 = "Tổ chức sự kiện", T5 = "Truyền thông", T6 = "Maketing mối quan hệ", T7 = "Maketing thương mại" });
            t.Add(new tkb { Class = "20LK", T2 = "Pháp luật thuế", T3 = "Tư vấn pháp luật", T4 = "Luật chứng khoán", T5 = "Luật thương mại", T6 = "Giải quyết tranh chấp", T7 = "Đạo đức nghề nghiệp" });
            t.Add(new tkb { Class = "20QT", T2 = "Hành vi tổ chức", T3 = "AV chuyên ngành 3", T4 = "Quản trị sản xuất", T5 = "Hệ thống thông tin", T6 = "Quản trị chiến lược", T7 = "Quản trị công chúng" });
            t.Add(new tkb { Class = "20DL", T2 = "Luật du lịch", T3 = "Luật môi trường", T4 = "Thẩm định dự án", T5 = "Thương mại điện tử", T6 = "Khởi tạo doanh nghiệp", T7 = "AV B2.1" });
            pkrClass.ItemsSource = t;
        }

        

        private void pkrClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectClass = pkrClass.SelectedIndex;
            d1.Text = t[selectClass].T2;
            d2.Text = t[selectClass].T3;
            d3.Text = t[selectClass].T4;
            d4.Text = t[selectClass].T5;
            d5.Text = t[selectClass].T6;
            d6.Text = t[selectClass].T7;
            
        }
    }
}