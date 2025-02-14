using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tx2_haui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<NhanVien> dsNhanVien = new List<NhanVien>();
        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            if (isKiemTra())
            {
                NhanVien nvMoi = new NhanVien();
                nvMoi.MaNV = int.Parse(txtMa.Text);
                nvMoi.HoTen = txtName.Text;
                nvMoi.NgaySinh = Convert.ToDateTime(dpNgaySinh.SelectedDate);
                if (radNam.IsChecked == true)
                {
                    nvMoi.GioiTinh = "Nam";
                }
                else
                {
                    nvMoi.GioiTinh = "Nữ";
                }
                nvMoi.PhongBan = cboPhongBan.Text;
                nvMoi.HeSoLuong = double.Parse(txtHeSoLuong.Text);
                dsNhanVien.Add(nvMoi);
                dtgNhanVien.ItemsSource = null;
                dtgNhanVien.ItemsSource = dsNhanVien; 
            }
        }
        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            int tuoiMax = dsNhanVien[0].Tuoi;
            for (int i = 1; i < dsNhanVien.Count; i++) 
            {
                if (dsNhanVien[i].Tuoi > tuoiMax)
                    tuoiMax = dsNhanVien[i].Tuoi;
            }
            List<NhanVien>dsTuoiMax = new List<NhanVien>();
            foreach(var item in dsNhanVien)
            {
                if (item.Tuoi == tuoiMax)
                {
                    dsTuoiMax.Add(item); 
                }
            }
            Window2 myWindow = new Window2();
            myWindow.dtgTuoiMax.ItemsSource=dsTuoiMax;
            myWindow.Show();
        }

        private void btnWindow_Loaded(object sender, RoutedEventArgs e)
        {
            dpNgaySinh.SelectedDate= DateTime.Now;
        }
        private bool isKiemTra()
        {
            if(txtMa.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên","Lõi nhập dữ liệu",MessageBoxButton.OK, MessageBoxImage.Error);
                txtMa.Focus();
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Lõi nhập dữ liệu", MessageBoxButton.OK, MessageBoxImage.Error);
                txtName.Focus();
                return false;
            }
            if (txtHeSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hệ số lương", "Lõi nhập dữ liệu", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHeSoLuong.Focus();
                return false;
            }
            try
            {
                double.Parse(txtHeSoLuong.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("hệ số lương là số thực","lỗi nhập dữ liệu",MessageBoxButton.OK,MessageBoxImage.Error);
                txtHeSoLuong.SelectAll();
                txtHeSoLuong.Focus();
                return false;
            }
            int Tuoi = DateTime.Now.Year - dpNgaySinh.SelectedDate.Value.Year;
            if (Tuoi < 18)
            {
                MessageBox.Show("tuổi phải >18", "lỗi nhập dữ liệu", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}